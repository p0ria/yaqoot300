using System.Collections.Generic;

namespace Shared.ThinClient.Responses
{
    public class OSLoadSuccessResponse
    {
        public IEnumerable<OSLoadSingleResponse> Responses { get; set; }
    }
}