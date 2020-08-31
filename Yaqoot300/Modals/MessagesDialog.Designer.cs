namespace Yaqoot300.Modals
{
    partial class MessagesDialog
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
            Syncfusion.WinForms.DataGrid.GridImageColumn gridImageColumn1 = new Syncfusion.WinForms.DataGrid.GridImageColumn();
            Syncfusion.WinForms.DataGrid.GridDateTimeColumn gridDateTimeColumn1 = new Syncfusion.WinForms.DataGrid.GridDateTimeColumn();
            Syncfusion.WinForms.DataGrid.GridTextColumn gridTextColumn1 = new Syncfusion.WinForms.DataGrid.GridTextColumn();
            Syncfusion.WinForms.DataGrid.GridTextColumn gridTextColumn2 = new Syncfusion.WinForms.DataGrid.GridTextColumn();
            this.dgv = new Syncfusion.WinForms.DataGrid.SfDataGrid();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbApp = new System.Windows.Forms.CheckBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cbDatabase = new System.Windows.Forms.CheckBox();
            this.cbReaders = new System.Windows.Forms.CheckBox();
            this.cbPLC = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbInfo = new System.Windows.Forms.CheckBox();
            this.cbWarning = new System.Windows.Forms.CheckBox();
            this.cbError = new System.Windows.Forms.CheckBox();
            this.btnClear = new Syncfusion.WinForms.Controls.SfButton();
            this.tbInnerException = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv
            // 
            this.dgv.AccessibleName = "Table";
            this.dgv.AllowEditing = false;
            this.dgv.AllowGrouping = false;
            this.dgv.AllowSorting = false;
            gridImageColumn1.AllowEditing = false;
            gridImageColumn1.AllowGrouping = false;
            gridImageColumn1.AllowSorting = false;
            gridImageColumn1.CellStyle.Font.Size = 14F;
            gridImageColumn1.CellStyle.HorizontalAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            gridImageColumn1.HeaderStyle.FilterIconColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            gridImageColumn1.HeaderStyle.Font.Size = 14F;
            gridImageColumn1.HeaderText = "Severity";
            gridImageColumn1.MappingName = "Image";
            gridDateTimeColumn1.AllowEditing = false;
            gridDateTimeColumn1.AllowGrouping = false;
            gridDateTimeColumn1.AllowSorting = false;
            gridDateTimeColumn1.CellStyle.Font.Size = 14F;
            gridDateTimeColumn1.Format = "hh:mm:ss";
            gridDateTimeColumn1.HeaderStyle.FilterIconColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            gridDateTimeColumn1.HeaderStyle.Font.Size = 14F;
            gridDateTimeColumn1.HeaderText = "Time";
            gridDateTimeColumn1.MappingName = "Time";
            gridDateTimeColumn1.MaxDateTime = new System.DateTime(9999, 12, 31, 23, 59, 59, 999);
            gridTextColumn1.AllowEditing = false;
            gridTextColumn1.AllowGrouping = false;
            gridTextColumn1.AllowSorting = false;
            gridTextColumn1.AutoSizeColumnsMode = Syncfusion.WinForms.DataGrid.Enums.AutoSizeColumnsMode.Fill;
            gridTextColumn1.CellStyle.Font.Size = 14F;
            gridTextColumn1.HeaderStyle.FilterIconColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            gridTextColumn1.HeaderStyle.Font.Size = 14F;
            gridTextColumn1.HeaderText = "Message";
            gridTextColumn1.MappingName = "Message";
            gridTextColumn1.ShowToolTip = true;
            gridTextColumn2.AllowEditing = false;
            gridTextColumn2.AllowGrouping = false;
            gridTextColumn2.AllowSorting = false;
            gridTextColumn2.CellStyle.Font.Size = 14F;
            gridTextColumn2.CellStyle.HorizontalAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            gridTextColumn2.HeaderStyle.FilterIconColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            gridTextColumn2.HeaderStyle.Font.Size = 14F;
            gridTextColumn2.HeaderText = "Category";
            gridTextColumn2.MappingName = "Category";
            this.dgv.Columns.Add(gridImageColumn1);
            this.dgv.Columns.Add(gridDateTimeColumn1);
            this.dgv.Columns.Add(gridTextColumn1);
            this.dgv.Columns.Add(gridTextColumn2);
            this.dgv.Location = new System.Drawing.Point(34, 35);
            this.dgv.Name = "dgv";
            this.dgv.RowHeight = 40;
            this.dgv.Size = new System.Drawing.Size(794, 565);
            this.dgv.Style.HeaderStyle.FilterIconColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.dgv.TabIndex = 3;
            this.dgv.SelectionChanged += new Syncfusion.WinForms.DataGrid.Events.SelectionChangedEventHandler(this.dgv_SelectionChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbApp);
            this.groupBox1.Controls.Add(this.pictureBox3);
            this.groupBox1.Controls.Add(this.pictureBox2);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.cbDatabase);
            this.groupBox1.Controls.Add(this.cbReaders);
            this.groupBox1.Controls.Add(this.cbPLC);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(this.cbInfo);
            this.groupBox1.Controls.Add(this.cbWarning);
            this.groupBox1.Controls.Add(this.cbError);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.groupBox1.Location = new System.Drawing.Point(857, 35);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 417);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filters";
            // 
            // cbApp
            // 
            this.cbApp.AutoSize = true;
            this.cbApp.Checked = true;
            this.cbApp.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbApp.Location = new System.Drawing.Point(24, 222);
            this.cbApp.Name = "cbApp";
            this.cbApp.Size = new System.Drawing.Size(73, 29);
            this.cbApp.TabIndex = 10;
            this.cbApp.Text = "APP";
            this.cbApp.UseVisualStyleBackColor = true;
            this.cbApp.CheckedChanged += new System.EventHandler(this.cbCheckedChanged);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Yaqoot300.Properties.Resources.icon_info_32x32;
            this.pictureBox3.Location = new System.Drawing.Point(141, 139);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(32, 32);
            this.pictureBox3.TabIndex = 9;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Yaqoot300.Properties.Resources.icon_warning_32x32;
            this.pictureBox2.Location = new System.Drawing.Point(141, 95);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(32, 32);
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Yaqoot300.Properties.Resources.icon_error_32x32;
            this.pictureBox1.Location = new System.Drawing.Point(141, 51);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 32);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // cbDatabase
            // 
            this.cbDatabase.AutoSize = true;
            this.cbDatabase.Checked = true;
            this.cbDatabase.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbDatabase.Location = new System.Drawing.Point(24, 360);
            this.cbDatabase.Name = "cbDatabase";
            this.cbDatabase.Size = new System.Drawing.Size(123, 29);
            this.cbDatabase.TabIndex = 6;
            this.cbDatabase.Text = "Database";
            this.cbDatabase.UseVisualStyleBackColor = true;
            this.cbDatabase.CheckedChanged += new System.EventHandler(this.cbCheckedChanged);
            // 
            // cbReaders
            // 
            this.cbReaders.AutoSize = true;
            this.cbReaders.Checked = true;
            this.cbReaders.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbReaders.Location = new System.Drawing.Point(24, 314);
            this.cbReaders.Name = "cbReaders";
            this.cbReaders.Size = new System.Drawing.Size(112, 29);
            this.cbReaders.TabIndex = 5;
            this.cbReaders.Text = "Readers";
            this.cbReaders.UseVisualStyleBackColor = true;
            this.cbReaders.CheckedChanged += new System.EventHandler(this.cbCheckedChanged);
            // 
            // cbPLC
            // 
            this.cbPLC.AutoSize = true;
            this.cbPLC.Checked = true;
            this.cbPLC.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbPLC.Location = new System.Drawing.Point(24, 268);
            this.cbPLC.Name = "cbPLC";
            this.cbPLC.Size = new System.Drawing.Size(72, 29);
            this.cbPLC.TabIndex = 4;
            this.cbPLC.Text = "PLC";
            this.cbPLC.UseVisualStyleBackColor = true;
            this.cbPLC.CheckedChanged += new System.EventHandler(this.cbCheckedChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel1.Location = new System.Drawing.Point(6, 202);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(188, 1);
            this.panel1.TabIndex = 3;
            // 
            // cbInfo
            // 
            this.cbInfo.AutoSize = true;
            this.cbInfo.Checked = true;
            this.cbInfo.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbInfo.Location = new System.Drawing.Point(24, 140);
            this.cbInfo.Name = "cbInfo";
            this.cbInfo.Size = new System.Drawing.Size(66, 29);
            this.cbInfo.TabIndex = 2;
            this.cbInfo.Text = "Info";
            this.cbInfo.UseVisualStyleBackColor = true;
            this.cbInfo.CheckedChanged += new System.EventHandler(this.cbCheckedChanged);
            // 
            // cbWarning
            // 
            this.cbWarning.AutoSize = true;
            this.cbWarning.Checked = true;
            this.cbWarning.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbWarning.Location = new System.Drawing.Point(24, 99);
            this.cbWarning.Name = "cbWarning";
            this.cbWarning.Size = new System.Drawing.Size(111, 29);
            this.cbWarning.TabIndex = 1;
            this.cbWarning.Text = "Warning";
            this.cbWarning.UseVisualStyleBackColor = true;
            this.cbWarning.CheckedChanged += new System.EventHandler(this.cbCheckedChanged);
            // 
            // cbError
            // 
            this.cbError.AutoSize = true;
            this.cbError.Checked = true;
            this.cbError.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbError.Location = new System.Drawing.Point(24, 54);
            this.cbError.Name = "cbError";
            this.cbError.Size = new System.Drawing.Size(78, 29);
            this.cbError.TabIndex = 0;
            this.cbError.Text = "Error";
            this.cbError.UseVisualStyleBackColor = true;
            this.cbError.CheckedChanged += new System.EventHandler(this.cbCheckedChanged);
            // 
            // btnClear
            // 
            this.btnClear.AccessibleName = "Button";
            this.btnClear.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnClear.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.btnClear.Location = new System.Drawing.Point(857, 485);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(200, 47);
            this.btnClear.Style.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnClear.Style.Image = global::Yaqoot300.Properties.Resources.clear_16x16;
            this.btnClear.TabIndex = 6;
            this.btnClear.Text = "CLEAR MESSAGES";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // tbInnerException
            // 
            this.tbInnerException.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tbInnerException.Location = new System.Drawing.Point(34, 608);
            this.tbInnerException.Multiline = true;
            this.tbInnerException.Name = "tbInnerException";
            this.tbInnerException.Size = new System.Drawing.Size(794, 101);
            this.tbInnerException.TabIndex = 7;
            // 
            // MessagesDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 721);
            this.Controls.Add(this.tbInnerException);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgv);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "MessagesDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Messages";
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Syncfusion.WinForms.DataGrid.SfDataGrid dgv;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox cbInfo;
        private System.Windows.Forms.CheckBox cbWarning;
        private System.Windows.Forms.CheckBox cbError;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox cbDatabase;
        private System.Windows.Forms.CheckBox cbReaders;
        private System.Windows.Forms.CheckBox cbPLC;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.CheckBox cbApp;
        private Syncfusion.WinForms.Controls.SfButton btnClear;
        private System.Windows.Forms.TextBox tbInnerException;
    }
}