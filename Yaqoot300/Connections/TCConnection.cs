using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SimpleTcp;
using Yaqoot300.Commons;
using Yaqoot300.State.App.Actions;
using System.Threading;
using Shared.Common;

namespace Yaqoot300.Connections
{
    public class TCConnection : IDisposable
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        private TcpClient _client;
        private readonly string ip;
        private readonly int port;

        public TCConnection(string ip, int port, string serial)
        {
            this.ip = ip;
            this.port = port;
            this.Serial = serial;

            ConnectWithRetryAsync();
        }

        public string Serial { get; set; }

        public bool Connect()
        {
            try
            {
                InitClient();
                _client.Connect();
                return true;
            }
            catch (Exception ex)
            {
                log.Error($"Could not connect to thin client {ip}:{port}, {ex}");
                return false;
            }

        }

        public Task ConnectWithRetryAsync()
        {
            Services.Store.Dispatch(new AppConnectionsChangedAction(
                    new AppConnectionsChangedActionPayload
                    {
                        ThinClient1Connection = Interfaces.ConnectionStatus.Connecting
                    }));
            return Task.Run(() =>
            {
                while (!Connect())
                {
                    Thread.Sleep(500);
                }
            });
        }

        public void Send(string data)
        {
            if (_client.IsConnected)
            {
                _client.Send(data.ToJson());
            }
        }

        void InitClient()
        {
            _client = new TcpClient(ip, port, false, null, null);
            _client.Connected += Connected;
            _client.Disconnected += Disconnected;
            _client.DataReceived += DataReceived;
        }

        void Connected(object sender, EventArgs e)
        {
            Services.Store.Dispatch(new AppConnectionsChangedAction(
                    new AppConnectionsChangedActionPayload
                    {
                        ThinClient1Connection = Interfaces.ConnectionStatus.Connected
                    }));
            log.Info("Connected to server");
        }

        void Disconnected(object sender, EventArgs e)
        {
            Services.Store.Dispatch(new AppConnectionsChangedAction(
                    new AppConnectionsChangedActionPayload
                    {
                        ThinClient1Connection = Interfaces.ConnectionStatus.Disconnected
                    }));
            log.Error("Disconnected from thin client");
            ConnectWithRetryAsync();
        }

        void DataReceived(object sender, DataReceivedFromServerEventArgs e)
        {
            
        }



        public void Dispose()
        {
            _client?.Dispose();
        }

        public bool IsConnected
        {
            get { return _client != null && _client.IsConnected; }
        }
    }
}
