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
        private readonly ServicePendingSettingsState _pendingSettings = new ServicePendingSettingsState();
        private readonly Timer _timer = new Timer();
        public ServiceSettingsControl()
        {
            InitializeComponent();
            this.InitSettings();
            Store.StoreChanged += OnStoreChanged;
            _timer.Interval = Constants.SETTINGS_DEBOUNCE_TIME;
            _timer.Tick += OnSave;
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
                    ResetPendingSettings();
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

        private void ResetPendingSettings()
        {
            _pendingSettings.ActiveReaders = null;
            _pendingSettings.FeedInSteps = null;
            _pendingSettings.M3StepLength = null;
            _pendingSettings.M3Speed = null;
            _pendingSettings.M4Speed = null;
        }

        private void ChangeSlidersEnable(bool enable, params Control[] excludes)
        {
            this.scActiveReaders.Enabled = excludes.Contains(scActiveReaders) ? !enable : enable;
            this.scFeedInSteps.Enabled = excludes.Contains(scFeedInSteps) ? !enable : enable; ;
            this.scM3StepLength.Enabled = excludes.Contains(scM3StepLength) ? !enable : enable;
            this.scM3Speed.Enabled = excludes.Contains(scM3Speed) ? !enable : enable;
            this.scM4Speed.Enabled = excludes.Contains(scM4Speed) ? !enable : enable;
        }


        private void SettingsSliderOnValueChanged(object sender, int i1)
        {
            _timer.Enabled = false;

            if (scActiveReaders.Value != Store.Service.Settings.ActiveReaders)
            {
                _pendingSettings.ActiveReaders = scActiveReaders.Value;
                ChangeSlidersEnable(false, scActiveReaders);
            }

            if (scFeedInSteps.Value != Store.Service.Settings.FeedInSteps)
            {
                _pendingSettings.FeedInSteps = scFeedInSteps.Value;
                ChangeSlidersEnable(false, scFeedInSteps);
            }

            if (scM3StepLength.Value != Store.Service.Settings.M3StepLength)
            {
                _pendingSettings.M3StepLength = scM3StepLength.Value;
                ChangeSlidersEnable(false, scM3StepLength);
            }

            if (scM3Speed.Value != Store.Service.Settings.M3Speed)
            {
                _pendingSettings.M3Speed = scM3Speed.Value;
                ChangeSlidersEnable(false, scM3Speed);
            }

            if (scM4Speed.Value != Store.Service.Settings.M4Speed)
            {
                _pendingSettings.M4Speed = scM4Speed.Value;
                ChangeSlidersEnable(false, scM4Speed);
            }
                
            _timer.Enabled = true;
        }

        private void OnSave(object sender, EventArgs eventArgs)
        {
            ChangeSlidersEnable(false);
            Store.Dispatch(new ServiceChangeSettingsAction(_pendingSettings));
        }

        private Store Store => Services.Store;
    }
}
