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
            this.btnOsLoad = new System.Windows.Forms.Button();
            this.btnCycle = new System.Windows.Forms.Button();
            this.btnFeedIn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnOsLoad
            // 
            this.btnOsLoad.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnOsLoad.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOsLoad.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnOsLoad.Location = new System.Drawing.Point(0, 13);
            this.btnOsLoad.Name = "btnOsLoad";
            this.btnOsLoad.Size = new System.Drawing.Size(200, 100);
            this.btnOsLoad.TabIndex = 1;
            this.btnOsLoad.Text = "Load OS";
            this.btnOsLoad.UseVisualStyleBackColor = false;
            // 
            // btnCycle
            // 
            this.btnCycle.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnCycle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCycle.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnCycle.Location = new System.Drawing.Point(250, 13);
            this.btnCycle.Name = "btnCycle";
            this.btnCycle.Size = new System.Drawing.Size(200, 100);
            this.btnCycle.TabIndex = 2;
            this.btnCycle.Text = "Cycle";
            this.btnCycle.UseVisualStyleBackColor = false;
            // 
            // btnFeedIn
            // 
            this.btnFeedIn.BackColor = System.Drawing.Color.BurlyWood;
            this.btnFeedIn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFeedIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnFeedIn.Location = new System.Drawing.Point(500, 13);
            this.btnFeedIn.Name = "btnFeedIn";
            this.btnFeedIn.Size = new System.Drawing.Size(200, 100);
            this.btnFeedIn.TabIndex = 3;
            this.btnFeedIn.Text = "Feed In";
            this.btnFeedIn.UseVisualStyleBackColor = false;
            // 
            // ManualActions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.btnFeedIn);
            this.Controls.Add(this.btnCycle);
            this.Controls.Add(this.btnOsLoad);
            this.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.Name = "ManualActions";
            this.Size = new System.Drawing.Size(700, 130);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOsLoad;
        private System.Windows.Forms.Button btnCycle;
        private System.Windows.Forms.Button btnFeedIn;
    }
}
