using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Yaqoot300.Interfaces;

namespace Yaqoot300.Controls
{
    public partial class UpDownMotorControl : UserControl
    {
        public enum BtnClickedType
        {
            Up, Down
        }

        private bool _isUpEnabled;
        private bool _isDownEnabled;
        private UpDownMotorStatus _status;

        public event EventHandler<BtnClickedType> BtnClicked;

        public UpDownMotorControl()
        {
            InitializeComponent();
            this.btnUp.MouseDown += BtnUpOnMouseDown;
            this.btnDown.MouseDown += BtnDownOnMouseDown;
        }

        private void BtnUpOnMouseDown(object sender, MouseEventArgs mouseEventArgs)
        {
            this.RaiseBtnClickedEvent(BtnClickedType.Up);
        }

        private void BtnDownOnMouseDown(object sender, MouseEventArgs mouseEventArgs)
        {
            this.RaiseBtnClickedEvent(BtnClickedType.Down);
        }

        public bool IsUpEnabled
        {
            get { return _isUpEnabled; }
            set
            {
                _isUpEnabled = value;
                btnUp.Enabled = value;
                btnUp.Cursor = value ? Cursors.Hand : Cursors.No;
            }
        }

        public bool IsDownEnabled
        {
            get { return _isDownEnabled; }
            set
            {
                _isDownEnabled = value;
                btnDown.Enabled = value;
                btnDown.Cursor = value ? Cursors.Hand : Cursors.No;
            }
        }

        public UpDownMotorStatus Status
        {
            get { return _status; }
            set
            {
                _status = value;
                switch (value)
                {
                    case UpDownMotorStatus.Idle:
                        btnUp.BackColor = btnDown.BackColor = Color.WhiteSmoke;
                        btnUp.ForeColor = btnDown.ForeColor = Color.Black;
                        pbMotor.Enabled = false;
                        break;

                    case UpDownMotorStatus.GoingUp:
                        btnUp.BackColor = Color.DodgerBlue;
                        btnUp.ForeColor = Color.White;
                        pbMotor.Enabled = true;
                        break;

                    case UpDownMotorStatus.GoingDown:
                        btnDown.BackColor = Color.DodgerBlue;
                        btnDown.ForeColor = Color.White;
                        pbMotor.Enabled = true;
                        break;
                }
            }
        }

        private void RaiseBtnClickedEvent(BtnClickedType status)
        {
            this.BtnClicked?.Invoke(this, status);
        }

    }
}
