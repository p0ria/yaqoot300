﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Yaqoot300.Commons;
using Yaqoot300.Interfaces;
using Yaqoot300.Models.Signal;
using Yaqoot300.State;
using Yaqoot300.State.Home.Actions;
using Yaqoot300.State.PLC.Actions;
using Timer = System.Threading.Timer;

namespace Yaqoot300.Controls
{
    public partial class AutoActions : UserControl
    {
        public AutoActions()
        {
            InitializeComponent();
            Store.StoreChanged += OnStoreChanged;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            switch (Store.Home.Auto.StartBtn.Status)
            {
                case AutoStartBtnStatus.Stoped:
                    Services.Store.Dispatch(new PlcStartReadyChangedAction(null));
                    Store.Dispatch(new HomeChangeAutoStartAction(
                        new HomeChangeAutoStartActionPayload(AutoStartBtnStatus.Starting, false)));
                    break;
                case AutoStartBtnStatus.Started:
                    Services.Signals.Send(GuiSignals.Stop);
                    Store.Dispatch(new HomeChangeAutoStartAction(
                        new HomeChangeAutoStartActionPayload(AutoStartBtnStatus.Stoped)));
                    break;
            }
        }

        private void OnStoreChanged(object sender, string changeType)
        {
            switch (changeType)
            {
                case null:
                case HomeActionTypes.CHANGE_AUTO_START:
                    switch (Store.Home.Auto.StartBtn.Status)
                    {
                        case AutoStartBtnStatus.Stoped:
                            this.SafeInvoke(() =>
                            {
                                this.btnStart.Text = "Start";
                                this.btnStart.ForeColor = Color.White;
                                this.btnStart.BackColor = Color.DodgerBlue;
                                this.pbLoading.Visible = false;
                                this.btnStart.Visible = true;
                                this.btnStart.Enabled = Store.Home.Auto.StartBtn.IsEnabled;
                            });
                            break;
                        case AutoStartBtnStatus.Starting:
                            this.SafeInvoke(() =>
                            {
                                this.btnStart.Visible = false;
                                this.pbLoading.Visible = true;
                                this.btnStart.Enabled = Store.Home.Auto.StartBtn.IsEnabled;
                            });
                            break;
                        case AutoStartBtnStatus.Started:
                            this.SafeInvoke(() =>
                            {
                                this.btnStart.Text = "Stop";
                                this.btnStart.ForeColor = Color.White;
                                this.btnStart.BackColor = Color.DarkOrange;
                                this.pbLoading.Visible = false;
                                this.btnStart.Visible = true;
                                this.btnStart.Enabled = Store.Home.Auto.StartBtn.IsEnabled;
                            });
                            break;
                    }
                    break;

            }
        }

        private Store Store
        {
            get { return Services.Store; }
        }
    }
}
