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
using Yaqoot300.Modals;
using Yaqoot300.Properties;
using Yaqoot300.State;
using Yaqoot300.State.App.Actions;
using Yaqoot300.State.Home.Actions;
using Yaqoot300.State.Job.Actions;
using Yaqoot300.State.Service;

namespace Yaqoot300.Pages
{
    public partial class HomePage : UserControl
    {
        private readonly UserControl _autoActions;
        private readonly UserControl _manualActions;
        private Mode? _currentMode;
        private ReaderController[] _readers;
        public HomePage()
        {
            InitializeComponent();
            _autoActions = new AutoActions();
            _manualActions = new ManualActions();
            InitiReaders();
            this.lampCtrlRed.Type = LampControl.LampControlType.Red;
            this.lampCtrlGreen.Type = LampControl.LampControlType.Green;
            this.lampCtrlYellow.Type = LampControl.LampControlType.Yellow;
            this.lampCtrlRed.Status = LampControl.LampControlStatus.On;
            this.lampCtrlGreen.Status = LampControl.LampControlStatus.On;
            this.lampCtrlYellow.Status = LampControl.LampControlStatus.On;

            Store.StoreChanged += OnStoreChanged;
        }

        private void InitiReaders()
        {
            this._readers = new ReaderController[Constants.READERS_COUNT];
            _readers[0] = reader1;
            _readers[1] = reader2;
            _readers[2] = reader3;
            _readers[3] = reader4;
            _readers[4] = reader5;
            _readers[5] = reader6;
            _readers[6] = reader7;
            _readers[7] = reader8;
            _readers[8] = reader9;
            _readers[9] = reader10;
            _readers[10] = reader11;
            _readers[11] = reader12;
            _readers[12] = reader13;
            _readers[13] = reader14;
            _readers[14] = reader15;
            _readers[15] = reader16;
            _readers[16] = reader17;
            _readers[17] = reader18;
            _readers[18] = reader19;
            _readers[19] = reader20;
            _readers[20] = reader21;
            _readers[21] = reader22;
            _readers[22] = reader23;
            _readers[23] = reader24;
            _readers[24] = reader25;
            _readers[25] = reader26;
            _readers[26] = reader27;
            _readers[27] = reader28;
            _readers[28] = reader29;
            _readers[29] = reader30;
        }

        private void OnStoreChanged(object sender, string changeType)
        {
            switch (changeType)
            {
                case null:
                    SetHeader();
                    SetReaders();
                    SetSelectedJob();
                    
                    SetActions();
                    break;

                case AppActionTypes.CHANGE_MODE:
                    SetHeader();
                    SetActions();
                    break;

                case JobActionTypes.SELECT_JOB:
                    SetSelectedJob();
                    break;

                case HomeActionTypes.LOAD_OS:
                case HomeActionTypes.LOAD_OS_SUCCESS:
                case HomeActionTypes.LOAD_OS_FAIL:
                    SetReaders();
                    break;
            }
        }

        private Store Store => Services.Store;

        private void SetReaders()
        {
            this.SafeInvoke(() =>
            {
                foreach (var reader in _readers)
                {
                    var hr = Store.Home.HomeReaders[reader.Number];
                    if (hr != null)
                    {
                        reader.Status = hr.Status;
                        reader.Percent = hr.ErrorPercent;
                    }
                }
            });
        }

        private void SetHeader()
        {
            switch (Store.App.SelectedMode)
            {
                case Mode.Auto:
                    this.SafeInvoke(() => this.lblMode.Text = "AUTO");
                    break;
                case Mode.Manual:
                    this.SafeInvoke(() => this.lblMode.Text = "MANUAL");
                    break;
            }
        }

        private void SetSelectedJob()
        {
            this.SafeInvoke(() =>
            {
                var selectedJob = Store.Job.SelectedJob;
                lblJobValue.Text = selectedJob?.LotNumber;
                lblChipsTotalValue.Text = selectedJob?.Total.ToString();
                lblChipsGoodValue.Text = selectedJob?.Good.ToString();
            });
        }

        private void SetActions()
        {
            if(_currentMode == Store.App.SelectedMode) return;
            switch (Store.App.SelectedMode)
            {
                case Mode.Auto:
                    this.SafeInvoke(() =>
                    {
                        this.panelActions.Controls.Clear();
                        this.panelActions.Controls.Add(_autoActions);
                    });
                    break;

                case Mode.Manual:
                    this.SafeInvoke(() =>
                    {
                        this.panelActions.Controls.Clear();
                        this.panelActions.Controls.Add(_manualActions);
                    });
                    break;
            }
            _currentMode = Store.App.SelectedMode;
        }

        private void btnSelectJob_Click(object sender, EventArgs e)
        {
            using (var dlg = new JobsDialog())
            {
                dlg.ShowDialog();
                Store.Dispatch(new JobSelectJobAction(dlg.SelectedJobId));
            }
        }

        private void btnMessages_Click(object sender, EventArgs e)
        {
            Services.Messages.ShowDialog();
        }
    }
}
