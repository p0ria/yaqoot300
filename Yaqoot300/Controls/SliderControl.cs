using System;
using System.CodeDom;
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
    public partial class SliderControl : UserControl
    {
        private int _prevValue;

        public event EventHandler<int> ValueChanged; 

        public SliderControl()
        {
            InitializeComponent();
        }

        public int Min
        {
            get { return slider.Minimum; }
            set
            {
                this.slider.Minimum = value;
            }
        }

        public int Max
        {
            get { return slider.Maximum; }
            set
            {
                this.slider.Maximum = value;
            }
        }

        public int Value
        {
            get { return this.slider.Value; }
            set
            {
                this.slider.Value = value;
                UpdateSliderValue();
            }
        }

        public int TickFrequency
        {
            get { return slider.TickFrequency; }
            set
            {
                this.slider.TickFrequency = value;
                this.slider.SmallChange = value;
                this.slider.LargeChange = value;
            }
        }

        private void slider_Scroll(object sender, EventArgs e)
        {
            this.UpdateSliderValue();
            RaiseValueChangedEvent(this.Value);
        }

        private void UpdateSliderValue()
        {
            int remaining = slider.Value % slider.TickFrequency;
            if (remaining != 0)
            {
                if (_prevValue < slider.Value)
                {
                    slider.Value = slider.Value + remaining;
                }
                else
                {
                    slider.Value = slider.Value - remaining;
                }
            }
            _prevValue = slider.Value;
            lblVal.Text = slider.Value.ToString();
        }

        private void RaiseValueChangedEvent(int value)
        {
            this.ValueChanged?.Invoke(this, value);
        }
    }
}
