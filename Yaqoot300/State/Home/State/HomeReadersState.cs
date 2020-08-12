using System.Collections.Generic;
using System.Linq;

namespace Yaqoot300.State.Home
{
    public class HomeReadersState
    {
        public HomeReadersState()
        {
            this.Readers = new List<HomeReaderState>();
        }
        public List<HomeReaderState> Readers { get; set; }
        public HomeReaderState this[int readerNumber]
        {
            get
            {
                return this.Readers.FirstOrDefault(r => r.ReaderNumber == readerNumber);
            }
        }
    }
}