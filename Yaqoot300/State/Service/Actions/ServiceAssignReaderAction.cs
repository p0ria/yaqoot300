using Yaqoot300.Interfaces;

namespace Yaqoot300.State.Service.Actions
{
    public class ServiceAssignReaderAction : IAction
    {
        public ServiceAssignReaderAction(ServiceAssignReaderActionPayload payload)
        {
            this.Payload = payload;
        }

        public string Type
        {
            get { return ServiceActionTypes.ASSIGN_READER; }
        }

        public ServiceAssignReaderActionPayload Payload { get; set; }
    }
}