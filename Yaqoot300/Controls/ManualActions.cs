using System;
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
using Yaqoot300.State;
using Yaqoot300.State.Home.Actions;

namespace Yaqoot300.Controls
{
    public partial class ManualActions : UserControl
    {
        public ManualActions()
        {
            InitializeComponent();
            InitBtns();
            Store.StoreChanged += OnStoreChanged;
        }

        private void OnStoreChanged(object sender, string changeType)
        {
            switch (changeType)
            {
                case null:
                case HomeActionTypes.CHANGE_MANUAL_BTN:
                    SetBtns();
                    break;
            }
        }

        private void InitBtns()
        {
            btnLoadOS.BackColor = Color.DarkRed;
            btnCycle.BackColor = Color.CadetBlue;
            btnFeedIn.BackColor = Color.DodgerBlue;
            btnLoadOS.BtnClicked += (s, e) => BtnClicked(0);
            btnCycle.BtnClicked += (s, e) => BtnClicked(1);
            btnFeedIn.BtnClicked += (s, e) => BtnClicked(2);
        }

        private void BtnClicked(int btn)
        {
            if (Store.Home.Manual.BtnStatus == ManualBtnStatus.Idle)
            {
                switch (btn)
                {
                    case 0:
                        Store.Dispatch(new HomeChangeManualBtnAction(ManualBtnStatus.LoadOS));
                        break;

                    case 1:
                        Store.Dispatch(new HomeChangeManualBtnAction(ManualBtnStatus.Cycle));
                        break;

                    case 2:
                        Store.Dispatch(new HomeChangeManualBtnAction(ManualBtnStatus.FeedIn));
                        break;
                }
            }
        }

        private void SetBtns()
        {
            switch (Store.Home.Manual.BtnStatus)
            {
                case ManualBtnStatus.Idle:
                    btnLoadOS.Enabled = btnCycle.Enabled = btnFeedIn.Enabled = true;
                    btnLoadOS.Status =
                        btnCycle.Status = btnFeedIn.Status = LoadingButtonControl.LoadingButtonControlStatus.Visible;
                    break;

                case ManualBtnStatus.LoadOS:
                    btnLoadOS.Status = LoadingButtonControl.LoadingButtonControlStatus.Loading;
                    btnLoadOS.Enabled = true;
                    btnCycle.Enabled = btnFeedIn.Enabled = false;
                    break;

                case ManualBtnStatus.Cycle:
                    btnCycle.Status = LoadingButtonControl.LoadingButtonControlStatus.Loading;
                    btnCycle.Enabled = true;
                    btnLoadOS.Enabled = btnFeedIn.Enabled = false;
                    break;

                case ManualBtnStatus.FeedIn:
                    btnFeedIn.Status = LoadingButtonControl.LoadingButtonControlStatus.Loading;
                    btnFeedIn.Enabled = true;
                    btnLoadOS.Enabled = btnCycle.Enabled = false;
                    break;

            }
        }

        private Store Store => Services.Store;
    }
}
