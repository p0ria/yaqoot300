using Yaqoot300.Interfaces;

namespace Yaqoot300.State.Service.Actions
{
    public class ServiceChangeSettingsSuccessAction : IAction
    {
        public ServiceChangeSettingsSuccessAction(ServiceSettingsState payload)
        {
            this.Payload = payload;
        }

        public string Type
        {
            get { return ServiceActionTypes.CHANGE_SETTINGS_SUCCESS; }
        }

        public ServiceSettingsState Payload { get; set; }

    }
}