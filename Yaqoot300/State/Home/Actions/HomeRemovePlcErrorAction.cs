using Yaqoot300.Interfaces;

namespace Yaqoot300.State.Home.Actions
{
    public class HomeRemovePlcErrorAction : IAction
    {
        public HomeRemovePlcErrorAction(int errorId)
        {
            this.Payload = errorId;
        }
        public string Type
        {
            get { return HomeActionTypes.REMOVE_PLC_ERROR; }
        }

        public int Payload { get; set; }
    }
}