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
        public HomePage()
        {
            InitializeComponent();
            _autoActions = new AutoActions();
            _manualActions = new ManualActions();
            
            this.lampCtrlRed.Type = LampControl.LampControlType.Red;
            this.lampCtrlGreen.Type = LampControl.LampControlType.Green;
            this.lampCtrlYellow.Type = LampControl.LampControlType.Yellow;
            this.lampCtrlRed.Status = LampControl.LampControlStatus.On;
            this.lampCtrlGreen.Status = LampControl.LampControlStatus.On;
            this.lampCtrlYellow.Status = LampControl.LampControlStatus.On;

            Store.StoreChanged += OnStoreChanged;
        }

        

        private void OnStoreChanged(object sender, string changeType)
        {
            switch (changeType)
            {
                case null:
                    SetHeader();
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
            }
        }

        private Store Store => Services.Store;

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
