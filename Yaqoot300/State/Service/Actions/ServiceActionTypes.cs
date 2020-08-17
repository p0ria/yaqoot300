using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yaqoot300.State.Service.Actions
{
    public static class ServiceActionTypes
    {
        public const string CHANGE_M0 = "[SERVICE] Change M0";
        public const string CHANGE_M1 = "[SERVICE] Change M1";
        public const string CHANGE_M2 = "[SERVICE] Change M2";
        public const string CHANGE_M3 = "[SERVICE] Change M3";
        public const string CHANGE_M4 = "[SERVICE] Change M4";
        public const string CHANGE_SETTINGS = "[SERVICE] Change Settings";
        public const string CHANGE_SETTINGS_SUCCESS = "[SERVICE] Change Settings Success";
        public const string CHANGE_SETTINGS_FAIL = "[SERVICE] Change Settings FAIL";
        public const string TEST_READERS = "[SERVICE] Test Readers";
        public const string TEST_READERS_SUCCESS = "[SERVICE] Test Readers Success";
        public const string TEST_READERS_FAIL = "[SERVICE] Test Readers Fail";
        public const string ASSIGN_READER = "[SERVICE] Assign Reader";
        public const string SENSORS_CHANGED = "[SERVICE] Sensors Changed";
    }
}
