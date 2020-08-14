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
            SelectedMode = Mode.Auto,
            Connections =
            {
                DbConnection = ConnectionStatus.Connected,
                PLCConnection = ConnectionStatus.Disconnected,
                ThinClient1Connection = ConnectionStatus.Connecting,
                ThinClient2Connection = ConnectionStatus.Connecting,
                ThinClient3Connection = ConnectionStatus.Connecting
            }
        };

        public static AppState Instance => _instance;
    }
}
