using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Yaqoot300.Commons;
using Yaqoot300.Interfaces;

namespace Yaqoot300.Models.Signal
{
    public class Signals
    {
        private readonly PlcSignals _plc;
        private readonly IEnumerable<PropertyInfo> _plcProps;

        public Signals()
        {
            _plc = new PlcSignals();
            _plcProps = ExtractSignalProps<PlcSignals>();
        }

        private IEnumerable<PropertyInfo> ExtractSignalProps<T>()
        {
            return typeof(T)
                .GetProperties()
                .Where(p => p.GetCustomAttribute<SignalAttribute>() != null);
        }

        public void OnRecived(byte[] bytes)
        {
            for (int i = 0; i < bytes.Length; i+= Constants.SIGNAL_BYTES_COUNT)
            {
                var chunk = new List<byte>();
                for (int j = 0; j < Constants.SIGNAL_BYTES_COUNT; j++)
                {
                    if(i + j < bytes.Length) chunk.Add(bytes[i + j]);
                }
                Receive(chunk.ToArray());
            }
        }

        private void Receive(params byte[] bytes)
        {
           // Services.Messages.Info($"[Recieved] {SignalUtils.GetPlcSignalName(bytes)} 0x{Utils.ByteArrayToHexString(bytes)}", MessageCategory.PLC);
            foreach (var pi in _plcProps)
            {
                var sr = pi.GetCustomAttribute<SignalAttribute>();
                var matched = true;
                for (int i = 0; i < sr.Index.Length; i++)
                {
                    if ((sr.Index[i] ^ bytes[i]) != 0)
                    {
                        matched = false;
                        break;
                    }
                }
                if (matched)
                {
                    pi.SetValue(_plc, bytes);
                    break;
                }
            }
        }

        public bool Send(byte[] id, params byte[] data)
        {
            var signal = new List<byte>(id);
            if(data != null && data.Length > 0 ) signal.AddRange(data);
            var byteArr = signal.ToArray();
            var sent = Services.PlcConnection.Send(byteArr);
            if(sent) Services.Messages.Info($"[Sent] {SignalUtils.GetGuiSignalName(byteArr)} 0x{Shared.Common.Utils.ByteArrayToHexString(byteArr)}", MessageCategory.PLC);
            else Services.Messages.Error($"[Error Sending] {SignalUtils.GetGuiSignalName(byteArr)} 0x{Shared.Common.Utils.ByteArrayToHexString(byteArr)}", MessageCategory.PLC);
            return sent;
        }
    }
}