using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SimpleTcp;
using Yaqoot300.Commons;
using Yaqoot300.Interfaces;
using Yaqoot300.State.App.Actions;

namespace Yaqoot300.Connections
{
    public class PlcConnection
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        private readonly TcpServer server;
        private string client;

        public PlcConnection()
        {
            try
            {
                server = new TcpServer(ServiceProvider.Config.Server.Ip, ServiceProvider.Config.Server.Port, false, null, null);
                server.IdleClientTimeoutSeconds = int.MaxValue;

                server.ClientConnected += ClientConnected;
                server.ClientDisconnected += ClientDisconnected;
                server.DataReceived += OnDataReceived;
            }
            catch (Exception ex)
            {
                MessageBox.Show("PLC Server instantiation error: " + ex);
                log.Error("PLC Server instantiation error: ", ex);
                throw;
            }
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
                ServiceProvider.Messages.Error($"Server unable to listen on '{ServiceProvider.Config.Server.Ip}:{ServiceProvider.Config.Server.Port}'", MessageCategory.App);
            }
        }

        private void ClientConnected(object sender, ClientConnectedEventArgs e)
        {
            client = e.IpPort;
            ServiceProvider.Messages.Info($"Client '{e.IpPort}' connected to server", MessageCategory.App);
            ServiceProvider.Store.Dispatch(new AppConnectionsChangedAction(new AppConnectionsChangedActionPayload
            {
                PLCConnection = ConnectionStatus.Connected
            }));
        }

        private void OnDataReceived(object sender, DataReceivedFromClientEventArgs e)
        {
            ServiceProvider.Signals.FromPlc(e.Data);
        }

        private void ClientDisconnected(object sender, ClientDisconnectedEventArgs e)
        {
            client = null;
            ServiceProvider.Messages.Info($"Client '{e.IpPort}' disconnected from server, {e.Reason}", MessageCategory.App);
            ServiceProvider.Store.Dispatch(new AppConnectionsChangedAction(new AppConnectionsChangedActionPayload
            {
                PLCConnection = ConnectionStatus.Disconnected
            }));
        }

        public bool IsConnected => !string.IsNullOrEmpty(client);

    }
}
