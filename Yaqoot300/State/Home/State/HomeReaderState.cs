using Yaqoot300.Controls;

namespace Yaqoot300.State.Home
{
    public class HomeReaderState
    {
        public ReaderController.ReaderStatus Status { get; set; }
        public string ReaderId { get; set; }
    }
}