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
                DbConnection = ConnectionStatus.Connecting,
                PLCConnection = ConnectionStatus.Connecting,
                ThinClient1Connection = ConnectionStatus.Connecting,
                ThinClient2Connection = ConnectionStatus.Connecting,
                ThinClient3Conenction = ConnectionStatus.Connecting
            },
            SelectedJob = null
        };

        public static AppState Instance => _instance;
    }
}
