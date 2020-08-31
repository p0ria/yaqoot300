using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shared.Interfaces;

namespace Shared.Common
{
    public class Config
    {
        public ServerConfig Server { get; set; }
        public TCConfig Client1 { get; set; }
        public TCConfig Client2 { get; set; }
        public TCConfig Client3 { get; set; }

        public static Config Default
        {
            get
            {
                return new Config
                {
                    Server = new ServerConfig
                    {
                        Ip = "127.0.0.1",
                        Port = 9000
                    }
                };
            }
        }

        public static Config FromFile
        {
            get
            {
                try
                {
                    var json = File.ReadAllText("config.json");
                    var configFile = Utils.ParseJson<ConfigFile>(json);
                    return configFile.Environment == ConfigFile.ConfigFileEnvironment.Development
                        ? configFile.Development
                        : configFile.Production;
                }
                catch (Exception e)
                {
                    return null;
                }
            }
        }
    }

    class ConfigFile
    {
        public enum ConfigFileEnvironment
        {
            Development, Production
        }
        public ConfigFileEnvironment Environment { get; set; }
        public Config Development { get; set; }
        public Config Production { get; set; }

    }
}
