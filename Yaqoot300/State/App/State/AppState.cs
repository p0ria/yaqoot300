using Yaqoot300.Interfaces;

namespace Yaqoot300.State.App
{
    public class AppState
    {
        public AppState()
        {
            this.Connections = new ConnectionsState();
            this.SelectedMode = Mode.Service;
        }

        public ConnectionsState Connections { get; }
        public Mode SelectedMode { get; set; }
        public JobState SelectedJob { get; set; }
    }
}