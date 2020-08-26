using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shared.common;
using Shared.Interfaces;

namespace Shared.Common
{
    public class Config
    {
        public ServerConfig Server { get; set; }

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
                    return Utils.ParseJson<Config>(json);
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
        public ServerConfig Server { get; set; }
        
        
    }
}
