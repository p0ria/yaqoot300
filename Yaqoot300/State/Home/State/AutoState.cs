

using Yaqoot300.Interfaces;

namespace Yaqoot300.State.Home
{
    public class AutoState
    {
        public AutoStartBtnState StartBtn { get; set; }

        public AutoState()
        {
            this.StartBtn = new AutoStartBtnState();
        }
    }
}