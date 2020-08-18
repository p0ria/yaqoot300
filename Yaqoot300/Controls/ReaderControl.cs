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
using Color = System.Drawing.Color;

namespace Yaqoot300.Controls
{
    public partial class ReaderControl : UserControl
    {
        private int _number;
        private ReaderStatus _status;
        private float _percent;
        public ReaderControl()
        {
            InitializeComponent();
            this.Percent = 100;
        }


        public ReaderStatus Status
        {
            get { return _status; }
            set
            {
                _status = value;
                switch (value)
                {
                    case ReaderStatus.Idle:
                        this.BackColor = Color.DarkGray;
                        break;
                    case ReaderStatus.Off:
                        this.BackColor = Color.Black;
                        break;
                    case ReaderStatus.Busy:
                        this.BackColor = Color.Yellow;
                        break;
                    case ReaderStatus.Success:
                        this.BackColor = Color.Green;
                        break;
                    case ReaderStatus.Fail:
                        this.BackColor = Color.Red;
                        break;

                }
            }
        }

        public float Percent
        {
            get { return _percent; }
            set
            {
                _percent = value;
                this.lblPercent.Text = Percent.ToString();
            }
        }

        public int Number
        {
            get { return _number; }
            set
            {
                _number = value;
                this.lblReaderNumber.Text = value.ToString();
            }
        }
    }
}
