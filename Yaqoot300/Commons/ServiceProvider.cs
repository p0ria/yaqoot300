using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Yaqoot300.Modals;
using Yaqoot300.Models.Signal;
using Yaqoot300.State;

namespace Yaqoot300.Commons
{
    public static class ServiceProvider
    {
        public static Store Store { get; }
        public static MessagesDialog Messages { get; }
        public static Signals Signals { get; }
        public static PlcConnection PlcConnection { get; }

        static ServiceProvider()
        {
            Store = new Store();
            Messages = new MessagesDialog();
            Signals = new Signals();
            PlcConnection = new PlcConnection();
        }
    }
}
