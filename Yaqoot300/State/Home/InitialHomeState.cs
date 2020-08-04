using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Yaqoot300.Interfaces;

namespace Yaqoot300.State.Home
{
    public static class InitialHomeState
    {
        private static readonly HomeState _instance = new HomeState
        {
            Auto = new AutoState
            {
                StartBtn = new AutoStartBtnState
                {
                    Status = AutoStartBtnStatus.Stoped,
                    IsEnabled = true
                }
            },
            HomeReaders = new HomeReaderState[30]
        };

        public static HomeState Instance => _instance;
    }
}
