using Yaqoot300.Interfaces;

namespace Yaqoot300.State.Home.Actions
{
    public class HomeLoadOSFail : IAction
    {
        public HomeLoadOSFail(string error)
        {
            this.Payload = error;
        }

        public string Type
        {
            get { return HomeActionTypes.LOAD_OS_SUCCESS; }
        }

        public string Payload { get; set; }
    }
}