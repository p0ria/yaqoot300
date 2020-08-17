using Yaqoot300.Interfaces;

namespace Yaqoot300.State.Service.Actions
{
    public class ServiceChangeSettingsSuccessAction : IAction
    {
        public string Type
        {
            get { return ServiceActionTypes.CHANGE_SETTINGS_SUCCESS; }
        }

    }
}