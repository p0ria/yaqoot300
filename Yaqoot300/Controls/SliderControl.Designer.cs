namespace Yaqoot300.Controls
{
    partial class SliderControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblVal = new System.Windows.Forms.Label();
            this.slider = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.slider)).BeginInit();
            this.SuspendLayout();
            // 
            // lblVal
            // 
            this.lblVal.AutoSize = true;
            this.lblVal.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblVal.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblVal.Location = new System.Drawing.Point(165, 0);
            this.lblVal.Name = "lblVal";
            this.lblVal.Size = new System.Drawing.Size(27, 29);
            this.lblVal.TabIndex = 6;
            this.lblVal.Text = "0";
            // 
            // slider
            // 
            this.slider.LargeChange = 10;
            this.slider.Location = new System.Drawing.Point(0, 32);
            this.slider.Maximum = 30;
            this.slider.Name = "slider";
            this.slider.Size = new System.Drawing.Size(373, 45);
            this.slider.SmallChange = 2;
            this.slider.TabIndex = 5;
            this.slider.TickFrequency = 2;
            this.slider.Value = 30;
            this.slider.Scroll += new System.EventHandler(this.slider_Scroll);
            // 
            // SliderControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblVal);
            this.Controls.Add(this.slider);
            this.Name = "SliderControl";
            this.Size = new System.Drawing.Size(376, 80);
            ((System.ComponentModel.ISupportInitialize)(this.slider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblVal;
        private System.Windows.Forms.TrackBar slider;
    }
}
