using Yaqoot300.Interfaces;

namespace Yaqoot300.Pages
{
    partial class HomePage
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
            this.gpReaders = new System.Windows.Forms.GroupBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.homeReadersControl1 = new Yaqoot300.Controls.HomeReadersControl();
            this.gbReaders = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblChipsPercentValue = new System.Windows.Forms.Label();
            this.lblChipsPercent = new System.Windows.Forms.Label();
            this.lblChipsFailedValue = new System.Windows.Forms.Label();
            this.lblChipsFailed = new System.Windows.Forms.Label();
            this.lblChipsGoodValue = new System.Windows.Forms.Label();
            this.lblChipsGood = new System.Windows.Forms.Label();
            this.lblChipsTotalValue = new System.Windows.Forms.Label();
            this.lblChipsTotal = new System.Windows.Forms.Label();
            this.lblChipsDoneValue = new System.Windows.Forms.Label();
            this.lblChipsDone = new System.Windows.Forms.Label();
            this.lblJobValue = new System.Windows.Forms.Label();
            this.lblJob = new System.Windows.Forms.Label();
            this.gpConnectionsStatus = new System.Windows.Forms.GroupBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.connectionsControl1 = new Yaqoot300.Controls.ConnectionsControl();
            this.panelActions = new System.Windows.Forms.Panel();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.btnMessages = new System.Windows.Forms.Button();
            this.lampCtrlYellow = new Yaqoot300.Controls.LampControl();
            this.lampCtrlGreen = new Yaqoot300.Controls.LampControl();
            this.lampCtrlRed = new Yaqoot300.Controls.LampControl();
            this.lblMode = new System.Windows.Forms.Label();
            this.btnSelectJob = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.plcErrosControl1 = new Yaqoot300.Controls.PlcErrosControl();
            this.gpReaders.SuspendLayout();
            this.panel3.SuspendLayout();
            this.gbReaders.SuspendLayout();
            this.panel1.SuspendLayout();
            this.gpConnectionsStatus.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panelHeader.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpReaders
            // 
            this.gpReaders.Controls.Add(this.panel3);
            this.gpReaders.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.gpReaders.Location = new System.Drawing.Point(131, 317);
            this.gpReaders.Name = "gpReaders";
            this.gpReaders.Size = new System.Drawing.Size(1209, 318);
            this.gpReaders.TabIndex = 4;
            this.gpReaders.TabStop = false;
            this.gpReaders.Text = "Readers";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.homeReadersControl1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.panel3.Location = new System.Drawing.Point(3, 27);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1203, 288);
            this.panel3.TabIndex = 0;
            // 
            // homeReadersControl1
            // 
            this.homeReadersControl1.Location = new System.Drawing.Point(1, 0);
            this.homeReadersControl1.Name = "homeReadersControl1";
            this.homeReadersControl1.Size = new System.Drawing.Size(1205, 288);
            this.homeReadersControl1.TabIndex = 0;
            // 
            // gbReaders
            // 
            this.gbReaders.Controls.Add(this.panel1);
            this.gbReaders.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.gbReaders.Location = new System.Drawing.Point(132, 136);
            this.gbReaders.Name = "gbReaders";
            this.gbReaders.Size = new System.Drawing.Size(568, 161);
            this.gbReaders.TabIndex = 5;
            this.gbReaders.TabStop = false;
            this.gbReaders.Text = "Statistics";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.lblChipsPercentValue);
            this.panel1.Controls.Add(this.lblChipsPercent);
            this.panel1.Controls.Add(this.lblChipsFailedValue);
            this.panel1.Controls.Add(this.lblChipsFailed);
            this.panel1.Controls.Add(this.lblChipsGoodValue);
            this.panel1.Controls.Add(this.lblChipsGood);
            this.panel1.Controls.Add(this.lblChipsTotalValue);
            this.panel1.Controls.Add(this.lblChipsTotal);
            this.panel1.Controls.Add(this.lblChipsDoneValue);
            this.panel1.Controls.Add(this.lblChipsDone);
            this.panel1.Controls.Add(this.lblJobValue);
            this.panel1.Controls.Add(this.lblJob);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.panel1.Location = new System.Drawing.Point(3, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(562, 131);
            this.panel1.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label7.Location = new System.Drawing.Point(439, 53);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(116, 24);
            this.label7.TabIndex = 25;
            this.label7.Text = "2000 chips/h";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label6.Location = new System.Drawing.Point(320, 53);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 24);
            this.label6.TabIndex = 24;
            this.label6.Text = "Throughput:";
            // 
            // lblChipsPercentValue
            // 
            this.lblChipsPercentValue.AutoSize = true;
            this.lblChipsPercentValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblChipsPercentValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblChipsPercentValue.Location = new System.Drawing.Point(439, 94);
            this.lblChipsPercentValue.Name = "lblChipsPercentValue";
            this.lblChipsPercentValue.Size = new System.Drawing.Size(45, 24);
            this.lblChipsPercentValue.TabIndex = 23;
            this.lblChipsPercentValue.Text = "95%";
            // 
            // lblChipsPercent
            // 
            this.lblChipsPercent.AutoSize = true;
            this.lblChipsPercent.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblChipsPercent.Location = new System.Drawing.Point(320, 94);
            this.lblChipsPercent.Name = "lblChipsPercent";
            this.lblChipsPercent.Size = new System.Drawing.Size(80, 24);
            this.lblChipsPercent.TabIndex = 22;
            this.lblChipsPercent.Text = "Percent:";
            // 
            // lblChipsFailedValue
            // 
            this.lblChipsFailedValue.AutoSize = true;
            this.lblChipsFailedValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblChipsFailedValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblChipsFailedValue.Location = new System.Drawing.Point(244, 94);
            this.lblChipsFailedValue.Name = "lblChipsFailedValue";
            this.lblChipsFailedValue.Size = new System.Drawing.Size(40, 24);
            this.lblChipsFailedValue.TabIndex = 21;
            this.lblChipsFailedValue.Text = "100";
            // 
            // lblChipsFailed
            // 
            this.lblChipsFailed.AutoSize = true;
            this.lblChipsFailed.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblChipsFailed.Location = new System.Drawing.Point(181, 94);
            this.lblChipsFailed.Name = "lblChipsFailed";
            this.lblChipsFailed.Size = new System.Drawing.Size(67, 24);
            this.lblChipsFailed.TabIndex = 20;
            this.lblChipsFailed.Text = "Failed:";
            // 
            // lblChipsGoodValue
            // 
            this.lblChipsGoodValue.AutoSize = true;
            this.lblChipsGoodValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblChipsGoodValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblChipsGoodValue.Location = new System.Drawing.Point(88, 94);
            this.lblChipsGoodValue.Name = "lblChipsGoodValue";
            this.lblChipsGoodValue.Size = new System.Drawing.Size(50, 24);
            this.lblChipsGoodValue.TabIndex = 19;
            this.lblChipsGoodValue.Text = "3400";
            // 
            // lblChipsGood
            // 
            this.lblChipsGood.AutoSize = true;
            this.lblChipsGood.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblChipsGood.Location = new System.Drawing.Point(22, 94);
            this.lblChipsGood.Name = "lblChipsGood";
            this.lblChipsGood.Size = new System.Drawing.Size(62, 24);
            this.lblChipsGood.TabIndex = 18;
            this.lblChipsGood.Text = "Good:";
            // 
            // lblChipsTotalValue
            // 
            this.lblChipsTotalValue.AutoSize = true;
            this.lblChipsTotalValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblChipsTotalValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblChipsTotalValue.Location = new System.Drawing.Point(244, 53);
            this.lblChipsTotalValue.Name = "lblChipsTotalValue";
            this.lblChipsTotalValue.Size = new System.Drawing.Size(50, 24);
            this.lblChipsTotalValue.TabIndex = 17;
            this.lblChipsTotalValue.Text = "5000";
            // 
            // lblChipsTotal
            // 
            this.lblChipsTotal.AutoSize = true;
            this.lblChipsTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblChipsTotal.Location = new System.Drawing.Point(181, 53);
            this.lblChipsTotal.Name = "lblChipsTotal";
            this.lblChipsTotal.Size = new System.Drawing.Size(56, 24);
            this.lblChipsTotal.TabIndex = 16;
            this.lblChipsTotal.Text = "Total:";
            // 
            // lblChipsDoneValue
            // 
            this.lblChipsDoneValue.AutoSize = true;
            this.lblChipsDoneValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblChipsDoneValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblChipsDoneValue.Location = new System.Drawing.Point(89, 53);
            this.lblChipsDoneValue.Name = "lblChipsDoneValue";
            this.lblChipsDoneValue.Size = new System.Drawing.Size(50, 24);
            this.lblChipsDoneValue.TabIndex = 15;
            this.lblChipsDoneValue.Text = "3500";
            // 
            // lblChipsDone
            // 
            this.lblChipsDone.AutoSize = true;
            this.lblChipsDone.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblChipsDone.Location = new System.Drawing.Point(22, 53);
            this.lblChipsDone.Name = "lblChipsDone";
            this.lblChipsDone.Size = new System.Drawing.Size(61, 24);
            this.lblChipsDone.TabIndex = 14;
            this.lblChipsDone.Text = "Done:";
            // 
            // lblJobValue
            // 
            this.lblJobValue.AutoSize = true;
            this.lblJobValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblJobValue.ForeColor = System.Drawing.Color.Cyan;
            this.lblJobValue.Location = new System.Drawing.Point(80, 10);
            this.lblJobValue.Name = "lblJobValue";
            this.lblJobValue.Size = new System.Drawing.Size(101, 25);
            this.lblJobValue.TabIndex = 13;
            this.lblJobValue.Text = "Job #321";
            // 
            // lblJob
            // 
            this.lblJob.AutoSize = true;
            this.lblJob.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblJob.Location = new System.Drawing.Point(21, 10);
            this.lblJob.Name = "lblJob";
            this.lblJob.Size = new System.Drawing.Size(53, 25);
            this.lblJob.TabIndex = 12;
            this.lblJob.Text = "Job:";
            // 
            // gpConnectionsStatus
            // 
            this.gpConnectionsStatus.Controls.Add(this.panel2);
            this.gpConnectionsStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.gpConnectionsStatus.Location = new System.Drawing.Point(732, 136);
            this.gpConnectionsStatus.Name = "gpConnectionsStatus";
            this.gpConnectionsStatus.Size = new System.Drawing.Size(608, 161);
            this.gpConnectionsStatus.TabIndex = 6;
            this.gpConnectionsStatus.TabStop = false;
            this.gpConnectionsStatus.Text = "Connections";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.connectionsControl1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.panel2.Location = new System.Drawing.Point(3, 27);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(602, 131);
            this.panel2.TabIndex = 3;
            // 
            // connectionsControl1
            // 
            this.connectionsControl1.Location = new System.Drawing.Point(0, 0);
            this.connectionsControl1.Name = "connectionsControl1";
            this.connectionsControl1.Size = new System.Drawing.Size(602, 131);
            this.connectionsControl1.TabIndex = 0;
            // 
            // panelActions
            // 
            this.panelActions.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panelActions.Location = new System.Drawing.Point(381, 648);
            this.panelActions.Name = "panelActions";
            this.panelActions.Size = new System.Drawing.Size(700, 100);
            this.panelActions.TabIndex = 7;
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panelHeader.Controls.Add(this.btnMessages);
            this.panelHeader.Controls.Add(this.lampCtrlYellow);
            this.panelHeader.Controls.Add(this.lampCtrlGreen);
            this.panelHeader.Controls.Add(this.lampCtrlRed);
            this.panelHeader.Controls.Add(this.lblMode);
            this.panelHeader.Controls.Add(this.btnSelectJob);
            this.panelHeader.Location = new System.Drawing.Point(112, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(1254, 105);
            this.panelHeader.TabIndex = 9;
            // 
            // btnMessages
            // 
            this.btnMessages.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMessages.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnMessages.Location = new System.Drawing.Point(240, 32);
            this.btnMessages.Name = "btnMessages";
            this.btnMessages.Size = new System.Drawing.Size(179, 46);
            this.btnMessages.TabIndex = 15;
            this.btnMessages.Text = "Messages";
            this.btnMessages.UseVisualStyleBackColor = true;
            this.btnMessages.Click += new System.EventHandler(this.btnMessages_Click);
            // 
            // lampCtrlYellow
            // 
            this.lampCtrlYellow.BackColor = System.Drawing.Color.Transparent;
            this.lampCtrlYellow.Location = new System.Drawing.Point(1153, 13);
            this.lampCtrlYellow.Name = "lampCtrlYellow";
            this.lampCtrlYellow.Size = new System.Drawing.Size(75, 75);
            this.lampCtrlYellow.Status = Yaqoot300.Controls.LampControl.LampControlStatus.Off;
            this.lampCtrlYellow.TabIndex = 14;
            this.lampCtrlYellow.Type = Yaqoot300.Controls.LampControl.LampControlType.Red;
            // 
            // lampCtrlGreen
            // 
            this.lampCtrlGreen.BackColor = System.Drawing.Color.Transparent;
            this.lampCtrlGreen.Location = new System.Drawing.Point(1080, 13);
            this.lampCtrlGreen.Name = "lampCtrlGreen";
            this.lampCtrlGreen.Size = new System.Drawing.Size(75, 75);
            this.lampCtrlGreen.Status = Yaqoot300.Controls.LampControl.LampControlStatus.Off;
            this.lampCtrlGreen.TabIndex = 13;
            this.lampCtrlGreen.Type = Yaqoot300.Controls.LampControl.LampControlType.Red;
            // 
            // lampCtrlRed
            // 
            this.lampCtrlRed.BackColor = System.Drawing.Color.Transparent;
            this.lampCtrlRed.Location = new System.Drawing.Point(1008, 13);
            this.lampCtrlRed.Name = "lampCtrlRed";
            this.lampCtrlRed.Size = new System.Drawing.Size(75, 75);
            this.lampCtrlRed.Status = Yaqoot300.Controls.LampControl.LampControlStatus.Off;
            this.lampCtrlRed.TabIndex = 12;
            this.lampCtrlRed.Type = Yaqoot300.Controls.LampControl.LampControlType.Red;
            // 
            // lblMode
            // 
            this.lblMode.AutoSize = true;
            this.lblMode.Font = new System.Drawing.Font("Baskerville Old Face", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMode.Location = new System.Drawing.Point(523, 21);
            this.lblMode.Name = "lblMode";
            this.lblMode.Size = new System.Drawing.Size(168, 54);
            this.lblMode.TabIndex = 11;
            this.lblMode.Text = "AUTO";
            // 
            // btnSelectJob
            // 
            this.btnSelectJob.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSelectJob.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnSelectJob.Location = new System.Drawing.Point(35, 32);
            this.btnSelectJob.Name = "btnSelectJob";
            this.btnSelectJob.Size = new System.Drawing.Size(179, 46);
            this.btnSelectJob.TabIndex = 10;
            this.btnSelectJob.Text = "Select Job";
            this.btnSelectJob.UseVisualStyleBackColor = true;
            this.btnSelectJob.Click += new System.EventHandler(this.btnSelectJob_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel4.Controls.Add(this.plcErrosControl1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(114, 768);
            this.panel4.TabIndex = 10;
            // 
            // plcErrosControl1
            // 
            this.plcErrosControl1.Location = new System.Drawing.Point(4, 14);
            this.plcErrosControl1.Name = "plcErrosControl1";
            this.plcErrosControl1.Size = new System.Drawing.Size(85, 741);
            this.plcErrosControl1.TabIndex = 0;
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.panelActions);
            this.Controls.Add(this.gpConnectionsStatus);
            this.Controls.Add(this.gbReaders);
            this.Controls.Add(this.gpReaders);
            this.Name = "HomePage";
            this.Size = new System.Drawing.Size(1366, 768);
            this.gpReaders.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.gbReaders.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.gpConnectionsStatus.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpReaders;
        private System.Windows.Forms.GroupBox gbReaders;
        private System.Windows.Forms.GroupBox gpConnectionsStatus;
        private System.Windows.Forms.Panel panelActions;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Button btnSelectJob;
        private System.Windows.Forms.Label lblMode;
        private Controls.LampControl lampCtrlYellow;
        private Controls.LampControl lampCtrlGreen;
        private Controls.LampControl lampCtrlRed;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblChipsPercentValue;
        private System.Windows.Forms.Label lblChipsPercent;
        private System.Windows.Forms.Label lblChipsFailedValue;
        private System.Windows.Forms.Label lblChipsFailed;
        private System.Windows.Forms.Label lblChipsGoodValue;
        private System.Windows.Forms.Label lblChipsGood;
        private System.Windows.Forms.Label lblChipsTotalValue;
        private System.Windows.Forms.Label lblChipsTotal;
        private System.Windows.Forms.Label lblChipsDoneValue;
        private System.Windows.Forms.Label lblChipsDone;
        private System.Windows.Forms.Label lblJobValue;
        private System.Windows.Forms.Label lblJob;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnMessages;
        private System.Windows.Forms.Panel panel2;
        private Controls.ConnectionsControl connectionsControl1;
        private System.Windows.Forms.Panel panel4;
        private Controls.PlcErrosControl plcErrosControl1;
        private System.Windows.Forms.Panel panel3;
        private Controls.HomeReadersControl homeReadersControl1;
    }
}
