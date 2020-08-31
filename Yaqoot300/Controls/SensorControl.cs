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
    public partial class SensorControl : UserControl
    {
        private string _label;
        private bool _isOn;

        public SensorControl()
        {
            InitializeComponent();
        }

        public string Label
        {
            get { return _label; }
            set
            {
                _label = value;
                this.lblName.Text = value;
            }
        }

        public bool IsOn
        {
            get { return _isOn; }
            set
            {
                _isOn = value;
                this.BackColor = _isOn ? Color.MediumSeaGreen : Color.LightGray;
            }
        }
    }
}
