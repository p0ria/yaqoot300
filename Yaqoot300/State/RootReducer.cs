using System;
using Yaqoot300.Interfaces;
using Yaqoot300.State.App;
using Yaqoot300.State.Home;
using Yaqoot300.State.Service;

namespace Yaqoot300.State
{
    public class RootReducer
    {
        private readonly Store _store;
        private readonly AppReducer _appReducer;
        private readonly HomeReducer _homeReducer;
        private readonly ServiceReducer _serviceReducer;

        public RootReducer(Store store)
        {
            if(store == null) throw new ArgumentNullException(nameof(store));
            _store = store;
            this._appReducer = new AppReducer();
            this._homeReducer = new HomeReducer();
            this._serviceReducer = new ServiceReducer();
        }

        public void Reduce(IAction action)
        {
            this._appReducer.Reduce(_store.App, action);
            this._homeReducer.Reduce(_store.Home, action);
            this._serviceReducer.Reduce(_store.Service, action);
            this._store.RaiseStoreChangedEvent(action.Type);
        }
    }
}
