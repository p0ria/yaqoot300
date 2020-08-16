using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlcSimulator.Common
{
    public static class Logs
    {
        public const int MAX_ITEMS_COUNT = 50;
        public static ListBox LogsListBox { get; set; }

        public static void Log(string msg)
        {
            if (LogsListBox.Items.Count >= MAX_ITEMS_COUNT)
            {
                LogsListBox.Items.RemoveAt(MAX_ITEMS_COUNT - 1);
            }
            LogsListBox.Items.Insert(0, msg);
        }
    }

    public static class SignalLogs
    {
        public const int MAX_ITEMS_COUNT = 50;
        public static ListBox SignalsListBox { get; set; }

        public static void Log(string msg)
        {
            if (SignalsListBox.Items.Count >= MAX_ITEMS_COUNT)
            {
                SignalsListBox.Items.RemoveAt(MAX_ITEMS_COUNT - 1);
            }
            SignalsListBox.Items.Insert(0, msg);
        }
    }
}
