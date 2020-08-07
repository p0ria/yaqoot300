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
using Yaqoot300.Properties;

namespace Yaqoot300.Controls
{
    public partial class ErrorControl : UserControl
    {
        public ErrorControl()
        {
            InitializeComponent();
            this.btnError.Image= Resources.error_64x64;
        }
    }
}
