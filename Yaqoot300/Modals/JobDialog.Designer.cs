namespace Yaqoot300.Modals
{
    partial class JobDialog
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Syncfusion.WinForms.DataGrid.GridTextColumn gridTextColumn5 = new Syncfusion.WinForms.DataGrid.GridTextColumn();
            Syncfusion.WinForms.DataGrid.GridTextColumn gridTextColumn6 = new Syncfusion.WinForms.DataGrid.GridTextColumn();
            Syncfusion.WinForms.DataGrid.GridTextColumn gridTextColumn7 = new Syncfusion.WinForms.DataGrid.GridTextColumn();
            Syncfusion.WinForms.DataGrid.GridTextColumn gridTextColumn8 = new Syncfusion.WinForms.DataGrid.GridTextColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tbGood = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.tbTotal = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.tbLotNumber = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgv = new Syncfusion.WinForms.DataGrid.SfDataGrid();
            this.btnCreate = new Yaqoot300.Controls.LoadingButtonControl();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbGood)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbTotal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.groupBox1.Location = new System.Drawing.Point(710, 36);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(342, 792);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Create Job";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnCreate);
            this.panel1.Controls.Add(this.tbGood);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.tbTotal);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.tbLotNumber);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.panel1.Location = new System.Drawing.Point(3, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(336, 762);
            this.panel1.TabIndex = 0;
            // 
            // tbGood
            // 
            this.tbGood.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.tbGood.Location = new System.Drawing.Point(23, 270);
            this.tbGood.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.tbGood.Name = "tbGood";
            this.tbGood.Size = new System.Drawing.Size(147, 29);
            this.tbGood.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label3.Location = new System.Drawing.Point(20, 243);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 24);
            this.label3.TabIndex = 5;
            this.label3.Text = "Good";
            // 
            // tbTotal
            // 
            this.tbTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.tbTotal.Location = new System.Drawing.Point(23, 179);
            this.tbTotal.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.tbTotal.Name = "tbTotal";
            this.tbTotal.Size = new System.Drawing.Size(147, 29);
            this.tbTotal.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.Location = new System.Drawing.Point(19, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Total";
            // 
            // tbLotNumber
            // 
            this.tbLotNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.tbLotNumber.Location = new System.Drawing.Point(23, 88);
            this.tbLotNumber.Name = "tbLotNumber";
            this.tbLotNumber.Size = new System.Drawing.Size(286, 29);
            this.tbLotNumber.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.Location = new System.Drawing.Point(19, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "LOT Number";
            // 
            // dgv
            // 
            this.dgv.AccessibleName = "Table";
            this.dgv.AllowGrouping = false;
            this.dgv.AllowSorting = false;
            gridTextColumn5.AllowEditing = false;
            gridTextColumn5.AllowGrouping = false;
            gridTextColumn5.AllowSorting = false;
            gridTextColumn5.CellStyle.Font.Size = 14F;
            gridTextColumn5.HeaderStyle.FilterIconColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            gridTextColumn5.HeaderStyle.Font.Size = 14F;
            gridTextColumn5.HeaderText = "JobId";
            gridTextColumn5.MappingName = "JobId";
            gridTextColumn5.Visible = false;
            gridTextColumn6.AllowGrouping = false;
            gridTextColumn6.AllowSorting = false;
            gridTextColumn6.AutoSizeColumnsMode = Syncfusion.WinForms.DataGrid.Enums.AutoSizeColumnsMode.Fill;
            gridTextColumn6.CellStyle.Font.Size = 14F;
            gridTextColumn6.HeaderStyle.FilterIconColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            gridTextColumn6.HeaderStyle.Font.Size = 14F;
            gridTextColumn6.HeaderText = "LOT Number";
            gridTextColumn6.MappingName = "LotNumber";
            gridTextColumn7.AllowGrouping = false;
            gridTextColumn7.AllowSorting = false;
            gridTextColumn7.CellStyle.Font.Size = 14F;
            gridTextColumn7.HeaderStyle.FilterIconColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            gridTextColumn7.HeaderStyle.Font.Size = 14F;
            gridTextColumn7.HeaderText = "Total";
            gridTextColumn7.MappingName = "Total";
            gridTextColumn8.AllowGrouping = false;
            gridTextColumn8.AllowSorting = false;
            gridTextColumn8.CellStyle.Font.Size = 14F;
            gridTextColumn8.HeaderStyle.FilterIconColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            gridTextColumn8.HeaderStyle.Font.Size = 14F;
            gridTextColumn8.HeaderText = "Good";
            gridTextColumn8.MappingName = "Good";
            this.dgv.Columns.Add(gridTextColumn5);
            this.dgv.Columns.Add(gridTextColumn6);
            this.dgv.Columns.Add(gridTextColumn7);
            this.dgv.Columns.Add(gridTextColumn8);
            this.dgv.Location = new System.Drawing.Point(26, 36);
            this.dgv.Name = "dgv";
            this.dgv.RowHeight = 40;
            this.dgv.Size = new System.Drawing.Size(647, 789);
            this.dgv.Style.HeaderStyle.FilterIconColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.dgv.TabIndex = 2;
            this.dgv.Text = "sfDataGrid1";
            this.dgv.CurrentCellEndEdit += new Syncfusion.WinForms.DataGrid.Events.CurrentCellEndEditEventHandler(this.dgv_CurrentCellEndEdit);
            // 
            // btnCreate
            // 
            this.btnCreate.Label = "Create";
            this.btnCreate.Location = new System.Drawing.Point(106, 631);
            this.btnCreate.Margin = new System.Windows.Forms.Padding(6);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(213, 63);
            this.btnCreate.Status = Yaqoot300.Controls.LoadingButtonControl.LoadingButtonControlStatus.Visible;
            this.btnCreate.TabIndex = 7;
            // 
            // JobDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 861);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "JobDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Select Job";
            this.groupBox1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbGood)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbTotal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.NumericUpDown tbGood;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown tbTotal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbLotNumber;
        private System.Windows.Forms.Label label1;
        private Controls.LoadingButtonControl btnCreate;
        private Syncfusion.WinForms.DataGrid.SfDataGrid dgv;
    }
}