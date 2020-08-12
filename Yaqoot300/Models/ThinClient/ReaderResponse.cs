using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Yaqoot300.Interfaces;

namespace Yaqoot300.Models.ThinClient
{
    public class ReaderResponse
    {
        public string ReaderName { get; set; }
        public ReaderStatus Status { get; set; }
    }
}
