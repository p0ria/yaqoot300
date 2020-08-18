namespace Yaqoot300.Controls
{
    partial class ServiceSettingsControl
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
            this.btnSave = new Yaqoot300.Controls.LoadingButtonControl();
            this.label9 = new System.Windows.Forms.Label();
            this.scM4Speed = new Yaqoot300.Controls.SliderControl();
            this.label8 = new System.Windows.Forms.Label();
            this.scM3StepLength = new Yaqoot300.Controls.SliderControl();
            this.label7 = new System.Windows.Forms.Label();
            this.scFeedInSteps = new Yaqoot300.Controls.SliderControl();
            this.label6 = new System.Windows.Forms.Label();
            this.scActiveReaders = new Yaqoot300.Controls.SliderControl();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Label = "SAVE";
            this.btnSave.Location = new System.Drawing.Point(352, 375);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(213, 75);
            this.btnSave.Status = Yaqoot300.Controls.LoadingButtonControl.LoadingButtonControlStatus.Invisible;
            this.btnSave.TabIndex = 36;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(16, 322);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(118, 25);
            this.label9.TabIndex = 35;
            this.label9.Text = "M4 Speed";
            // 
            // scM4Speed
            // 
            this.scM4Speed.Location = new System.Drawing.Point(189, 301);
            this.scM4Speed.Max = 4;
            this.scM4Speed.Min = 1;
            this.scM4Speed.Name = "scM4Speed";
            this.scM4Speed.Size = new System.Drawing.Size(376, 80);
            this.scM4Speed.TabIndex = 34;
            this.scM4Speed.TickFrequency = 1;
            this.scM4Speed.Value = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(16, 227);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(178, 25);
            this.label8.TabIndex = 33;
            this.label8.Text = "M3 Step Length";
            // 
            // scM3StepLength
            // 
            this.scM3StepLength.Location = new System.Drawing.Point(189, 205);
            this.scM3StepLength.Max = 7;
            this.scM3StepLength.Min = 1;
            this.scM3StepLength.Name = "scM3StepLength";
            this.scM3StepLength.Size = new System.Drawing.Size(376, 80);
            this.scM3StepLength.TabIndex = 32;
            this.scM3StepLength.TickFrequency = 1;
            this.scM3StepLength.Value = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(16, 132);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(158, 25);
            this.label7.TabIndex = 31;
            this.label7.Text = "Feed In Steps";
            // 
            // scFeedInSteps
            // 
            this.scFeedInSteps.Location = new System.Drawing.Point(189, 109);
            this.scFeedInSteps.Max = 10;
            this.scFeedInSteps.Min = 1;
            this.scFeedInSteps.Name = "scFeedInSteps";
            this.scFeedInSteps.Size = new System.Drawing.Size(376, 80);
            this.scFeedInSteps.TabIndex = 30;
            this.scFeedInSteps.TickFrequency = 1;
            this.scFeedInSteps.Value = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(16, 37);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(172, 25);
            this.label6.TabIndex = 29;
            this.label6.Text = "Active Readers";
            // 
            // scActiveReaders
            // 
            this.scActiveReaders.Location = new System.Drawing.Point(189, 13);
            this.scActiveReaders.Max = 30;
            this.scActiveReaders.Min = 0;
            this.scActiveReaders.Name = "scActiveReaders";
            this.scActiveReaders.Size = new System.Drawing.Size(376, 80);
            this.scActiveReaders.TabIndex = 28;
            this.scActiveReaders.TickFrequency = 2;
            this.scActiveReaders.Value = 30;
            // 
            // ServiceSettingsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.scM4Speed);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.scM3StepLength);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.scFeedInSteps);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.scActiveReaders);
            this.Name = "ServiceSettingsControl";
            this.Size = new System.Drawing.Size(580, 462);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private LoadingButtonControl btnSave;
        private System.Windows.Forms.Label label9;
        private SliderControl scM4Speed;
        private System.Windows.Forms.Label label8;
        private SliderControl scM3StepLength;
        private System.Windows.Forms.Label label7;
        private SliderControl scFeedInSteps;
        private System.Windows.Forms.Label label6;
        private SliderControl scActiveReaders;
    }
}
