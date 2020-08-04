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
    public partial class TestReaderControl : UserControl
    {
        private TestReaderStatus _status;
        private int _number;
        public TestReaderControl()
        {
            InitializeComponent();
        }

        public TestReaderStatus Status
        {
            get { return _status; }
            set
            {
                _status = value;
                switch (value)
                {
                    case TestReaderStatus.NoOp:
                        this.BackColor = Color.LightGray;
                        this.ForeColor = Color.Black;
                        break;
                    case TestReaderStatus.Connecting:
                        this.BackColor = Color.Yellow;
                        this.ForeColor = Color.Black;
                        break;
                    case TestReaderStatus.Success:
                        this.BackColor = Color.LawnGreen;
                        this.ForeColor = Color.Black;
                        break;
                    case TestReaderStatus.Fail:
                        this.BackColor = Color.Red;
                        this.ForeColor = Color.White;
                        break;
                    case TestReaderStatus.Off:
                        this.BackColor = Color.Black;
                        this.ForeColor = Color.White;
                        break;
                }
            }
        }

        public int Number
        {
            get { return _number; }
            set
            {
                _number = value;
                lblNumber.Text = _number.ToString();
            }
        }
    }
}
