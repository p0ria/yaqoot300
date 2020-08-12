using Yaqoot300.Controls;
using Yaqoot300.Interfaces;

namespace Yaqoot300.State.Home
{
    public class HomeReaderState
    {
        public HomeReaderState(int number, ReaderStatus status)
        {
            this.ReaderNumber = number;
            this.Status = status;
        }

        public int ReaderNumber { get; set; }
        public ReaderStatus Status { get; set; }
        public int Total { get; set; }
        public int Good { get; set; }

        public float ErrorPercent
        {
            get
            {
                if (Total == 0) return 0;
                return 100 * (Total - Good) / (float) Total;
            }
        }
    }
}