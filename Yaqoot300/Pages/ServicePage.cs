using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Yaqoot300.Commons;
using Yaqoot300.Controls;
using Yaqoot300.Interfaces;
using Yaqoot300.State;
using Yaqoot300.State.Service;
using Yaqoot300.State.Service.Actions;

namespace Yaqoot300.Pages
{
    public partial class ServicePage : UserControl
    {
        private Timer _m3Timer;
        private Timer _m4Timer;
        private SensorControl[] _sensors;
        private TestReaderControl[] _testReaders;
        private SetupReaderControl[] _setupReaders;
        public ServicePage()
        {
            InitializeComponent();
            Store.StoreChanged += OnStoreChanged;
            this.InitMotors();
            this.InitSensorControls();
            this.InitSettings();
            this.InitTestReaders();
            this.InitSetupReaders();
            tabService.SelectTab(1);
        }

        private void InitMotors()
        {
            this.mt0.MouseDown += OnMotorMouseDown;
            this.mt1.MouseDown += OnMotorMouseDown;
            this.mt2.MouseDown += OnMotorMouseDown;
            this.mt3.MouseDown += OnMotorMouseDown;
            this.mt0.MouseUp += OnMotorMouseUp;
            this.mt1.MouseUp += OnMotorMouseUp;
            this.mt2.MouseUp += OnMotorMouseUp;
            this.mt4.BtnClicked += Mt4OnBtnClicked;
            _m3Timer = new Timer();
            _m3Timer.Interval = 2000;
            _m3Timer.Tick += M3TimerOnTick;
            _m4Timer = new Timer();
            _m4Timer.Interval = 2000;
            _m4Timer.Tick += M4TimerOnTick;
        }

        private void InitSensorControls()
        {
            this._sensors = new SensorControl[Constants.SENSORS_LENGTH];
            _sensors[0] = sensor1;
            _sensors[1] = sensor2;
            _sensors[2] = sensor3;
            _sensors[3] = sensor4;
            _sensors[4] = sensor5;
            _sensors[5] = sensor6;
            _sensors[6] = sensor7;
            _sensors[7] = sensor8;
            _sensors[8] = sensor9;
            _sensors[9] = sensor10;
            _sensors[10] = sensor11;
            _sensors[11] = sensor12;
            _sensors[12] = sensor13;
            _sensors[13] = sensor14;
        }

        private void InitSettings()
        {
            this.scActiveReaders.ValueChanged += settingsSliderOnValueChanged;
            this.scFeedInSteps.ValueChanged += settingsSliderOnValueChanged;
            this.scM3StepLength.ValueChanged += settingsSliderOnValueChanged;
            this.scM4Speed.ValueChanged += settingsSliderOnValueChanged;
            this.btnSave.BtnClicked += OnBtnSaveClicked;
        }

        private void InitTestReaders()
        {
            this._testReaders = new TestReaderControl[Constants.READERS_COUNT];
            _testReaders[0] = tr1;
            _testReaders[1] = tr2;
            _testReaders[2] = tr3;
            _testReaders[3] = tr4;
            _testReaders[4] = tr5;
            _testReaders[5] = tr6;
            _testReaders[6] = tr7;
            _testReaders[7] = tr8;
            _testReaders[8] = tr9;
            _testReaders[9] = tr10;
            _testReaders[10] = tr11;
            _testReaders[11] = tr12;
            _testReaders[12] = tr13;
            _testReaders[13] = tr14;
            _testReaders[14] = tr15;
            _testReaders[15] = tr16;
            _testReaders[16] = tr17;
            _testReaders[17] = tr18;
            _testReaders[18] = tr19;
            _testReaders[19] = tr20;
            _testReaders[20] = tr21;
            _testReaders[21] = tr22;
            _testReaders[22] = tr23;
            _testReaders[23] = tr24;
            _testReaders[24] = tr25;
            _testReaders[25] = tr26;
            _testReaders[26] = tr27;
            _testReaders[27] = tr28;
            _testReaders[28] = tr29;
            _testReaders[29] = tr30;
            this.btnTestReaders.BtnClicked += OnBtnTestReadersClicked; 
        }

