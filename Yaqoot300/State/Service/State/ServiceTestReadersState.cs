using Yaqoot300.Commons;
using Yaqoot300.Interfaces;

namespace Yaqoot300.State.Service
{
    public class ServiceTestReadersState
    {
        public ServiceTestReadersState()
        {
            this.Readers = new TestReaderStatus[Constants.READERS_COUNT];
        }
        public TestReaderStatus[] Readers { get; set; }
    }
}