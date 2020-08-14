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
        private const int MIN_SHOW_SECONDS = 4;
        private const int MAX_SHOW_SECONDS = 10;
        public CheckingsDialog()
        {
            InitializeComponent();
            Store.StoreChanged += OnStoreChanged;
            _timer = new Timer();
            _timer.Interval = 1000;
            _timer.Tick += TimerOnTick;
            _timer.Start();
            OnStoreChanged(this, null);
        }

        private void TimerOnTick(object sender, EventArgs eventArgs)
        {
            ticks++;
            if(ticks < MIN_SHOW_SECONDS) return;
  
            var close = CheckClose();
            if (close.HasValue)
            {
                this.DialogResult = close.Value ? DialogResult.OK : DialogResult.No;
                this.Close();
            }
            else
            {
                if (ticks >= MAX_SHOW_SECONDS)
                {
                    this.DialogResult = DialogResult.Cancel;
                    this.Close();
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

        private bool? CheckClose()
        {
            if(Store.App.Connections.PLCConnection == ConnectionStatus.Connecting) return null;
            if (Store.App.Connections.DbConnection == ConnectionStatus.Connecting) return null;
            if (Store.App.Connections.ThinClient1Connection == ConnectionStatus.Connecting) return null;
            if (Store.App.Connections.ThinClient2Connection == ConnectionStatus.Connecting) return null;
            if (Store.App.Connections.ThinClient3Connection == ConnectionStatus.Connecting) return null;
            if (Store.Plc.IsStartReady.HasValue == false) return null;

            if (Store.App.Connections.PLCConnection == ConnectionStatus.Disconnected) return false;
            if (Store.App.Connections.DbConnection == ConnectionStatus.Disconnected) return false;
            if (Store.App.Connections.ThinClient1Connection == ConnectionStatus.Disconnected) return false;
            if (Store.App.Connections.ThinClient2Connection == ConnectionStatus.Disconnected) return false;
            if (Store.App.Connections.ThinClient3Connection == ConnectionStatus.Disconnected) return false;
            if (Store.Plc.IsStartReady.Value == false) return false;

            return true;
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
