using Yaqoot300.Interfaces;

namespace Yaqoot300.State.Service.Actions
{
    public class ServiceChangeM0Action : IAction
    {
        public string Type
        {
            get { return ServiceActionTypes.CHANGE_M0; }
        }

        public ServiceChangeMotorActionPayload Payload { get; set; }

        public ServiceChangeM0Action(ServiceChangeMotorActionPayload payload)
        {
            this.Payload = payload;
        }
    }
}