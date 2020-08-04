using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Yaqoot300.Controls
{
    public partial class MotorControl : UserControl
    {
        public MotorControl()
        {
            InitializeComponent();
        }

        public bool IsEnabled
        {
            get { return pbMotor.Enabled; }
            set
            {
                this.pbMotor.Enabled = value;
            }
        }
    }
}
