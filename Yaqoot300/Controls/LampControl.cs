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

namespace Yaqoot300.Controls
{
    public partial class LampControl : UserControl
    {
        public enum LampControlType
        {
            Red, Green, Yellow
        }

        public enum LampControlStatus
        {
            Off, On
        }

        private LampControlType _type;
        private LampControlStatus _status;
        private Image _image;
       

        public LampControl()
        {
            InitializeComponent();
        }

        public LampControlType Type
        {
            get { return _type; }
            set
            {
                _type = value;
                switch (value)
                {
                    case LampControlType.Red:
                        this._image = ServiceProvider.ImageList64.Images[2];
                        break;
                    case LampControlType.Green:
                        this._image = ServiceProvider.ImageList64.Images[3];
                        break;
                    case LampControlType.Yellow:
                        this._image = ServiceProvider.ImageList64.Images[4];
                        break;
                }
            }
        }
        

        public LampControlStatus Status
        {
            get { return _status; }
            set
            {
                _status = value;
                this.pbLamp.Image = (value == LampControlStatus.Off) ? ServiceProvider.ImageList64.Images[1] : _image;
            }
        }
    }
}
