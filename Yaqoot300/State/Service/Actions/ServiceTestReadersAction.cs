using Yaqoot300.Interfaces;

namespace Yaqoot300.State.Service.Actions
{
    public class ServiceTestReadersAction : IAction
    {
        public string Type
        {
            get { return ServiceActionTypes.TEST_READERS; }
        }
    }
}