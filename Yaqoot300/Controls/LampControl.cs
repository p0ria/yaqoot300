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
                        this._image = Resources.red_circle_64x64;
                        break;
                    case LampControlType.Green:
                        this._image = Resources.green_circle_64x64;
                        break;
                    case LampControlType.Yellow:
                        this._image = Resources.yellow_circle_64x64;
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
                this.pbLamp.Image = (value == LampControlStatus.Off) ? Resources.gray_circle_64x64 : _image;
            }
        }
    }
}
