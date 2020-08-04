using Yaqoot300.Interfaces;

namespace Yaqoot300.State.Service.Actions
{
    public class ServiceTestReadersSuccessAction : IAction
    {
        public ServiceTestReadersSuccessAction(TestReaderStatus[] payload)
        {
            this.Payload = payload;
        }

        public string Type
        {
            get { return ServiceActionTypes.TEST_READERS_SUCCESS; }
        }

        public TestReaderStatus[] Payload { get; set; }
      
    }
}