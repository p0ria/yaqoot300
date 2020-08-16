using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Yaqoot300.Commons;
using Yaqoot300.Interfaces;
using Yaqoot300.Models.Signal;
using Yaqoot300.Properties;
using Yaqoot300.State;
using Yaqoot300.State.App.Actions;
using Yaqoot300.State.Job.Actions;
using Yaqoot300.State.PLC.Actions;

namespace Yaqoot300.Modals
{
    public partial class CheckingsDialog : Form
    {
        private readonly Timer _timer;
        private int ticks;
        private const int FIRST_CHECK = 2;
        private const int TIMEOUT = 4;
        private bool _isStartSent = false;
        public CheckingsDialog()
        {
            InitializeComponent();
            Store.StoreChanged += OnStoreChanged;
            _timer = new Timer();
            _timer.Interval = 1000;
            _timer.Tick += TimerOnTick;
            _timer.Start();
            OnStoreChanged(this, null);
            this.Focus();
        }

        private void TimerOnTick(object sender, EventArgs eventArgs)
        {
            ticks++;
            if(ticks < FIRST_CHECK) return;
  
            var first = FirstCheck();
            if (first.HasValue)
            {
                if (first.Value)
                {
                    SendStartSignalIfNotSent();
                    var second = SecondCheck();
                    if (second.HasValue)
                    {
                        CloseDialog(second.Value ? DialogResult.OK : DialogResult.No);
                    }
                    else
                    {
                        if (ticks >= TIMEOUT * 2)
                        {
                            CloseDialog(DialogResult.Cancel);
                        }
                    }
                }
                else if(ticks >= TIMEOUT)
                {
                    CloseDialog(DialogResult.No);
                }
                
            }
            else
            {
                if (ticks >= TIMEOUT)
                {
                    CloseDialog(DialogResult.Cancel);
                }
            }
        }

        private void SendStartSignalIfNotSent()
        {
            if (!_isStartSent)
            {
                _isStartSent = true;
                if (!Store.Plc.IsStartReady.HasValue)
                {
                    Services.Signals.Send(GuiSignals.Start);
                } 
            }
        }

        private void OnStoreChanged(object sender, string changeType)
        {
            switch (changeType)
            {
                case null:
                    SetConnections();
                    SetSelectedJob();
                    SetPlcReady();
                    break;
                case AppActionTypes.CONENCTIONS_CHANGED:
                    SetConnections();
                    break;
                case JobActionTypes.SELECT_JOB:
                    SetSelectedJob();
                    break;
                case PlcActionTypes.START_READY_CHANGED:
                    SetPlcReady();
                    break;
            }
        }

        private void SetConnections()
        {
            SetImage(pbPlcConnected, Store.App.Connections.PLCConnection);
            SetImage(pbDatabase, Store.App.Connections.DbConnection);
            SetImage(pbClient1, Store.App.Connections.ThinClient1Connection);
            SetImage(pbClient2, Store.App.Connections.ThinClient2Connection);
            SetImage(pbClient3, Store.App.Connections.ThinClient3Connection);
        }

        private void SetSelectedJob()
        {
            if(Store.Job.SelectedJobId.HasValue)
                this.SafeInvoke(() => pbSelectedJob.Image = Resources.tick_24x24);
            else 
                this.SafeInvoke(() => pbSelectedJob.Image = Resources.cross_24x24);
        }

        private void SetPlcReady()
        {
            switch (Store.Plc.IsStartReady)
            {
                case null:
                    this.SafeInvoke(() => pbPlcReady.Image = Resources.loading_24x24);
                    break;
                case true:
                    this.SafeInvoke(() => pbPlcReady.Image = Resources.tick_24x24);
                    break;
                case false:
                    this.SafeInvoke(() => pbPlcReady.Image = Resources.cross_24x24);
                    break;
            }
        }

        private void SetImage(PictureBox pb, ConnectionStatus status)
        {
            switch (status)
            {
                case ConnectionStatus.Connected:
                    this.SafeInvoke(() => pb.Image = Resources.tick_24x24);
                    break;
                case ConnectionStatus.Disconnected:
                    this.SafeInvoke(() => pb.Image = Resources.cross_24x24);
                    break;
                case ConnectionStatus.Connecting:
                    this.SafeInvoke(() => pb.Image = Resources.loading_24x24);
                    break;
            }
        }

        private bool? FirstCheck()
        {
            if (Store.App.Connections.PLCConnection == ConnectionStatus.Disconnected) return false;
            if (Store.App.Connections.DbConnection == ConnectionStatus.Disconnected) return false;
            if (Store.App.Connections.ThinClient1Connection == ConnectionStatus.Disconnected) return false;
            if (Store.App.Connections.ThinClient2Connection == ConnectionStatus.Disconnected) return false;
            if (Store.App.Connections.ThinClient3Connection == ConnectionStatus.Disconnected) return false;
            if (!Store.Job.SelectedJobId.HasValue) return false;
            

            if (Store.App.Connections.PLCConnection == ConnectionStatus.Connecting) return null;
            if (Store.App.Connections.DbConnection == ConnectionStatus.Connecting) return null;
            if (Store.App.Connections.ThinClient1Connection == ConnectionStatus.Connecting) return null;
            if (Store.App.Connections.ThinClient2Connection == ConnectionStatus.Connecting) return null;
            if (Store.App.Connections.ThinClient3Connection == ConnectionStatus.Connecting) return null;

            return true;
        }

        private bool? SecondCheck()
        {
            if (Store.Plc.IsStartReady.HasValue && Store.Plc.IsStartReady.Value == false) return false;
            if (Store.Plc.IsStartReady.HasValue == false) return null;
            return true;
        }

        private void CloseDialog(DialogResult result)
        {
            this.DialogResult = result;
            this.Close();
        }

        protected override void OnClosed(EventArgs e)
        {
            _timer.Stop();
            _timer.Dispose();
            Store.StoreChanged -= OnStoreChanged;
            base.OnClosed(e);
        }

        private Store Store => Services.Store;
    }
}
