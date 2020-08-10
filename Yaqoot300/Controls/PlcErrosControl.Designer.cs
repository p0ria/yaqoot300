namespace Yaqoot300.Controls
{
    partial class PlcErrosControl
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
            this.panelErrors = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // panelErrors
            // 
            this.panelErrors.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelErrors.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.panelErrors.Location = new System.Drawing.Point(0, 0);
            this.panelErrors.Name = "panelErrors";
            this.panelErrors.Size = new System.Drawing.Size(1230, 100);
            this.panelErrors.TabIndex = 2;
            // 
            // PlcErrosControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelErrors);
            this.Name = "PlcErrosControl";
            this.Size = new System.Drawing.Size(1230, 100);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel panelErrors;
    }
}
