using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Yaqoot300.Controls
{
    public partial class SetupReaderControl : UserControl
    {

        private int _number;
        private string _readerName;
        private bool _isActive;
        public SetupReaderControl()
        {
            InitializeComponent();
            this.MouseEnter += OnMouseEnter;
            this.lblNumber.MouseEnter += OnMouseEnter;
            this.MouseLeave += OnMouseLeave;
            this.Click += OnClick;
            this.lblNumber.Click += OnClick;
        }

        private void OnClick(object sender, EventArgs eventArgs)
        {
            if(!IsAssigned && IsActive)
                RaiseAssignedEvent();
        }

        public event EventHandler Assigned; 

        private void OnMouseEnter(object sender, EventArgs eventArgs)
        {
            if (!IsAssigned && IsActive)
            {
                this.BackColor = Color.Aqua;
                this.ForeColor = Color.Black;
            }
        }

        private void OnMouseLeave(object sender, EventArgs eventArgs)
        {
            if (!IsAssigned)
            {
                this.BackColor = Color.Transparent;
                this.ForeColor = Color.Black;
            }
        }

        public int Number
        {
            get { return _number; }
            set
            {
                _number = value;
                this.lblNumber.Text = _number.ToString();
            }
        }

        public string ReaderName
        {
            get { return _readerName; }
            set
            {
                _readerName = value;
                if (IsAssigned)
                {
                    this.BackColor = Color.White;
                    this.Cursor = Cursors.No;
                }
                else
                {
                    this.BackColor = Color.Transparent;
                    this.ForeColor = Color.Black;
                    this.Cursor = Cursors.Arrow;

                }
            }
        }

        public bool IsActive
        {
            get { return _isActive; }
            set
            {
                _isActive = value;
                if (!IsAssigned)
                {
                    this.BackColor = Color.Transparent;
                    this.ForeColor = Color.Black;
                    this.Cursor = value ? Cursors.Hand : Cursors.Arrow;
                }
            }
        }

        public bool IsAssigned
        {
            get { return !string.IsNullOrEmpty(_readerName); }
        }

        public void RaiseAssignedEvent()
        {
            this.Assigned?.Invoke(this, null);
        }

    }
}
