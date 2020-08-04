using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Yaqoot300.Interfaces;
using Yaqoot300.State.App.Actions;

namespace Yaqoot300.State.App
{
    public class AppReducer : IReducer<AppState>
    {
        public void Reduce(AppState state, IAction action)
        {
            switch (action.Type)
            {
                case AppActionTypes.CHANGE_MODE:
                    var changeModePayload = ((AppChangeModeAction)action).Payload;
                    state.SelectedMode = changeModePayload;
                    break;
            }
        }
    }
}
