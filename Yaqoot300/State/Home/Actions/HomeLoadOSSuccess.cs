using System.Collections.Generic;
using Yaqoot300.Interfaces;
using Yaqoot300.Models.ThinClient;

namespace Yaqoot300.State.Home.Actions
{
    public class HomeLoadOSSuccess : IAction
    {
        public HomeLoadOSSuccess(IEnumerable<ReaderResponse> readers)
        {
            this.Payload = readers;
        }

        public string Type
        {
            get { return HomeActionTypes.LOAD_OS_SUCCESS; }
        }

        public IEnumerable<ReaderResponse> Payload { get; set; }
    }
}