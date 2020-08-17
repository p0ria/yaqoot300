using Yaqoot300.Commons;
using Yaqoot300.Interfaces;

namespace Yaqoot300.State.Service.Actions
{
    public class ServiceSensorsChangedAction : IAction
    {
        public string Type
        {
            get { return ServiceActionTypes.SENSORS_CHANGED; }
        }

        public ServiceSensorsChangedActionPayload Payload { get; set; }

        public ServiceSensorsChangedAction(ServiceSensorsChangedActionPayload sensors)
        {
            this.Payload = sensors;
        }
    }
}