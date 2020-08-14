using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Yaqoot300.Connections;
using Yaqoot300.Interfaces;
using Yaqoot300.Modals;
using Yaqoot300.Models.Signal;
using Yaqoot300.State;

namespace Yaqoot300.Commons
{
    public static class ServiceProvider
    {
        public static Config Config { get; }
        public static Store Store { get; }
        public static MessagesDialog Messages { get; }
        public static Signals Signals { get; }
        public static PlcConnection PlcConnection { get; }
        
        static ServiceProvider()
        {
            Config = LoadFromConfigFile();
            Store = new Store();
            Messages = new MessagesDialog();
            Signals = new Signals();
            PlcConnection = new PlcConnection();
        }

        static Config LoadFromConfigFile()
        {
            try
            {
                var json = File.ReadAllText("config.json");
                return Utils.ParseJson<Config>(json);
            }
            catch (Exception e)
            {
                Messages.Error("Unable to load config.json file", MessageCategory.App);
                return Config.Default;
            }
        }
    }
}
