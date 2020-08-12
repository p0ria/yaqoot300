using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Yaqoot300.Commons;

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

        public void FromPlc(params byte[] bytes)
        {
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

        public void ToPlc(byte[] id, params byte[] data)
        {
            var signal = new List<byte>(id);
            if(data != null && data.Length > 0 ) signal.AddRange(data);
            ServiceProvider.PlcConnection.Send(signal.ToArray());
        }
    }
}