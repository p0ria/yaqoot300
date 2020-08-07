using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Yaqoot300.Interfaces;
using Yaqoot300.State.App;
using Yaqoot300.State.Home;
using Yaqoot300.State.Job;
using Yaqoot300.State.Job.State;
using Yaqoot300.State.Service;

namespace Yaqoot300.State
{
    public class Store
    {
        public event EventHandler<string> StoreChanged;

        public AppState App { get; }
        public HomeState Home { get; }
        public ServiceState Service { get; set; }
        public JobState Job {get; set; }

        private readonly RootReducer _reducer;

        public Store()
        {
            this.App = InitialAppState.Instance;
            this.Home = InitialHomeState.Instance;
            this.Service = InitialServiceState.Instance;
            this.Job = InitialJobState.Instance;
            _reducer = new RootReducer(this);
        }

        public void Dispatch(IAction action)
        {
            this._reducer.Reduce(action);
        }

        public void RaiseStoreChangedEvent(string arg = null)
        {
            this.StoreChanged?.Invoke(this, arg);
        }
    }
}
