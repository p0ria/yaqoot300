using Yaqoot300.Interfaces;

namespace Yaqoot300.State.Home.Actions
{
    public class HomeChangeAutoStartActionPayload
    {
        public HomeChangeAutoStartActionPayload(AutoStartBtnStatus status) : this(status, null) { }
        public HomeChangeAutoStartActionPayload(bool isEnabled) : this(null, isEnabled) { }

        public HomeChangeAutoStartActionPayload(AutoStartBtnStatus? status, bool? isEnabled)
        {
            this.Status = status;
            this.IsEnabled = isEnabled;
        }
        public bool? IsEnabled { get; set; }
        public AutoStartBtnStatus? Status { get; set; }
    }
}