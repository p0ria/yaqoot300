using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PlcSimulator.Common;
using SimpleTcp;
using Yaqoot300.Commons;


namespace PlcSimulator
{
    public class ClientConnection : IDisposable
    {
        private TcpClient client;
        public event EventHandler<bool> ConnectChanged;

        public bool Connect(string ip, int port)
        {
            try
            {
                client = new TcpClient(ip, port, false, null, null);
                client.Connected += Connected;
                client.Disconnected += Disconnected;
                client.DataReceived += DataReceived;
                client.Connect();
                return true;
            }
            catch (Exception ex)
            {
                Logs.Log("Could not connect to server, " + ex.Message);
                return false;
            }
            
        }

        public void Send(byte[] id, params byte[] data)
        {
            if (this.client.IsConnected)
            {
                var bytesList = new List<byte>(id);
                bytesList.AddRange(data);
                var bytes = bytesList.ToArray();
                this.client.Send(bytes.ToArray());
                SignalLogs.Log($"[Sent] {SignalUtils.GetPlcSignalName(bytes)} 0x{Shared.Common.Utils.ByteArrayToHexString(bytes)}");
            }
        }

        public void Disconnect()
        {
            client?.Dispose();
        }

        void Connected(object sender, EventArgs e)
        {
            Logs.Log("Connected to server");
            RaiseConnectionChanged(true);
        }

        void Disconnected(object sender, EventArgs e)
        {
            Logs.Log("Disconnected from server");
            RaiseConnectionChanged(false);

        }

        void DataReceived(object sender, DataReceivedFromServerEventArgs e)
        {
            SignalLogs.Log($"[Recieved] {SignalUtils.GetGuiSignalName(e.Data)} 0x{Shared.Common.Utils.ByteArrayToHexString(e.Data)}");
        }

        public void Dispose()
        {
            client?.Dispose();
        }

        public bool IsConnected
        {
            get { return client != null && client.IsConnected; }
        }

        private void RaiseConnectionChanged(bool isConnected)
        {
            this.ConnectChanged?.Invoke(this, isConnected);
        }
    }
}