        private void InitSetupReaders()
        {
            this._setupReaders = new SetupReaderControl[Constants.READERS_COUNT];
            _setupReaders[0] = sr1;
            _setupReaders[1] = sr2;
            _setupReaders[2] = sr3;
            _setupReaders[3] = sr4;
            _setupReaders[4] = sr5;
            _setupReaders[5] = sr6;
            _setupReaders[6] = sr7;
            _setupReaders[7] = sr8;
            _setupReaders[8] = sr9;
            _setupReaders[9] = sr10;
            _setupReaders[10] = sr11;
            _setupReaders[11] = sr12;
            _setupReaders[12] = sr13;
            _setupReaders[13] = sr14;
            _setupReaders[14] = sr15;
            _setupReaders[15] = sr16;
            _setupReaders[16] = sr17;
            _setupReaders[17] = sr18;
            _setupReaders[18] = sr19;
            _setupReaders[19] = sr20;
            _setupReaders[20] = sr21;
            _setupReaders[21] = sr22;
            _setupReaders[22] = sr23;
            _setupReaders[23] = sr24;
            _setupReaders[24] = sr25;
            _setupReaders[25] = sr26;
            _setupReaders[26] = sr27;
            _setupReaders[27] = sr28;
            _setupReaders[28] = sr29;
            _setupReaders[29] = sr30;
            foreach (var sr in this._setupReaders)
            {
                sr.Assigned += (s, e) => AssignReader(lbReaders.SelectedItem.ToString(), sr.Number);
            }
            this.lbReaders.SelectedIndexChanged += lbReadersOnSelectedIndexChanged;
        }

        private void AssignReader(string readerName, int readerNumber)
        {
            this.lbReaders.ClearSelected();
            this.Store.Dispatch(new ServiceAssignReaderAction(new ServiceAssignReaderActionPayload(readerName, readerNumber)));
        }

        private void lbReadersOnSelectedIndexChanged(object sender, EventArgs eventArgs)
        {
            foreach (var sr in this._setupReaders)
            {
                sr.IsActive = this.lbReaders.SelectedIndex > -1;
            }
        }

        private void OnBtnTestReadersClicked(object sender, EventArgs eventArgs)
        {
            ChangeBtnTestReadersStatus(LoadingButtonControl.LoadingButtonControlStatus.Loading);
            Store.Dispatch(new ServiceTestReadersAction());
        }

        private void OnBtnSaveClicked(object sender, EventArgs eventArgs)
        {
            ChangeSlidersEnable(false);
            ChangeBtnSaveStatus(LoadingButtonControl.LoadingButtonControlStatus.Loading);
            Store.Dispatch(new ServiceChangeSettingsAction(new ServiceSettingsState
            {
                ActiveReaders = scActiveReaders.Value,
                FeedInSteps = scFeedInSteps.Value,
                M3StepLength = scM3StepLength.Value,
                M4Speed = scM4Speed.Value
            }));
        }

        private void ChangeSlidersEnable(bool enable)
        {
            this.scActiveReaders.Enabled = enable;
            this.scFeedInSteps.Enabled = enable;
            this.scM3StepLength.Enabled = enable;
            this.scM4Speed.Enabled = enable;
        }

        private void ChangeBtnSaveStatus(LoadingButtonControl.LoadingButtonControlStatus status)
        {
            this.btnSave.Status = status;
        }

        private void ChangeBtnTestReadersStatus(LoadingButtonControl.LoadingButtonControlStatus status)
        {
            this.btnTestReaders.Status = status;
        }

        private void settingsSliderOnValueChanged(object sender, int i1)
        {
            bool dirty = false;
            if (this.scActiveReaders.Value != Store.Service.Settings.ActiveReaders) dirty = true;
            if (!dirty && this.scFeedInSteps.Value != Store.Service.Settings.FeedInSteps) dirty = true;
            if (!dirty && this.scM3StepLength.Value != Store.Service.Settings.M3StepLength) dirty = true;
            if (!dirty && this.scM4Speed.Value != Store.Service.Settings.M4Speed) dirty = true;
            this.btnSave.Status =
                dirty
                    ? LoadingButtonControl.LoadingButtonControlStatus.Visible
                    : LoadingButtonControl.LoadingButtonControlStatus.Invisible;
        }

