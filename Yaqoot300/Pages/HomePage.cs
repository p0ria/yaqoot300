﻿using System;
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
using Yaqoot300.State;
using Yaqoot300.State.App.Actions;
using Yaqoot300.State.Home.Actions;
using Yaqoot300.State.Job.Actions;

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
            this.panelErrors.Controls.Add(new ErrorControl());
            this.panelErrors.Controls.Add(new ErrorControl());
            this.lampCtrlRed.Type = LampControl.LampControlType.Red;
            this.lampCtrlGreen.Type = LampControl.LampControlType.Green;
            this.lampCtrlYellow.Type = LampControl.LampControlType.Yellow;
            this.lampCtrlRed.Status = LampControl.LampControlStatus.On;
            this.lampCtrlGreen.Status = LampControl.LampControlStatus.On;
            this.lampCtrlYellow.Status = LampControl.LampControlStatus.On;
            this.Controls.Add(new LampControl{Type = LampControl.LampControlType.Green, Status = LampControl.LampControlStatus.On});

            ServiceProvider.Store.StoreChanged += OnStoreChanged;
        }

        private void OnStoreChanged(object sender, string changeType)
        {
            switch (changeType)
            {
                case null:
                    SetHeader();
                    SetImage(pbConnectionDb, Store.App.Connections.DbConnection);
                    SetImage(pbConnectionPLC, Store.App.Connections.PLCConnection);
                    SetImage(pbConnectionClient1, Store.App.Connections.ThinClient1Connection);
                    SetImage(pbConnectionClient2, Store.App.Connections.ThinClient2Connection);
                    SetImage(pbConnectionClient3, Store.App.Connections.ThinClient3Conenction);
                    SetActions();
                    break;

                case AppActionTypes.CHANGE_MODE:
                    SetHeader();
                    SetActions();
                    break;
            }
        }

        private Store Store => ServiceProvider.Store;

        private void SetImage(PictureBox pb, ConnectionStatus status)
        {
            switch (status)
            {
                case ConnectionStatus.Connected:
                    pb.Image = ServiceProvider.ImageList32.Images[0];
                    break;
                case ConnectionStatus.Disconnected:
                    pb.Image = ServiceProvider.ImageList32.Images[1];
                    break;
                case ConnectionStatus.Connecting:
                    pb.Image = ServiceProvider.ImageList32.Images[2];
                    break;
            }
        }

        private void SetHeader()
        {
            switch (Store.App.SelectedMode)
            {
                case Mode.Auto:
                    this.lblMode.Text = "AUTO";
                    break;
                case Mode.Manual:
                    this.lblMode.Text = "MANUAL";
                    break;
            }
        }

        private void SetActions()
        {
            if(_currentMode == Store.App.SelectedMode) return;
            switch (Store.App.SelectedMode)
            {
                case Mode.Auto:
                    this.panelActions.Controls.Clear();
                    this.panelActions.Controls.Add(_autoActions);
                    break;

                case Mode.Manual:
                    this.panelActions.Controls.Clear();
                    this.panelActions.Controls.Add(_manualActions);
                    break;
            }
            _currentMode = Store.App.SelectedMode;
        }

        private void btnSelectJob_Click(object sender, EventArgs e)
        {
            using (var dlg = new JobDialog())
            {
                dlg.ShowDialog();
                MessageBox.Show(dlg.SelectedJob.LotNumber);
            }
            
        }
    }
}