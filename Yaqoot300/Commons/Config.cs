﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Yaqoot300.Interfaces;

namespace Yaqoot300.Commons
{
    public class Config
    {
        public IpPort Server { get; set; }

        public static Config Default
        {
            get
            {
                return new Config
                {
                    Server = new IpPort
                    {
                        Ip = "127.0.0.1",
                        Port = 9000
                    }
                };
            }
        }
    }

}
