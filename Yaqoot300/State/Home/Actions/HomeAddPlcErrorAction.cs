using Yaqoot300.Interfaces;

namespace Yaqoot300.State.Home.Actions
{
    public class HomeAddPlcErrorAction : IAction
    {
        public HomeAddPlcErrorAction(PlcErrorState error)
        {
            this.Payload = error;
        }

        public string Type
        {
            get { return HomeActionTypes.ADD_PLC_ERROR; }
        }

        public PlcErrorState Payload { get; set; }
    }
}