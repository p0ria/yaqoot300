using Yaqoot300.Interfaces;

namespace Yaqoot300.State.Service.Actions
{
    public class ServiceChangeM2Action : IAction
    {
        public string Type
        {
            get { return ServiceActionTypes.CHANGE_M2; }
        }

        public ServiceChangeMotorActionPayload Payload { get; set; }

        public ServiceChangeM2Action(ServiceChangeMotorActionPayload payload)
        {
            this.Payload = payload;
        }
    }
}