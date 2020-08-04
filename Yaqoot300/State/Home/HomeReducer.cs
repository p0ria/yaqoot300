using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Yaqoot300.Interfaces;
using Yaqoot300.State.Home.Actions;

namespace Yaqoot300.State.Home
{
    public class HomeReducer : IReducer<HomeState>
    {
        public void Reduce(HomeState state, IAction action)
        {
            switch (action.Type)
            {
                case HomeActionTypes.CHANGE_AUTO_START:
                    var changeAutoStartPayload = ((HomeChangeAutoStartAction)action).Payload;
                    if(changeAutoStartPayload.Status != null) state.Auto.StartBtn.Status = changeAutoStartPayload.Status.Value;
                    if (changeAutoStartPayload.IsEnabled != null)
                        state.Auto.StartBtn.IsEnabled = changeAutoStartPayload.IsEnabled.Value;
                    break;
            }
        }
    }
}
