namespace Yaqoot300.Controls
{
    partial class ManualActions
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
            this.btnLoadOS = new Yaqoot300.Controls.LoadingButtonControl();
            this.btnCycle = new Yaqoot300.Controls.LoadingButtonControl();
            this.btnFeedIn = new Yaqoot300.Controls.LoadingButtonControl();
            this.SuspendLayout();
            // 
            // btnLoadOS
            // 
            this.btnLoadOS.Label = "LOAD OS";
            this.btnLoadOS.Location = new System.Drawing.Point(3, 15);
            this.btnLoadOS.Name = "btnLoadOS";
            this.btnLoadOS.Size = new System.Drawing.Size(213, 70);
            this.btnLoadOS.Status = Yaqoot300.Controls.LoadingButtonControl.LoadingButtonControlStatus.Visible;
            this.btnLoadOS.TabIndex = 5;
            // 
            // btnCycle
            // 
            this.btnCycle.Label = "CYCLE";
            this.btnCycle.Location = new System.Drawing.Point(244, 15);
            this.btnCycle.Name = "btnCycle";
            this.btnCycle.Size = new System.Drawing.Size(213, 70);
            this.btnCycle.Status = Yaqoot300.Controls.LoadingButtonControl.LoadingButtonControlStatus.Visible;
            this.btnCycle.TabIndex = 4;
            // 
            // btnFeedIn
            // 
            this.btnFeedIn.Label = "FEED IN";
            this.btnFeedIn.Location = new System.Drawing.Point(484, 18);
            this.btnFeedIn.Name = "btnFeedIn";
            this.btnFeedIn.Size = new System.Drawing.Size(213, 70);
            this.btnFeedIn.Status = Yaqoot300.Controls.LoadingButtonControl.LoadingButtonControlStatus.Visible;
            this.btnFeedIn.TabIndex = 3;
            // 
            // ManualActions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.btnLoadOS);
            this.Controls.Add(this.btnCycle);
            this.Controls.Add(this.btnFeedIn);
            this.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.Name = "ManualActions";
            this.Size = new System.Drawing.Size(700, 100);
            this.ResumeLayout(false);

        }

        #endregion
        private LoadingButtonControl btnFeedIn;
        private LoadingButtonControl btnCycle;
        private LoadingButtonControl btnLoadOS;
    }
}
