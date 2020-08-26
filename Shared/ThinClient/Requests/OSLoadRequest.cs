using System.Collections.Generic;

namespace Shared.ThinClient.Requests
{
    public class OSLoadRequest
    {
        public IEnumerable<string> Readers { get; set; }
    }
}