using System.Windows.Forms;
using Yaqoot300.Commons;
using Yaqoot300.Interfaces;
using Yaqoot300.State.Home.Actions;
using Yaqoot300.State.PLC.Actions;

namespace Yaqoot300.Models.Signal
{
    public class PlcSignals
    {
        [Signal(0x01, 0x01)]
        public byte[] Start
        {
            set
            {
                Services.Store.Dispatch(new HomeChangeAutoStartAction(
                    new HomeChangeAutoStartActionPayload(AutoStartBtnStatus.Starting)));
            }
        }


        [Signal(0x01, 0x02)]
        public byte[] Started
        {
            set
            {
                Services.Store.Dispatch(new PlcStartReadyChangedAction(true));
            }
        }



        [Signal(0x02)]
        public byte[] Stop
        {
            set { MessageBox.Show("STOP SIGNAL FROM MACHINE"); }
        }
    }
}