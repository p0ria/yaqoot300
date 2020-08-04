using Yaqoot300.Interfaces;

namespace Yaqoot300.State.Service.Actions
{
    public class ServiceChangeM1Action : IAction
    {
        public string Type
        {
            get { return ServiceActionTypes.CHANGE_M1; }
        }

        public ServiceChangeMotorActionPayload Payload { get; set; }

        public ServiceChangeM1Action(ServiceChangeMotorActionPayload payload)
        {
            this.Payload = payload;
        }
    }
}