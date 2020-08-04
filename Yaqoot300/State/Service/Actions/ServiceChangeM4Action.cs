using Yaqoot300.Interfaces;

namespace Yaqoot300.State.Service.Actions
{
    public class ServiceChangeM4Action : IAction
    {
        public string Type
        {
            get { return ServiceActionTypes.CHANGE_M4; }
        }

        public ServiceChangeM4ActionPayload Payload { get; set; }

        public ServiceChangeM4Action(ServiceChangeM4ActionPayload payload)
        {
            this.Payload = payload;
        }
    }
}