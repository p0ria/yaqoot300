using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Exceptions
{
    public class ReaderError
    {
        public string Message { get; set; }
        public string ErrorCode { get; set; }
        public string LineNumber { get; set; }
    }
}
