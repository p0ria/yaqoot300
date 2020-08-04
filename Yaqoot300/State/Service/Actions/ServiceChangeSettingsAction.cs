using Yaqoot300.Interfaces;

namespace Yaqoot300.State.Service.Actions
{
    public class ServiceChangeSettingsAction : IAction
    {
        public ServiceChangeSettingsAction(ServiceSettingsState payload)
        {
            this.Payload = payload;
        }

        public string Type
        {
            get { return ServiceActionTypes.CHANGE_SETTINGS; }
        }

        public ServiceSettingsState Payload { get; set; }
    }
}