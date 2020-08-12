using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Yaqoot300.Commons;
using Yaqoot300.Interfaces;

namespace Yaqoot300.State.Home
{
    public class HomeState
    {
        public HomeReadersState HomeReaders { get; set; }
        public AutoState Auto { get; set; }

        public List<PlcErrorState> PlcErrors { get; set; }

        public HomeState()
        {
            this.HomeReaders = new HomeReadersState();
            this.Auto = new AutoState();
            this.PlcErrors = new List<PlcErrorState>();
        }
    }
}
