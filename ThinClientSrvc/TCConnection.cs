using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shared.common;
using Shared.Common;
using Shared.ThinClient.Responses;
using SimpleTcp;

namespace ThinClientSrvc
{
    public class TCConnection : IDisposable
    {
        protected static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        private readonly TcpServer server;
        private string client;
        private readonly string ip;
        private readonly int port;

        public TCConnection(string ip, int port)
        {
            try
            {
                this.ip = ip;
                this.port = port;
                server = new TcpServer(ip, port, false, null, null);
                server.IdleClientTimeoutSeconds = int.MaxValue;

                server.ClientConnected += ClientConnected;
                server.ClientDisconnected += ClientDisconnected;
                server.DataReceived += OnDataReceived;
            }
            catch (Exception ex)
            {
                log.Error("PLC Server instantiation error: ", ex);
                throw;
            }
        }

        public bool Send(object data)
        {
            try
            {
                if (IsConnected)
                {
                    server.Send(client, data.ToJson());
                    return true;
                }
                return false;

            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public void Listen()
        {
            try
            {
                TcpUtils.ReleasePort(port);
                server.Start();
                log.Info($"The server is listening on {ip}:{port}");
                Console.WriteLine($"The server is listening on {ip}:{port}");
            }
            catch (Exception e)
            {
                log.Error($"Server unable to listen on '{ip}:{port}'");
                throw e;
            }
        }

        private void ClientConnected(object sender, ClientConnectedEventArgs e)
        {
            client = e.IpPort;
           log.Info($"Client '{e.IpPort}' connected");
        }

        private void OnDataReceived(object sender, DataReceivedFromClientEventArgs e)
        {
            
        }

        private void ClientDisconnected(object sender, ClientDisconnectedEventArgs e)
        {
            client = null;
            log.Error($"Client '{e.IpPort}' disconnected from server, {e.Reason}");
        }

        public bool IsConnected => !string.IsNullOrEmpty(client);

        public void Dispose()
        {

            try
            {
                server?.Dispose();
            }
            catch (Exception)
            {
                // ignored
            }
        }
    }
}
