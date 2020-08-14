using Yaqoot300.Interfaces;

namespace Yaqoot300.State.App.Actions
{
    public class AppConnectionsChangedActionPayload
    {
        public ConnectionStatus? DbConnection { get; set; }
        public ConnectionStatus? PLCConnection { get; set; }
        public ConnectionStatus? ThinClient1Connection { get; set; }
        public ConnectionStatus? ThinClient2Connection { get; set; }
        public ConnectionStatus? ThinClient3Connection { get; set; }
    }
}