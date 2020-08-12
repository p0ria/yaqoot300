using System.Windows.Forms;

namespace Yaqoot300.Models.Signal
{
    public class PlcSignals
    {
        [Signal(0x01)]
        public byte[] Start
        {
            set { MessageBox.Show("START SIGNAL FROM MACHINE"); }
        }

        [Signal(0x02)]
        public byte[] Stop
        {
            set { MessageBox.Show("STOP SIGNAL FROM MACHINE"); }
        }
    }
}