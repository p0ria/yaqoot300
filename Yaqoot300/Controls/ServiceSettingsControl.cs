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
            this.scActiveReaders.ValueChanged += SettingsSliderOnValueChanged;
            this.scFeedInSteps.ValueChanged += SettingsSliderOnValueChanged;
            this.scM3StepLength.ValueChanged += SettingsSliderOnValueChanged;
            this.scM3Speed.ValueChanged += SettingsSliderOnValueChanged;
            this.scM4Speed.ValueChanged += SettingsSliderOnValueChanged;
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
                this.scM3Speed.Value = Store.Service.Settings.M3Speed;
                this.scM4Speed.Value = Store.Service.Settings.M4Speed;
            });
        }

        private void ChangeSlidersEnable(bool enable)
        {
            this.scActiveReaders.Enabled = enable;
            this.scFeedInSteps.Enabled = enable;
            this.scM3StepLength.Enabled = enable;
            this.scM3Speed.Enabled = enable;
            this.scM4Speed.Enabled = enable;
        }


        private void SettingsSliderOnValueChanged(object sender, int i1)
        {
            ChangeSlidersEnable(false);
            var pendingSettings = new ServicePendingSettingsState();
            if (scActiveReaders.Value != Store.Service.Settings.ActiveReaders)
                pendingSettings.ActiveReaders = scActiveReaders.Value;
            if (scFeedInSteps.Value != Store.Service.Settings.FeedInSteps)
                pendingSettings.FeedInSteps = scFeedInSteps.Value;
            if (scM3StepLength.Value != Store.Service.Settings.M3StepLength)
                pendingSettings.M3StepLength = scM3StepLength.Value;
            if (scM3Speed.Value != Store.Service.Settings.M3Speed)
                pendingSettings.M3Speed = scM3Speed.Value;
            if (scM4Speed.Value != Store.Service.Settings.M4Speed)
                pendingSettings.M4Speed = scM4Speed.Value;
            Store.Dispatch(new ServiceChangeSettingsAction(pendingSettings));
        }

        private Store Store => Services.Store;
    }
}
