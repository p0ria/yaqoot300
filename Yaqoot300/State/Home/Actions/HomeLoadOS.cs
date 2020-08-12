using Yaqoot300.Interfaces;

namespace Yaqoot300.State.Home.Actions
{
    public class HomeLoadOS : IAction
    {
        public string Type
        {
            get { return HomeActionTypes.LOAD_OS; }
        }
    }
}