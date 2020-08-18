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
using Yaqoot300.Interfaces;
using Yaqoot300.State;
using Yaqoot300.State.Service.Actions;

namespace Yaqoot300.Controls
{
    public partial class ServiceMotorsControl : UserControl
    {
        private Timer _m3Timer;
        private Timer _m4Timer;
        public ServiceMotorsControl()
        {
            InitializeComponent();
            this.InitMotors();
            Store.StoreChanged += OnStoreChanged;
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
            }
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

        private void SetM0()
        {
            this.SafeInvoke(() =>
            {
                mt0.IsEnabled = Store.Service.Motors.M0.Status == RotateMotorStatus.Started;
                mt0.Cursor = Store.Service.Motors.M0.IsEnabled ? Cursors.Hand : Cursors.No;
            });
        }

        private void SetM1()
        {
            this.SafeInvoke(() =>
            {
                mt1.IsEnabled = Store.Service.Motors.M1.Status == RotateMotorStatus.Started;
                mt1.Cursor = Store.Service.Motors.M1.IsEnabled ? Cursors.Hand : Cursors.No;
            });
        }

        private void SetM2()
        {
            this.SafeInvoke(() =>
            {
                mt2.IsEnabled = Store.Service.Motors.M2.Status == RotateMotorStatus.Started;
                mt2.Cursor = Store.Service.Motors.M2.IsEnabled ? Cursors.Hand : Cursors.No;
            });
        }

        private void SetM3()
        {
            this.SafeInvoke(() =>
            {
                mt3.IsEnabled = Store.Service.Motors.M3.Status == RotateMotorStatus.Started;
                mt3.Cursor = Store.Service.Motors.M3.IsEnabled ? Cursors.Hand : Cursors.No;
            });
        }

        private void SetM4()
        {
            this.SafeInvoke(() =>
            {
                mt4.Status = Store.Service.Motors.M4.Status;
                mt4.IsUpEnabled = Store.Service.Motors.M4.IsUpEnabled;
                mt4.IsDownEnabled = Store.Service.Motors.M4.IsDownEnabled;
            });
        }

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

        private Store Store => Services.Store;
    }
}
