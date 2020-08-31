using System.Collections.Generic;
using System.Windows.Forms;
using Yaqoot300.Commons;
using Yaqoot300.Interfaces;
using Yaqoot300.Models.ThinClient;
using Yaqoot300.State.App.Actions;
using Yaqoot300.State.Home;
using Yaqoot300.State.Home.Actions;
using Yaqoot300.State.PLC.Actions;
using Yaqoot300.State.Service.Actions;

namespace Yaqoot300.Models.Signal
{
    public class PlcSignals
    {
        [Signal(0x01, 0x01)]
        public byte[] Start
        {
            set
            {
                Services.Store.Dispatch(new PlcStartReadyChangedAction(true));
                Services.Store.Dispatch(new HomeChangeAutoStartAction(
                    new HomeChangeAutoStartActionPayload(AutoStartBtnStatus.Starting)));
            }
        }

        [Signal(0x01, 0x02)]
        public byte[] Started
        {
            set
            {
                Services.Store.Dispatch(new PlcStartReadyChangedAction(true));
            }
        }

        [Signal(0x02, 0x00)]
        public byte[] Stop
        {
            set {
                Services.Store.Dispatch(new HomeChangeAutoStartAction(
                    new HomeChangeAutoStartActionPayload(AutoStartBtnStatus.Stoped)));
            }
        }

        [Signal(0x03)]
        public byte[] Mode
        {
            set
            {
                switch (value[1])
                {
                    case 0x01:
                        Services.Store.Dispatch(new AppChangeModeAction(Interfaces.Mode.Auto));
                        break;
                    case 0x02:
                        Services.Store.Dispatch(new AppChangeModeAction(Interfaces.Mode.Manual));
                        break;
                    case 0x03:
                        Services.Store.Dispatch(new AppChangeModeAction(Interfaces.Mode.Service));
                        break;
                }
                
            }
        }

        [Signal(0x04)]
        public byte[] SensorsState1_8
        {
            set
            {
                var sensors = new List<bool>();
                for (int i = 0; i < 8; i++)
                {
                    bool set = (value[1] & 1 << i) != 0;
                    sensors.Add(set);
                }
                Services.Store.Dispatch(new ServiceSensorsChangedAction(
                    new ServiceSensorsChangedActionPayload(sensors, 0, 7)));
            }
        }

        [Signal(0x05)]
        public byte[] SensorsState9_16
        {
            set
            {
                var sensors = new List<bool>();
                for (int i = 0; i < 8; i++)
                {
                    bool set = (value[1] & 1 << i) != 0;
                    sensors.Add(set);
                }
                Services.Store.Dispatch(new ServiceSensorsChangedAction(
                    new ServiceSensorsChangedActionPayload(sensors, 8, 15)));
            }
        }

        [Signal(0x06)]
        public byte[] ManualAck
        {
            set
            {
                switch (value[1])
                {
                    case 0x01:
                        Services.Store.Dispatch(new HomeChangeManualBtnAction(ManualBtnStatus.Idle));
                        break;
                }
            }
        }

        [Signal(0x07)]
        public byte[] StepCycle
        {
            set
            {
                switch (value[1])
                {
                    case 0x01:
                        // M3 Step
                        break;
                    case 0x02:
                        switch (Services.Store.App.SelectedMode)
                        {
                            case Interfaces.Mode.Auto:
                            case Interfaces.Mode.Manual:
                                Services.Store.Dispatch(new HomeLoadOS());
                                break;
                            case Interfaces.Mode.Service:
                                // test readers
                                break;
                        }                      
                        break;
                    case 0x03:
                        // M4 UP
                        break;
                }
            }
        }


