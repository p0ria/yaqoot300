using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Yaqoot300.Commons;
using Yaqoot300.Modals;
using Yaqoot300.Properties;
using Yaqoot300.State;
using Yaqoot300.State.Home;
using Yaqoot300.State.Home.Actions;

namespace Yaqoot300.Controls
{
    public partial class PlcErrorControl : UserControl
    {
        public PlcErrorControl()
        {
            InitializeComponent();
            this.btnError.Image= Resources.error_64x64;
        }

        public PlcErrorState Error { get; set; }

        private void btnError_Click(object sender, EventArgs e)
        {
            Store.Dispatch(new HomeShowErrorDialogAction(this.Error));
        }

        private Store Store => Services.Store;
    }
}
