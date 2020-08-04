using Yaqoot300.Interfaces;

namespace Yaqoot300.State.Home.Actions
{
    public class HomeChangeAutoStartAction: IAction
    {
        public HomeChangeAutoStartAction(HomeChangeAutoStartActionPayload payload)
        {
            this.Payload = payload;
        }

        public string Type
        {
            get { return HomeActionTypes.CHANGE_AUTO_START; }
        }

        public HomeChangeAutoStartActionPayload Payload { get; set; }
    }
}