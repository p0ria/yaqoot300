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
using Yaqoot300.State;
using Yaqoot300.State.Home;
using Yaqoot300.State.Home.Actions;

namespace Yaqoot300.Controls
{
    public partial class PlcErrosControl : UserControl
    {
        public PlcErrosControl()
        {
            InitializeComponent();
            Store.StoreChanged += OnStoreChanged;
        }

        private void OnStoreChanged(object sender, string changeType)
        {
            switch (changeType)
            {
                case null:
                case HomeActionTypes.ADD_PLC_ERROR:
                case HomeActionTypes.REMOVE_PLC_ERROR:
                    SetErrors();
                    break;
                
            }
        }

        private void SetErrors()
        {
            this.panelErrors.Controls.Clear();
            foreach (var error in Store.Home.PlcErrors)
            {
                this.panelErrors.Controls.Add(new PlcErrorControl
                {
                    Error = error
                });
            }
        }

        private Store Store => Services.Store;
    }
}
