using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Yaqoot300.Connections;
using Yaqoot300.Interfaces;
using Yaqoot300.Modals;
using Yaqoot300.Models.Signal;
using Yaqoot300.State;

namespace Yaqoot300.Commons
{
    public static class Services
    {
        public static Config Config { get; }
        public static Store Store { get; }
        public static MessagesService Messages { get; }
        public static Signals Signals { get; }
        public static PlcConnection PlcConnection { get; }
        public static CheckingsService CheckingsService { get; }
        public static Form MainForm { get; set; }
        
        static Services()
        {
            Messages = new MessagesService();
            Config = Config.FromFile;
            if (Config == null)
            {
                Messages.Error("Unable to load config.json file", MessageCategory.App);
                Config = Config.Default;
            }
            Store = new Store();
            Signals = new Signals();
            PlcConnection = new PlcConnection();
            CheckingsService = new CheckingsService();
        }
    }
}
