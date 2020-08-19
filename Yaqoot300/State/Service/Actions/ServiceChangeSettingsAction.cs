using Yaqoot300.Interfaces;

namespace Yaqoot300.State.Service.Actions
{
    public class ServiceChangeSettingsAction : IAction
    {
        public ServiceChangeSettingsAction(ServicePendingSettingsState payload)
        {
            this.Payload = payload;
        }

        public string Type
        {
            get { return ServiceActionTypes.CHANGE_SETTINGS; }
        }

        public ServicePendingSettingsState Payload { get; set; }
    }
}