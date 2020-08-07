using System;
using System.Windows.Forms;
using Yaqoot300.Interfaces;
using Yaqoot300.State.App;
using Yaqoot300.State.Home;
using Yaqoot300.State.Job;
using Yaqoot300.State.Service;

namespace Yaqoot300.State
{
    public class RootReducer
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        private readonly Store _store;
        private readonly AppReducer _appReducer;
        private readonly HomeReducer _homeReducer;
        private readonly ServiceReducer _serviceReducer;
        private readonly JobReducer _jobReducer;

        public RootReducer(Store store)
        {
            if(store == null) throw new ArgumentNullException(nameof(store));
            _store = store;
            this._appReducer = new AppReducer();
            this._homeReducer = new HomeReducer();
            this._serviceReducer = new ServiceReducer();
            this._jobReducer = new JobReducer();
        }

        public void Reduce(IAction action)
        {
            log.Debug(action.Type);
            this._appReducer.Reduce(_store.App, action);
            this._homeReducer.Reduce(_store.Home, action);
            this._serviceReducer.Reduce(_store.Service, action);
            this._jobReducer.Reduce(_store.Job, action);
            this._store.RaiseStoreChangedEvent(action.Type);
        }
    }
}
