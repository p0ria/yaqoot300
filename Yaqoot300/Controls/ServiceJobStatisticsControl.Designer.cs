namespace Yaqoot300.Controls
{
    partial class ServiceJobStatisticsControl
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbSelectedJobId = new System.Windows.Forms.Label();
            this.lbJobId = new System.Windows.Forms.Label();
            this.lbSelectedJobPercent = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbSelectedJobTotal = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 200);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Job";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbSelectedJobTotal);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.lbSelectedJobPercent);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.lbSelectedJobId);
            this.panel1.Controls.Add(this.lbJobId);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.panel1.Location = new System.Drawing.Point(3, 18);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(194, 179);
            this.panel1.TabIndex = 0;
            // 
            // lbSelectedJobId
            // 
            this.lbSelectedJobId.AutoSize = true;
            this.lbSelectedJobId.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lbSelectedJobId.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbSelectedJobId.Location = new System.Drawing.Point(82, 26);
            this.lbSelectedJobId.Name = "lbSelectedJobId";
            this.lbSelectedJobId.Size = new System.Drawing.Size(86, 24);
            this.lbSelectedJobId.TabIndex = 15;
            this.lbSelectedJobId.Text = "Job #321";
            // 
            // lbJobId
            // 
            this.lbJobId.AutoSize = true;
            this.lbJobId.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lbJobId.Location = new System.Drawing.Point(14, 26);
            this.lbJobId.Name = "lbJobId";
            this.lbJobId.Size = new System.Drawing.Size(35, 25);
            this.lbJobId.TabIndex = 14;
            this.lbJobId.Text = "Id:";
            // 
            // lbSelectedJobPercent
            // 
            this.lbSelectedJobPercent.AutoSize = true;
            this.lbSelectedJobPercent.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lbSelectedJobPercent.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbSelectedJobPercent.Location = new System.Drawing.Point(128, 120);
            this.lbSelectedJobPercent.Name = "lbSelectedJobPercent";
            this.lbSelectedJobPercent.Size = new System.Drawing.Size(40, 24);
            this.lbSelectedJobPercent.TabIndex = 17;
            this.lbSelectedJobPercent.Text = "0 %";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.Location = new System.Drawing.Point(14, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 25);
            this.label2.TabIndex = 16;
            this.label2.Text = "Percent:";
            // 
            // lbSelectedJobTotal
            // 
            this.lbSelectedJobTotal.AutoSize = true;
            this.lbSelectedJobTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lbSelectedJobTotal.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbSelectedJobTotal.Location = new System.Drawing.Point(138, 76);
            this.lbSelectedJobTotal.Name = "lbSelectedJobTotal";
            this.lbSelectedJobTotal.Size = new System.Drawing.Size(30, 24);
            this.lbSelectedJobTotal.TabIndex = 19;
            this.lbSelectedJobTotal.Text = "30";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label3.Location = new System.Drawing.Point(14, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 25);
            this.label3.TabIndex = 18;
            this.label3.Text = "Total:";
            // 
            // ServiceJobStatisticsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Name = "ServiceJobStatisticsControl";
            this.Size = new System.Drawing.Size(200, 200);
            this.groupBox1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbSelectedJobTotal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbSelectedJobPercent;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbSelectedJobId;
        private System.Windows.Forms.Label lbJobId;
    }
}
