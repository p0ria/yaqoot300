using Yaqoot300.Interfaces;

namespace Yaqoot300.State.Service.Actions
{
    public class ServiceChangeM3Action : IAction
    {
        public string Type
        {
            get { return ServiceActionTypes.CHANGE_M3; }
        }

        public ServiceChangeMotorActionPayload Payload { get; set; }

        public ServiceChangeM3Action(ServiceChangeMotorActionPayload payload)
        {
            this.Payload = payload;
        }
    }
}