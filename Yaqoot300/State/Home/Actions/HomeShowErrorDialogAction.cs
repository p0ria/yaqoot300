using Yaqoot300.Interfaces;

namespace Yaqoot300.State.Home.Actions
{
    public class HomeShowErrorDialogAction : IAction
    {
        public HomeShowErrorDialogAction(PlcErrorState error)
        {
            this.Payload = error;
        }
        public string Type { get { return HomeActionTypes.SHOW_ERROR_DIALOG; } }
        public PlcErrorState Payload { get; set; }
    }
}