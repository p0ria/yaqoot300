using Yaqoot300.Commons;
using Yaqoot300.Interfaces;

namespace Yaqoot300.State.App.Actions
{
    public class AppChangeModeAction : IAction
    {
        public AppChangeModeAction(Mode mode)
        {
            this.Payload = mode;
        }

        public string Type
        {
            get { return AppActionTypes.CHANGE_MODE; }
        }

        public Mode Payload { get; set; }
    }
}