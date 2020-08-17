﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yaqoot300.State.Service
{
    public class ServiceState
    {
        public ServiceMotorsState Motors { get; set; }
        public List<bool> Sensors { get; set; }
        public ServiceSettingsState Settings { get; set; }
        public ServiceSettingsState PendingSettings { get; set; }
        public ServiceTestReadersState TestReaders { get; set; }
        public ServiceSetupReadersState SetupReaders { get; set; }

        public ServiceState()
        {
            this.Motors = new ServiceMotorsState();
            this.Sensors = new List<bool>();
            this.Settings = new ServiceSettingsState();
            this.TestReaders = new ServiceTestReadersState();
            this.SetupReaders = new ServiceSetupReadersState();
        }
    }
}
