using Shared.Exceptions;

namespace Shared.ThinClient.Responses
{
    public enum OsLoadSignleResponseType
    {
        Success, Fail
    }
    public class OSLoadSingleResponse
    {
        public string ReaderName { get; set; }
        public OsLoadSignleResponseType OsLoadSignleResponseType { get; set; }
        public ReaderError Error { get; set; }
        public string CSN { get; set; }
    }
}