﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SimpleTcp;
using Yaqoot300.Commons;
using Yaqoot300.Interfaces;
using Yaqoot300.State.App.Actions;
using Yaqoot300.State.Home.Actions;

namespace Yaqoot300.Connections
{
    public class PlcConnection: IDisposable
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        private readonly TcpServer server;
        private string client;

        public PlcConnection()
        {
            try
            {
                server = new TcpServer(Services.Config.Server.Ip, Services.Config.Server.Port, false, null, null);
                server.IdleClientTimeoutSeconds = int.MaxValue;

                server.ClientConnected += ClientConnected;
                server.ClientDisconnected += ClientDisconnected;
                server.DataReceived += OnDataReceived;

                //TODO: Remove
                 Listen();
            }
            catch (Exception ex)
            {
                MessageBox.Show("PLC Server instantiation error: " + ex);
                log.Error("PLC Server instantiation error: ", ex);
                throw;
            }
        }

        public bool Send(params byte[] data)
        {
            try
            {
                if (IsConnected)
                {
                    server.Send(client, data);
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
                TcpUtils.ReleasePort(Services.Config.Server.Port);
                server.Start();
                Services.Store.Dispatch(new AppConnectionsChangedAction(
                    new AppConnectionsChangedActionPayload {ServerConnected = ConnectionStatus.Connected}));
                Services.Messages.Info($"The server is listening on {Services.Config.Server.Ip}:{Services.Config.Server.Port}", MessageCategory.PLC);
            }
            catch (Exception e)
            {
                Services.Store.Dispatch(new AppConnectionsChangedAction(
                    new AppConnectionsChangedActionPayload { ServerConnected = ConnectionStatus.Disconnected }));
                Services.Messages.Error($"Server unable to listen on '{Services.Config.Server.Ip}:{Services.Config.Server.Port}'", MessageCategory.PLC, e);
            }
        }

        private void ClientConnected(object sender, ClientConnectedEventArgs e)
        {
            client = e.IpPort;
            Services.Messages.Info($"Client '{e.IpPort}' connected to server", MessageCategory.PLC);
            Services.Store.Dispatch(new AppConnectionsChangedAction(new AppConnectionsChangedActionPayload
            {
                PLCConnection = ConnectionStatus.Connected
            }));
        }

        private void OnDataReceived(object sender, DataReceivedFromClientEventArgs e)
        {
            Services.Signals.OnRecived(e.Data);
        }

        private void ClientDisconnected(object sender, ClientDisconnectedEventArgs e)
        {
            client = null;
            Services.Messages.Error($"Client '{e.IpPort}' disconnected from server, {e.Reason}", MessageCategory.PLC);
            Services.Store.Dispatch(new HomeChangeAutoStartAction(
                new HomeChangeAutoStartActionPayload(AutoStartBtnStatus.Stoped, true)));
            Services.Store.Dispatch(new AppConnectionsChangedAction(new AppConnectionsChangedActionPayload
            {
                PLCConnection = ConnectionStatus.Disconnected
            }));
        }

        public bool IsConnected => !string.IsNullOrEmpty(client);

        public void Dispose()
        {
            try
            {
                if (IsConnected) server?.DisconnectClient(client);
            }
            catch (Exception)
            {
                // ignored
            }

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
