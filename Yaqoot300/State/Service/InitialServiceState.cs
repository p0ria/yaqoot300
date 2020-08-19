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
            Sensors = new List<bool> { false, false, false, false, false, false, false, false, false, false, false, false, false, false },
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
                M3Speed = 6,
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
                    new SetupReaderState {ReaderName = "ACS 39U 0", ReaderNumber = 1},
                    new SetupReaderState {ReaderName = "ACS 39U 1", ReaderNumber = 2},
                    new SetupReaderState {ReaderName = "ACS 39U 2", ReaderNumber = 3},
                    new SetupReaderState {ReaderName = "ACS 39U 3", ReaderNumber = 4},
                    new SetupReaderState {ReaderName = "ACS 39U 4", ReaderNumber = 5},
                    new SetupReaderState {ReaderName = "ACS 39U 5", ReaderNumber = 6},
                    new SetupReaderState {ReaderName = "ACS 39U 6", ReaderNumber = 7},
                    new SetupReaderState {ReaderName = "ACS 39U 7", ReaderNumber = 8},
                    new SetupReaderState {ReaderName = "ACS 39U 8", ReaderNumber = 9},
                    new SetupReaderState {ReaderName = "ACS 39U 9", ReaderNumber = 10},
                    new SetupReaderState {ReaderName = "ACS 39U 10", ReaderNumber = 11},
                    new SetupReaderState {ReaderName = "ACS 39U 11", ReaderNumber = 12},
                    new SetupReaderState {ReaderName = "ACS 39U 12", ReaderNumber = 13},
                    new SetupReaderState {ReaderName = "ACS 39U 13", ReaderNumber = 14},
                    new SetupReaderState {ReaderName = "ACS 39U 14", ReaderNumber = 15},
                    new SetupReaderState {ReaderName = "ACS 39U 15", ReaderNumber = 16},
                    new SetupReaderState {ReaderName = "ACS 39U 16", ReaderNumber = 17},
                    new SetupReaderState {ReaderName = "ACS 39U 17", ReaderNumber = 18},
                    new SetupReaderState {ReaderName = "ACS 39U 18", ReaderNumber = 19},
                    new SetupReaderState {ReaderName = "ACS 39U 19", ReaderNumber = 20},
                    new SetupReaderState {ReaderName = "ACS 39U 20", ReaderNumber = 21},
                    new SetupReaderState {ReaderName = "ACS 39U 21", ReaderNumber = 22},
                    new SetupReaderState {ReaderName = "ACS 39U 22", ReaderNumber = 23},
                    new SetupReaderState {ReaderName = "ACS 39U 23", ReaderNumber = 24},
                    new SetupReaderState {ReaderName = "ACS 39U 24", ReaderNumber = 25},
                    new SetupReaderState {ReaderName = "ACS 39U 25", ReaderNumber = 26},
                    new SetupReaderState {ReaderName = "ACS 39U 26", ReaderNumber = 27},
                    new SetupReaderState {ReaderName = "ACS 39U 27", ReaderNumber = 28},
                    new SetupReaderState {ReaderName = "ACS 39U 28", ReaderNumber = 29},
                    new SetupReaderState {ReaderName = "ACS 39U 29", ReaderNumber = 30}
                }
            }
        };

        public static ServiceState Instance => _instance;
    }
}
