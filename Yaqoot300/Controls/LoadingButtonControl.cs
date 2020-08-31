using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using log4net.Appender;

namespace Yaqoot300.Controls
{
    public partial class LoadingButtonControl : UserControl
    {
        private Color _backColor = Color.DodgerBlue;
        public enum LoadingButtonControlStatus
        {
            Invisible, Visible, Loading
        }

        public event EventHandler BtnClicked; 

        private LoadingButtonControlStatus _status;

        public LoadingButtonControl()
        {
            InitializeComponent();
            this.btnSave.Click += (s, e) => this.BtnClicked?.Invoke(s, e);
        }

        public LoadingButtonControlStatus Status
        {
            get { return _status; }
            set
            {
                _status = value;
                switch (value)
                {
                    case LoadingButtonControlStatus.Invisible:
                        this.btnSave.Visible = false;
                        this.pbLoading.Visible = false;
                        break;
                    case LoadingButtonControlStatus.Visible:
                        this.btnSave.Visible = true;
                        this.pbLoading.Visible = false;
                        break;
                    case LoadingButtonControlStatus.Loading:
                        this.btnSave.Visible = false;
                        this.pbLoading.Visible = true;
                        break;
                }
            }
        }

        public string Label
        {
            get { return this.btnSave.Text; }
            set { this.btnSave.Text = value; }
        }

        protected override void OnEnabledChanged(EventArgs e)
        {
            base.OnEnabledChanged(e);
            btnSave.Enabled = this.Enabled;
            if (this.Enabled) btnSave.BackColor = _backColor;
            else btnSave.BackColor = Color.DarkGray;
        }

        public override Color BackColor
        {
            set
            {
                _backColor = value;
                btnSave.BackColor = value;
            }
        }

        public override Color ForeColor
        {
            set { btnSave.ForeColor = value; }
        }
    }
}
