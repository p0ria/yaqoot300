using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yaqoot300.State.Home
{
    public class HomeState
    {
        public HomeReaderState[] HomeReaders { get; set; }
        public AutoState Auto { get; set; }

        public HomeState()
        {
            this.HomeReaders = new HomeReaderState[30];
            this.Auto = new AutoState();
        }
    }
}
