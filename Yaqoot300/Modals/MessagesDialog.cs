using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
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
        public event EventHandler Cleared; 
        
        public MessagesDialog()
        {
            InitializeComponent();
            InitializeDataGrid();
            this.Load += OnLoad;
        }

        private void OnLoad(object sender, EventArgs eventArgs)
        {
            this.InvalidateUI();
        }

        private void InitializeDataGrid()
        {
            this.dgv.Style.CurrentCellStyle.BackColor = this.dgv.Style.SelectionStyle.BackColor;
            this.dgv.Style.CurrentCellStyle.BorderThickness = GridBorderWeight.ExtraThin;
            this.dgv.Style.CurrentCellStyle.BorderColor = Color.FromArgb(0, 0, 0, 0);
        }

        public List<MessagesService.Item> Messages { get; set; }

        public void InvalidateUI()
        {
            this.SafeInvoke(() =>
            {
                var selectedSeverities = new List<MessagesService.Severity>();
                var selectedCategories = new List<MessageCategory>();

                if (cbError.Checked) selectedSeverities.Add(MessagesService.Severity.Error);
                if (cbWarning.Checked) selectedSeverities.Add(MessagesService.Severity.Warning);
                if (cbInfo.Checked) selectedSeverities.Add(MessagesService.Severity.Info);


                if (cbApp.Checked) selectedCategories.Add(MessageCategory.App);
                if (cbPLC.Checked) selectedCategories.Add(MessageCategory.PLC);
                if (cbReaders.Checked) selectedCategories.Add(MessageCategory.Reader);
                if (cbDatabase.Checked) selectedCategories.Add(MessageCategory.Database);

                var ds = Messages
                    .Where(m => selectedSeverities.Contains(m.Severity) && selectedCategories.Contains(m.Category))
                    .Select(m => new
                    {
                        Time = m.Time,
                        Image = m.Severity == MessagesService.Severity.Error
                            ? IBA.Icon_Error_32x32
                            : m.Severity == MessagesService.Severity.Warning
                                ? IBA.Icon_Warning_32x32
                                : IBA.Icon_Info_32x32,
                        Message = m.Message,
                        Category = m.Category,
                        InnerException = m.InnerException
                    });
                dgv.DataSource = null;
                if (ds.Any()) this.dgv.DataSource = ds;
            });
        }


        private void cbCheckedChanged(object sender, EventArgs e)
        {
            InvalidateUI();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            RaiseCleared();
        }

        private void RaiseCleared()
        {
            this.Cleared?.Invoke(this, null);
        }

        private void dgv_SelectionChanged(object sender, Syncfusion.WinForms.DataGrid.Events.SelectionChangedEventArgs e)
        {
            var selectedItem = dgv.SelectedItem as dynamic;
            if (selectedItem != null && selectedItem.InnerException != null)
            {
                this.tbInnerException.Text = selectedItem.InnerException.ToString();
            }
            else
            {
                this.tbInnerException.Text = String.Empty;
            }
        }
    }
}
