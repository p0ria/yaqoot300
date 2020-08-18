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
using Yaqoot300.State;
using Yaqoot300.State.Service;
using Yaqoot300.State.Service.Actions;

namespace Yaqoot300.Controls
{
    public partial class ServiceSettingsControl : UserControl
    {
        public ServiceSettingsControl()
        {
            InitializeComponent();
            this.InitSettings();
            Store.StoreChanged += OnStoreChanged;
        }

        private void InitSettings()
        {
            this.scActiveReaders.ValueChanged += settingsSliderOnValueChanged;
            this.scFeedInSteps.ValueChanged += settingsSliderOnValueChanged;
            this.scM3StepLength.ValueChanged += settingsSliderOnValueChanged;
            this.scM4Speed.ValueChanged += settingsSliderOnValueChanged;
            this.btnSave.BtnClicked += OnBtnSaveClicked;
        }

        private void OnStoreChanged(object sender, string changeType)
        {
            switch (changeType)
            {
                case null:
                    SetSettings();
                    break;
                case ServiceActionTypes.CHANGE_SETTINGS_SUCCESS:
                case ServiceActionTypes.CHANGE_SETTINGS_FAIL:
                    SetSettings();
                    ChangeSlidersEnable(true);
                    ChangeBtnSaveStatus(LoadingButtonControl.LoadingButtonControlStatus.Invisible);
                    break;
            }
        }

        private void SetSettings()
        {
            this.SafeInvoke(() =>
            {
                this.scActiveReaders.Value = Store.Service.Settings.ActiveReaders;
                this.scFeedInSteps.Value = Store.Service.Settings.FeedInSteps;
                this.scM3StepLength.Value = Store.Service.Settings.M3StepLength;
                this.scM4Speed.Value = Store.Service.Settings.M4Speed;
            });
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

        private void settingsSliderOnValueChanged(object sender, int i1)
        {
            bool dirty = this.scActiveReaders.Value != Store.Service.Settings.ActiveReaders;
            if (!dirty && this.scFeedInSteps.Value != Store.Service.Settings.FeedInSteps) dirty = true;
            if (!dirty && this.scM3StepLength.Value != Store.Service.Settings.M3StepLength) dirty = true;
            if (!dirty && this.scM4Speed.Value != Store.Service.Settings.M4Speed) dirty = true;
            this.btnSave.Status =
                dirty
                    ? LoadingButtonControl.LoadingButtonControlStatus.Visible
                    : LoadingButtonControl.LoadingButtonControlStatus.Invisible;
        }

        private Store Store => Services.Store;
    }
}
