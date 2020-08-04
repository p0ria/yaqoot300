namespace Yaqoot300.State.Service.Actions
{
    public class ServiceAssignReaderActionPayload
    {
        public ServiceAssignReaderActionPayload(string readerName, int readerNumber)
        {
            this.ReaderName = readerName;
            this.ReaderNumber = readerNumber;
        }

        public string ReaderName { get; set; }
        public int ReaderNumber { get; set; }
    }
}