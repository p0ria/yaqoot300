namespace Yaqoot300.Controls
{
    partial class ErrorControl
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
            this.btnError = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnError
            // 
            this.btnError.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnError.Location = new System.Drawing.Point(0, 0);
            this.btnError.Name = "btnError";
            this.btnError.Size = new System.Drawing.Size(70, 70);
            this.btnError.TabIndex = 2;
            this.btnError.UseVisualStyleBackColor = true;
            this.btnError.Click += new System.EventHandler(this.btnError_Click);
            // 
            // ErrorControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.btnError);
            this.Name = "ErrorControl";
            this.Size = new System.Drawing.Size(70, 70);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnError;
    }
}
