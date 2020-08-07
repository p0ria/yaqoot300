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
using Yaqoot300.State.Home.Actions;
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
                    Store.Dispatch(new HomeChangeAutoStartAction(
                        new HomeChangeAutoStartActionPayload(AutoStartBtnStatus.Starting, false)));
                    break;
                case AutoStartBtnStatus.Started:
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
                            this.btnStart.Text = "Start";
                            this.btnStart.ForeColor = Color.White;
                            this.btnStart.BackColor = Color.DodgerBlue;
                            break;
                        case AutoStartBtnStatus.Starting:
                            this.btnStart.Text = "Starting...";
                            this.btnStart.ForeColor = Color.Black;
                            this.btnStart.BackColor = Color.Yellow;
                            break;
                        case AutoStartBtnStatus.Started:
                            this.btnStart.Text = "Stop";
                            this.btnStart.ForeColor = Color.White;
                            this.btnStart.BackColor = Color.DarkOrange;
                            break;
                    }
                    this.btnStart.Enabled = Store.Home.Auto.StartBtn.IsEnabled;
                    break;

            }
        }

        private Store Store
        {
            get { return ServiceProvider.Store; }
        }
    }
}
