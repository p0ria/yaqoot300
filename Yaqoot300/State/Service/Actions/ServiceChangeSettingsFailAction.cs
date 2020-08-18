using System;
using Yaqoot300.Interfaces;

namespace Yaqoot300.State.Service.Actions
{
    public class ServiceChangeSettingsFailAction : IAction
    {
        public ServiceChangeSettingsFailActionPayload Payload { get; set; }
        public string Type
        {
            get { return ServiceActionTypes.CHANGE_SETTINGS_FAIL; }
        }

        public ServiceChangeSettingsFailAction(ServiceChangeSettingsFailActionPayload payload = null)
        {
            this.Payload = payload;
        }
    }
}