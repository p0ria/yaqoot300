using System;

namespace Shared.ThinClient.Requests
{
    public enum TCRequestType
    {
        LoadOS, TestReaders
    }
    public class TCRequest
    {
        public TCRequestType Type { get; set; }
        public object Payload { get; set; }
    }
}