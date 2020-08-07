using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Yaqoot300.State;

namespace Yaqoot300.Commons
{
    public static class ServiceProvider
    {
        public static Store Store { get; }

        static ServiceProvider()
        {
            Store = new Store();
        }
    }
}
