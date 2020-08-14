using Yaqoot300.Interfaces;
using Yaqoot300.State.PLC.Actions;

namespace Yaqoot300.State.PLC
{
    public class PlcReducer: IReducer<PlcState>
    {
        public void Reduce(PlcState state, IAction action)
        {
            switch (action.Type)
            {
                case PlcActionTypes.START_READY_CHANGED:
                    var startReadyChangedPayload = ((PlcStartReadyChangedAction) action).Payload;
                    state.IsStartReady = startReadyChangedPayload;
                    break;
            }
        }
    }
}