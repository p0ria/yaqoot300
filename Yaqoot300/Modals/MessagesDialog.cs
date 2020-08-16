using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Syncfusion.WinForms.DataGrid.Styles;
using Yaqoot300.Commons;
using Yaqoot300.Interfaces;
using Yaqoot300.Properties;

namespace Yaqoot300.Modals
{
    public partial class MessagesDialog : Form
    {
        enum Severity
        {
            Error, Warning, Info
        }
        class Item
        {
            public DateTime Time { get; set; }
            public Severity Severity { get; set; }
            public string Message { get; set; }
            public MessageCategory Category { get; set; }
        }

        private List<Item> _messages = new List<Item>();
        public MessagesDialog()
        {
            InitializeComponent();
            InitializeDataGrid();
        }

        public void Error(string message, MessageCategory category)
        {
            AddMessage(Severity.Error, message, category);
        }

        public void Warning(string message, MessageCategory category)
        {
            AddMessage(Severity.Warning, message, category);
        }

        public void Info(string message, MessageCategory category)
        {
            AddMessage(Severity.Info, message, category);
        }

        private void AddMessage(Severity severity, string message, MessageCategory category)
        {
            if(_messages.Count >= Constants.MESSAGES_MAX) _messages.RemoveAt(0);
            this._messages.Add(new Item
            {
                Time = DateTime.Now,
                Severity = severity,
                Message = message,
                Category = category
            });
            InvalidateDS();
        }

        private void InitializeDataGrid()
        {
            this.dgv.Style.CurrentCellStyle.BackColor = this.dgv.Style.SelectionStyle.BackColor;
            this.dgv.Style.CurrentCellStyle.BorderThickness = GridBorderWeight.ExtraThin;
            this.dgv.Style.CurrentCellStyle.BorderColor = Color.FromArgb(0, 0, 0, 0);
        }

        private void InvalidateDS()
        {
            List<Severity> selectedSeverities = new List<Severity>();
            if(cbError.Checked) selectedSeverities.Add(Severity.Error);
            if(cbWarning.Checked) selectedSeverities.Add(Severity.Warning);
            if (cbInfo.Checked) selectedSeverities.Add(Severity.Info);

            List<MessageCategory> selectedCategories = new List<MessageCategory>();
            if(cbApp.Checked) selectedCategories.Add(MessageCategory.App);
            if(cbPLC.Checked) selectedCategories.Add(MessageCategory.PLC);
            if(cbReaders.Checked) selectedCategories.Add(MessageCategory.Reader);
            if(cbDatabase.Checked) selectedCategories.Add(MessageCategory.Database);

            var ds = _messages
                .Where(m => selectedSeverities.Contains(m.Severity) && selectedCategories.Contains(m.Category))
                .Select(m => new
                {
                    Time = m.Time,
                    Image = m.Severity == Severity.Error
                        ? IBA.Icon_Error_32x32
                        : m.Severity == Severity.Warning
                            ? IBA.Icon_Warning_32x32
                            : IBA.Icon_Info_32x32,
                    Message = m.Message,
                    Category = m.Category
                });
            this.SafeInvoke(() =>
            {
                dgv.DataSource = null;
                if (ds.Any()) this.dgv.DataSource = ds;

            });
        }

        private void cbCheckedChanged(object sender, EventArgs e)
        {
            InvalidateDS();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            this._messages.Clear();
            InvalidateDS();
        }
    }
}
