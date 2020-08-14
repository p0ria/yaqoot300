using Yaqoot300.Interfaces;

namespace Yaqoot300.State.PLC.Actions
{
    public class PlcStartReadyChangedAction : IAction
    {
        public PlcStartReadyChangedAction(bool? isReady)
        {
            this.Payload = isReady;
        }
        public string Type
        {
            get { return PlcActionTypes.START_READY_CHANGED; }
        }

        public bool? Payload { get; set; }
    }
}