        private void OnStoreChanged(object sender, string changeType)
        {
            switch (changeType)
            {
                case null:
                    SetM0();
                    SetM1();
                    SetM2();
                    SetM3();
                    SetM4();
                    SetSensors();
                    SetSettings();
                    SetTestReaders();
                    SetSetupReaders();
                    break;
                case ServiceActionTypes.CHANGE_M0:
                    SetM0();
                    break;
                case ServiceActionTypes.CHANGE_M1:
                    SetM1();
                    break;
                case ServiceActionTypes.CHANGE_M2:
                    SetM2();
                    break;
                case ServiceActionTypes.CHANGE_M3:
                    SetM3();
                    break;
                case ServiceActionTypes.CHANGE_M4:
                    SetM4();
                    break;
                case ServiceActionTypes.CHANGE_SETTINGS_SUCCESS:
                case ServiceActionTypes.CHANGE_SETTINGS_FAIL:
                    SetSettings();
                    ChangeSlidersEnable(true);
                    ChangeBtnSaveStatus(LoadingButtonControl.LoadingButtonControlStatus.Invisible);
                    break;
                case ServiceActionTypes.TEST_READERS:
                    SetTestReaders();
                    break;
                case ServiceActionTypes.TEST_READERS_SUCCESS:
                case ServiceActionTypes.TEST_READERS_FAIL:
                    SetTestReaders();
                    ChangeBtnTestReadersStatus(LoadingButtonControl.LoadingButtonControlStatus.Visible);
                    break;
                case ServiceActionTypes.ASSIGN_READER:
                    SetSetupReaders();
                    break;
            }
        }


        private Store Store => ServiceProvider.Store;

        private void OnMotorMouseDown(object sender, MouseEventArgs mouseEventArgs)
        {
            if (sender == mt0)
            {
                if (!Store.Service.Motors.M0.IsEnabled || Store.Service.Motors.M0.Status == RotateMotorStatus.Started) return;
                Store.Dispatch(new ServiceChangeM0Action(new ServiceChangeMotorActionPayload(RotateMotorStatus.Started)));
            }
            else if (sender == mt1)
            {
                if (!Store.Service.Motors.M1.IsEnabled || Store.Service.Motors.M1.Status == RotateMotorStatus.Started) return;
                Store.Dispatch(new ServiceChangeM1Action(new ServiceChangeMotorActionPayload(RotateMotorStatus.Started)));
            }
            else if (sender == mt2)
            {
                if (!Store.Service.Motors.M2.IsEnabled || Store.Service.Motors.M2.Status == RotateMotorStatus.Started) return;
                Store.Dispatch(new ServiceChangeM2Action(new ServiceChangeMotorActionPayload(RotateMotorStatus.Started)));
            }
            else if (sender == mt3)
            {
                if (!Store.Service.Motors.M3.IsEnabled || Store.Service.Motors.M3.Status == RotateMotorStatus.Started) return;
                Store.Dispatch(new ServiceChangeM3Action(new ServiceChangeMotorActionPayload(RotateMotorStatus.Started, false)));
                _m3Timer.Start();
            }
        }

        private void OnMotorMouseUp(object sender, MouseEventArgs mouseEventArgs)
        {
            if (sender == mt0)
            {
                Store.Dispatch(new ServiceChangeM0Action(new ServiceChangeMotorActionPayload(RotateMotorStatus.Stopped)));
            }    
            else if (sender == mt1)
            {
                Store.Dispatch(new ServiceChangeM1Action(new ServiceChangeMotorActionPayload(RotateMotorStatus.Stopped)));
            }       
            else if (sender == mt2)
            {
                Store.Dispatch(new ServiceChangeM2Action(new ServiceChangeMotorActionPayload(RotateMotorStatus.Stopped)));
            }
        }

