namespace Shared.ThinClient.Responses
{
    public enum TCResponseType
    {
        OSLoadSuccess, OSLoadFail
    }
    public class TCResponse
    {
        public TCResponseType Type { get; set; }
        public object Payload { get; set; }
    }
}