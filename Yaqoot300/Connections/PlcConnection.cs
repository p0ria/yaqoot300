using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SimpleTcp;

namespace Yaqoot300.Connections
{
    public class PlcConnection
    {
        private readonly TcpServer server;
        private string client;

        public event EventHandler<byte[]> DataReceived;

        public PlcConnection()
        {
            // instantiate
            server = new TcpServer("127.0.0.1", 9000, false, null, null);
            server.IdleClientTimeoutSeconds = int.MaxValue;

            // set callbacks
            server.ClientConnected += ClientConnected;
            server.ClientDisconnected += ClientDisconnected;
            server.DataReceived += OnDataReceived;
        }

        public void Send(params byte[] data)
        {
            if(IsConnected)
                server.Send(client, data);
        }

        public void Listen()
        {
            try
            {
                server.Start();
            }
            catch (Exception e)
            {
                Console.WriteLine("Error..... " + e.StackTrace);
            }
        }

        private void ClientConnected(object sender, ClientConnectedEventArgs e)
        {
            client = e.IpPort;
        }

        private void OnDataReceived(object sender, DataReceivedFromClientEventArgs e)
        {
            this.DataReceived?.Invoke(this, e.Data);
        }

        private void ClientDisconnected(object sender, ClientDisconnectedEventArgs e)
        {
            Console.WriteLine("[" + e.IpPort + "] client disconnected: " + e.Reason.ToString());
        }

        public bool IsConnected => !string.IsNullOrEmpty(client);

    }
}
