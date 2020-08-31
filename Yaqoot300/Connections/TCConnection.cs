using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shared.common;
using SimpleTcp;

namespace Yaqoot300.Connections
{
    public class TCConnection : IDisposable
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        private TcpClient client;

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
                log.Error("Could not connect to thin client, " + ex.Message);
                return false;
            }

        }

        public void Send(string data)
        {
            if (client.IsConnected)
            {
                client.Send(data.ToJson());
            }
        }

        public void Disconnect()
        {
            client?.Dispose();
        }

        void Connected(object sender, EventArgs e)
        {
            log.Info("Connected to server");
        }

        void Disconnected(object sender, EventArgs e)
        {
            log.Error("Disconnected from thin client");

        }

        void DataReceived(object sender, DataReceivedFromServerEventArgs e)
        {
            
        }

        public void Dispose()
        {
            client?.Dispose();
        }

        public bool IsConnected
        {
            get { return client != null && client.IsConnected; }
        }
    }
}
