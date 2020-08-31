using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Yaqoot300.Interfaces;

namespace Yaqoot300.State.App
{
    public static class InitialAppState
    {
        private static readonly AppState _instance = new AppState
        {
            SelectedMode = Mode.Service,
            Connections =
            {
                ServerConnection = ConnectionStatus.Disconnected,
                DbConnection = ConnectionStatus.Connected,
                PLCConnection = ConnectionStatus.Disconnected,
                ThinClient1Connection = ConnectionStatus.Disconnected,
                ThinClient2Connection = ConnectionStatus.Disconnected,
                ThinClient3Connection = ConnectionStatus.Disconnected
            }
        };

        public static AppState Instance => _instance;
    }
}
