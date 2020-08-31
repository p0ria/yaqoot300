using Yaqoot300.Interfaces;

namespace Yaqoot300.State.Home.Actions
{
    public class HomeChangeManualBtnAction : IAction
    {
        public HomeChangeManualBtnAction(ManualBtnStatus status)
        {
            Payload = status;
        }

        public string Type
        {
            get { return HomeActionTypes.CHANGE_MANUAL_BTN; }
        }

        public ManualBtnStatus Payload { get; set; }
    }
}