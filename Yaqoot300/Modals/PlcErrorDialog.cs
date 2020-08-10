using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Yaqoot300.Commons;
using Yaqoot300.Properties;
using Yaqoot300.State;
using Yaqoot300.State.Home;
using Yaqoot300.State.Home.Actions;

namespace Yaqoot300.Modals
{
    public partial class PlcErrorDialog : Form
    {
        

        private bool _dismissed = true;
        private readonly PlcErrorState _error;
        public PlcErrorDialog(PlcErrorState error)
        {
            _error = error;
            InitializeComponent();
            UpdateUI();
        }

        private void UpdateUI()
        {
            this.lblMessage.Text = _error.Message;
            switch (_error.Type)
            {
                case PlcErrorType.Error:
                    this.pbImage.Image = Resources.red_close_64x64;
                    this.DisableCloseButton();
                    break;
                case PlcErrorType.Warning:
                    this.pbImage.Image = Resources.yellow_close_64x64;
                    break;      
            }
            
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            if (_error.Type == PlcErrorType.Warning && _dismissed)
            {
                Store.Dispatch(new HomeRemovePlcErrorAction(_error.Id));
            }
            base.OnClosing(e);
        }

        protected override void OnResize(EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                _dismissed = false;
                this.Close();
            }
        }

        private Store Store => ServiceProvider.Store;
    }
}
