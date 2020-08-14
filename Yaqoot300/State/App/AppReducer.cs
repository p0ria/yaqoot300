using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Yaqoot300.Interfaces;
using Yaqoot300.State.App.Actions;

namespace Yaqoot300.State.App
{
    public class AppReducer : IReducer<AppState>
    {
        public void Reduce(AppState state, IAction action)
        {
            switch (action.Type)
            {
                case AppActionTypes.CHANGE_MODE:
                    var changeModePayload = ((AppChangeModeAction)action).Payload;
                    state.SelectedMode = changeModePayload;
                    break;

                case AppActionTypes.CONENCTIONS_CHANGED:
                    var connectionsStatusChangedPayload = ((AppConnectionsChangedAction)action).Payload;
                    if (connectionsStatusChangedPayload.DbConnection.HasValue)
                        state.Connections.DbConnection = connectionsStatusChangedPayload.DbConnection.Value;
                    if (connectionsStatusChangedPayload.PLCConnection.HasValue)
                        state.Connections.PLCConnection = connectionsStatusChangedPayload.PLCConnection.Value;
                    if (connectionsStatusChangedPayload.ThinClient1Connection.HasValue)
                        state.Connections.ThinClient1Connection = connectionsStatusChangedPayload.ThinClient1Connection.Value;
                    if (connectionsStatusChangedPayload.ThinClient2Connection.HasValue)
                        state.Connections.ThinClient2Connection = connectionsStatusChangedPayload.ThinClient2Connection.Value;
                    if (connectionsStatusChangedPayload.ThinClient3Connection.HasValue)
                        state.Connections.ThinClient3Conenction = connectionsStatusChangedPayload.ThinClient3Connection.Value;
                    break;
            }
        }
    }
}
