using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Yaqoot300.Commons;
using Yaqoot300.Interfaces;

namespace Yaqoot300.State.Service
{
    public static class InitialServiceState
    {
        private static readonly ServiceState _instance = new ServiceState
        {
            Sensors = new [] { false, false, true, true, true, true, false, false, false, false, false, true, true, false },
            Motors = new ServiceMotorsState
            {
                M0 = new ServiceMotorState
                {
                    Status = RotateMotorStatus.Stopped,
                    IsEnabled = true
                },
                M1 = new ServiceMotorState
                {
                    Status = RotateMotorStatus.Stopped,
                    IsEnabled = true
                },
                M2 = new ServiceMotorState
                {
                    Status = RotateMotorStatus.Stopped,
                    IsEnabled = true
                },
                M3 = new ServiceMotorState
                {
                    Status = RotateMotorStatus.Stopped,
                    IsEnabled = true
                },
                M4 = new ServiceM4State
                {
                    Status = UpDownMotorStatus.Idle,
                    IsDownEnabled = true,
                    IsUpEnabled = true
                }
            },
            Settings = new ServiceSettingsState
            {
                ActiveReaders = 16,
                FeedInSteps = 7,
                M3StepLength = 2,
                M4Speed = 3
            },
            TestReaders = new ServiceTestReadersState
            {
                Readers = new TestReaderStatus[Constants.READERS_COUNT]
            },
            SetupReaders = new ServiceSetupReadersState
            {
                Readers = new List<SetupReaderState>
                {
                    new SetupReaderState {ReaderName = "ACS 39U 0"},
                    new SetupReaderState {ReaderName = "ACS 39U 1"},
                    new SetupReaderState {ReaderName = "ACS 39U 2"},
                    new SetupReaderState {ReaderName = "ACS 39U 3"},
                    new SetupReaderState {ReaderName = "ACS 39U 4"},
                    new SetupReaderState {ReaderName = "ACS 39U 5"},
                    new SetupReaderState {ReaderName = "ACS 39U 6"},
                    new SetupReaderState {ReaderName = "ACS 39U 7"},
                    new SetupReaderState {ReaderName = "ACS 39U 8"},
                    new SetupReaderState {ReaderName = "ACS 39U 9"},
                    new SetupReaderState {ReaderName = "ACS 39U 10"},
                    new SetupReaderState {ReaderName = "ACS 39U 11"},
                    new SetupReaderState {ReaderName = "ACS 39U 12"},
                    new SetupReaderState {ReaderName = "ACS 39U 13"},
                    new SetupReaderState {ReaderName = "ACS 39U 14"},
                    new SetupReaderState {ReaderName = "ACS 39U 15"},
                    new SetupReaderState {ReaderName = "ACS 39U 16"},
                    new SetupReaderState {ReaderName = "ACS 39U 17", ReaderNumber = 10},
                    new SetupReaderState {ReaderName = "ACS 39U 18"},
                    new SetupReaderState {ReaderName = "ACS 39U 19"},
                    new SetupReaderState {ReaderName = "ACS 39U 20"},
                    new SetupReaderState {ReaderName = "ACS 39U 21"},
                    new SetupReaderState {ReaderName = "ACS 39U 22"},
                    new SetupReaderState {ReaderName = "ACS 39U 23"},
                    new SetupReaderState {ReaderName = "ACS 39U 24"},
                    new SetupReaderState {ReaderName = "ACS 39U 25"},
                    new SetupReaderState {ReaderName = "ACS 39U 26"},
                    new SetupReaderState {ReaderName = "ACS 39U 27"},
                    new SetupReaderState {ReaderName = "ACS 39U 28"},
                    new SetupReaderState {ReaderName = "ACS 39U 29"},
                }
            }
        };

        public static ServiceState Instance => _instance;
    }
}