        [Signal(0xFF)]
        public byte[] Errors
        {
            set
            {
                switch (value[1])
                {
                    case 0x02:
                        Services.Store.Dispatch(new HomeAddPlcErrorAction(PlcErrors.Emergency));
                        break;
                    case 0x03:
                        Services.Store.Dispatch(new HomeRemovePlcErrorAction(PlcErrors.Emergency.Id));
                        break;
                    case 0x04:
                        Services.Store.Dispatch(new HomeAddPlcErrorAction(PlcErrors.DoorsOpen));
                        break;
                    case 0x05:
                        Services.Store.Dispatch(new HomeRemovePlcErrorAction(PlcErrors.DoorsOpen.Id));
                        break;
                    case 0x06:
                        Services.Store.Dispatch(new HomeAddPlcErrorAction(PlcErrors.PowerFail));
                        break;
                    case 0x07:
                        Services.Store.Dispatch(new HomeRemovePlcErrorAction(PlcErrors.PowerFail.Id));
                        break;
                    case 0x08:
                        Services.Store.Dispatch(new HomeAddPlcErrorAction(PlcErrors.HomePosition));
                        break;
                    case 0x09:
                        Services.Store.Dispatch(new HomeRemovePlcErrorAction(PlcErrors.HomePosition.Id));
                        break;
                    case 0x0A:
                        Services.Store.Dispatch(new HomeAddPlcErrorAction(PlcErrors.DoorsOpen));
                        break;
                    case 0x0B:
                        Services.Store.Dispatch(new HomeRemovePlcErrorAction(PlcErrors.DoorsOpen.Id));
                        break;
                    case 0x0C:
                        Services.Store.Dispatch(new HomeAddPlcErrorAction(PlcErrors.InputSpacerEmpty));
                        break;
                    case 0x0D:
                        Services.Store.Dispatch(new HomeRemovePlcErrorAction(PlcErrors.InputSpacerEmpty.Id));
                        break;
                    case 0x0E:
                        Services.Store.Dispatch(new HomeAddPlcErrorAction(PlcErrors.OutputBufferFull));
                        break;
                    case 0x0F:
                        Services.Store.Dispatch(new HomeRemovePlcErrorAction(PlcErrors.OutputBufferFull.Id));
                        break;
                    case 0x10:
                        Services.Store.Dispatch(new HomeAddPlcErrorAction(PlcErrors.OutputSpacerEmpty));
                        break;
                    case 0x11:
                        Services.Store.Dispatch(new HomeRemovePlcErrorAction(PlcErrors.OutputSpacerEmpty.Id));
                        break;
                    case 0x12:
                        Services.Store.Dispatch(new HomeAddPlcErrorAction(PlcErrors.InputReelSensorEmpty));
                        break;
                    case 0x13:
                        Services.Store.Dispatch(new HomeRemovePlcErrorAction(PlcErrors.InputReelSensorEmpty.Id));
                        break;
                    case 0x14:
                        Services.Store.Dispatch(new HomeAddPlcErrorAction(PlcErrors.OutputReelSensorEmpty));
                        break;
                    case 0x15:
                        Services.Store.Dispatch(new HomeRemovePlcErrorAction(PlcErrors.OutputReelSensorEmpty.Id));
                        break;
                    case 0x16:
                        Services.Store.Dispatch(new HomeAddPlcErrorAction(PlcErrors.ChipPositionSensor));
                        break;
                    case 0x17:
                        Services.Store.Dispatch(new HomeRemovePlcErrorAction(PlcErrors.ChipPositionSensor.Id));
                        break;
                    case 0x18:
                        Services.Store.Dispatch(new HomeAddPlcErrorAction(PlcErrors.ReaderOperationSensor));
                        break;
                    case 0x19:
                        Services.Store.Dispatch(new HomeRemovePlcErrorAction(PlcErrors.ReaderOperationSensor.Id));
                        break;
                    default:
                        return;
                }
                Services.Store.Dispatch(new HomeChangeAutoStartAction(
                    new HomeChangeAutoStartActionPayload(AutoStartBtnStatus.Stoped)));
                Services.Store.Dispatch(new HomeChangeManualBtnAction(ManualBtnStatus.Idle));
            }
        }

    }
}