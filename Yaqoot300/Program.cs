﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Yaqoot300.Commons;

namespace Yaqoot300
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.ApplicationExit += OnApplicationExit;
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            var mainForm = new MainForm();
            Services.MainForm = mainForm;
            Application.Run(mainForm);
            
        }

        private static void OnApplicationExit(object sender, EventArgs eventArgs)
        {
            Services.PlcConnection?.Dispose();
        }
    }
}
