using Yaqoot300.Commons;

namespace Yaqoot300.State.Service
{
    public class ServiceSetupReadersState
    {
        public ServiceSetupReadersState()
        {
            this.Readers = new SetupReaderState[Constants.READERS_COUNT];
            for (int i = 0; i < Constants.READERS_COUNT; i++)
            {
                Readers[i] = new SetupReaderState {ReaderNumber = i + 1};
            }
        }
        public SetupReaderState[] Readers { get; set; }
    }
}