        private void Mt4OnBtnClicked(object sender, UpDownMotorControl.BtnClickedType arg)
        {
            if (Store.Service.Motors.M4.Status != UpDownMotorStatus.Idle) return;
            switch (arg)
            {
                case UpDownMotorControl.BtnClickedType.Up:
                    Store.Dispatch(new ServiceChangeM4Action(new ServiceChangeM4ActionPayload(UpDownMotorStatus.GoingUp, false, false)));
                    break;
                case UpDownMotorControl.BtnClickedType.Down:
                    Store.Dispatch(new ServiceChangeM4Action(new ServiceChangeM4ActionPayload(UpDownMotorStatus.GoingDown, false, false)));
                    break;
            }
            _m4Timer.Start();
        }

        private void SetM0()
        {
            mt0.IsEnabled = Store.Service.Motors.M0.Status == RotateMotorStatus.Started;
            mt0.Cursor = Store.Service.Motors.M0.IsEnabled ? Cursors.Hand : Cursors.No;
        }

        private void SetM1()
        {
            mt1.IsEnabled = Store.Service.Motors.M1.Status == RotateMotorStatus.Started;
            mt1.Cursor = Store.Service.Motors.M1.IsEnabled ? Cursors.Hand : Cursors.No;
        }

        private void SetM2()
        {
            mt2.IsEnabled = Store.Service.Motors.M2.Status == RotateMotorStatus.Started;
            mt2.Cursor = Store.Service.Motors.M2.IsEnabled ? Cursors.Hand : Cursors.No;
        }

        private void SetM3()
        {
            mt3.IsEnabled = Store.Service.Motors.M3.Status == RotateMotorStatus.Started;
            mt3.Cursor = Store.Service.Motors.M3.IsEnabled ? Cursors.Hand : Cursors.No;
        }

        private void SetM4()
        {
            mt4.Status = Store.Service.Motors.M4.Status;
            mt4.IsUpEnabled = Store.Service.Motors.M4.IsUpEnabled;
            mt4.IsDownEnabled = Store.Service.Motors.M4.IsDownEnabled;
        }

        private void SetSensors(params int[] sensorIndices)
        {
            if (sensorIndices == null || sensorIndices.Length == 0)
            {
                for (int i = 0; i < Constants.SENSORS_LENGTH; i++)
                {
                    this._sensors[i].IsOn = Store.Service.Sensors[i];
                }
            }
            else
            {
                foreach (int sensorIndex in sensorIndices)
                {
                    this._sensors[sensorIndex].IsOn = Store.Service.Sensors[sensorIndex];
                }
            }
        }

        private void SetSettings()
        {
            this.scActiveReaders.Value = Store.Service.Settings.ActiveReaders;
            this.scFeedInSteps.Value = Store.Service.Settings.FeedInSteps;
            this.scM3StepLength.Value = Store.Service.Settings.M3StepLength;
            this.scM4Speed.Value = Store.Service.Settings.M4Speed;
        }

        private void SetSetupReaders()
        {
            var unassginedReaders = Store.Service.SetupReaders.Readers.Where(r => !r.ReaderNumber.HasValue);
            var assignedReaders = Store.Service.SetupReaders.Readers.Where(r => r.ReaderNumber.HasValue);

            this.lbReaders.Items.Clear();
            this.lbReaders.Items.AddRange(unassginedReaders.Select(r => r.ReaderName).ToArray());
            foreach (var sr in assignedReaders)
            {
                _setupReaders[sr.ReaderNumber.Value - 1].ReaderName = sr.ReaderName;
            }
            
        }

        private void SetTestReaders()
        {
            for (int i = 0; i < Constants.READERS_COUNT; i++)
            {
                _testReaders[i].Status = Store.Service.TestReaders.Readers[i];
            }
        }

        private void M3TimerOnTick(object sender, EventArgs eventArgs)
        {
            _m3Timer.Stop();
            Store.Dispatch(new ServiceChangeM3Action(new ServiceChangeMotorActionPayload(RotateMotorStatus.Stopped, true)));
        }

        private void M4TimerOnTick(object sender, EventArgs eventArgs)
        {
            _m4Timer.Stop();
            Store.Dispatch(new ServiceChangeM4Action(new ServiceChangeM4ActionPayload(UpDownMotorStatus.Idle, true, true)));
        }
    }
}
