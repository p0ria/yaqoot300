using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Yaqoot300.Commons;
using Yaqoot300.Interfaces;

namespace Yaqoot300.State.Home
{
    public static class InitialHomeState
    {
        private static HomeState _instance
        {
            get
            {
                var state = new HomeState
                {
                    Auto = new AutoState
                    {
                        StartBtn = new AutoStartBtnState
                        {
                            Status = AutoStartBtnStatus.Stoped,
                            IsEnabled = true
                        }
                    },
                    HomeReaders = new HomeReadersState(),
                    PlcErrors = new List<PlcErrorState>()
                };
                for (int i = 0; i < Constants.READERS_COUNT; i++)
                    state.HomeReaders.Readers.Add(new HomeReaderState(i + 1, ReaderStatus.Idle));
                return state;
            }
        }

        public static HomeState Instance => _instance;
    }
}
