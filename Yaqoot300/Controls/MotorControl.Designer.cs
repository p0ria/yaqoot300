namespace Yaqoot300.Controls
{
    partial class MotorControl
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
            this.pbMotor = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbMotor)).BeginInit();
            this.SuspendLayout();
            // 
            // pbMotor
            // 
            this.pbMotor.BackColor = System.Drawing.Color.Transparent;
            this.pbMotor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbMotor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbMotor.Enabled = false;
            this.pbMotor.Image = global::Yaqoot300.Properties.Resources.gear_128x128;
            this.pbMotor.Location = new System.Drawing.Point(0, 0);
            this.pbMotor.Name = "pbMotor";
            this.pbMotor.Size = new System.Drawing.Size(128, 128);
            this.pbMotor.TabIndex = 0;
            this.pbMotor.TabStop = false;
            // 
            // MotorControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.pbMotor);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Name = "MotorControl";
            this.Size = new System.Drawing.Size(128, 128);
            ((System.ComponentModel.ISupportInitialize)(this.pbMotor)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbMotor;
    }
}
