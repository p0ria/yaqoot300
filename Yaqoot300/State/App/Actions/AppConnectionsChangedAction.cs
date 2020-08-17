using Yaqoot300.Interfaces;

namespace Yaqoot300.State.App.Actions
{
    public class AppConnectionsChangedAction : IAction
    {
        public AppConnectionsChangedAction(AppConnectionsChangedActionPayload connections)
        {
            this.Payload = connections;
        }

        public string Type
        {
            get { return AppActionTypes.CONENCTIONS_CHANGED; }
        }

        public AppConnectionsChangedActionPayload Payload { get; set; }
    }
}