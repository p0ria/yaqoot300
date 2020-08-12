using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Yaqoot300.Commons;

namespace Yaqoot300.State.Service
{
    public class ServiceSetupReadersState
    {
        public ServiceSetupReadersState()
        {
            this.Readers = new List<SetupReaderState>();
        }
        public int? this[string readerName]
        {
            get
            {
                var reader = this.Readers.FirstOrDefault(r => r.ReaderName.Equals(readerName));
                return reader?.ReaderNumber;
            }
        }

        public string this[int readerNumber]
        {
            get
            {
                var reader = this.Readers.FirstOrDefault(r => r.ReaderNumber == readerNumber);
                return reader?.ReaderName;
            }
        }
        public List<SetupReaderState> Readers { get; set; }
    }
}