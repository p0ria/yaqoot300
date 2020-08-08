using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using log4net.Appender;
using Syncfusion.WinForms.DataGrid.Events;
using Syncfusion.WinForms.DataGrid.Styles;
using Yaqoot300.Commons;
using Yaqoot300.Controls;
using Yaqoot300.Models;
using Yaqoot300.State;
using Yaqoot300.State.Job.Actions;

namespace Yaqoot300.Modals
{
    public partial class JobsDialog : Form
    {
        private int? _selectedJobId;
        public JobsDialog()
        {
            InitializeComponent();
            InitializeDataGrid();
            this.Load += OnLoad;
            this.Store.StoreChanged += OnStoreChanged;
            this.btnCreate.BtnClicked += OnBtnCreateClicked;
        }

        private void InitializeDataGrid()
        {
            this.dgv.Style.CurrentCellStyle.BackColor = this.dgv.Style.SelectionStyle.BackColor;
            this.dgv.Style.CurrentCellStyle.BorderThickness = GridBorderWeight.ExtraThin;
            this.dgv.Style.CurrentCellStyle.BorderColor = Color.FromArgb(0, 0, 0, 0);
            this.dgv.SelectionChanged += OnSelectionChanged;
        }

        private void OnSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            SelectedJobId = (e.AddedItems[0] as Job)?.JobId;
        }


        public int? SelectedJobId
        {
            get { return _selectedJobId; }
            private set { _selectedJobId = value; }
        }

        private void OnLoad(object sender, EventArgs eventArgs)
        {
            Store.Dispatch(new JobGetJobsAction());
        }

        private void OnStoreChanged(object sender, string changeType)
        {
            switch (changeType)
            {
                case null:
                    SetJobs();
                    SetSelectedJob();
                    break;
                case JobActionTypes.GET_JOBS_SUCCESS:
                    SetJobs();
                    SetSelectedJob();
                    break;
                case JobActionTypes.SELECT_JOB:
                    SetSelectedJob();
                    break;
                case JobActionTypes.CREATE_JOB_SUCCESS:
                    ResetFields();
                    ChangeBtnCreateStatus(LoadingButtonControl.LoadingButtonControlStatus.Visible);
                    SetJobs();
                    break;
                case JobActionTypes.CREATE_JOB_FAIL:
                    ChangeBtnCreateStatus(LoadingButtonControl.LoadingButtonControlStatus.Visible);
                    break;
                case JobActionTypes.UPDATE_JOB_FAIL:
                    SetJobs();
                    SetSelectedJob();
                    break;
            }
        }

        private Store Store => ServiceProvider.Store;

        private void SetJobs()
        {
            this.SafeInvoke(() =>
            {
                this.dgv.DataSource = null;
                this.dgv.DataSource = Store.Job.Jobs.Select(j => j.DeepClone());
            });
        }

        private void SetSelectedJob()
        {
            ChangeSelection(Store.Job.SelectedJobId);
        }

        private void ChangeSelection(int? selectedJobId = null)
        {
            this.SafeInvoke(() =>
            {
                if (selectedJobId != null)
                {
                    var ds = (this.dgv.DataSource as IEnumerable<Job>).ToList();
                    var selectedJob = ds.Find(j => j.JobId == selectedJobId);
                    this.dgv.SelectedItems.Clear();
                    this.dgv.SelectedItems.Add(selectedJob);
                }
                else
                {
                    this.dgv.ClearSelection();
                }
                SelectedJobId = selectedJobId;
            });
        }

        private void OnBtnCreateClicked(object sender, EventArgs eventArgs)
        {
            ChangeBtnCreateStatus(LoadingButtonControl.LoadingButtonControlStatus.Loading);
            Store.Dispatch(new JobCreateJobAction(new Job
            {
                LotNumber = tbLotNumber.Text,
                Total = int.Parse(tbTotal.Text),
                Good = int.Parse(tbGood.Text)
            }));
        }

        private void ChangeBtnCreateStatus(LoadingButtonControl.LoadingButtonControlStatus status)
        {
            this.SafeInvoke(() =>
            {
                this.btnCreate.Status = status;
            });  
        }

        private void ResetFields()
        {
            this.SafeInvoke(() =>
            {
                this.tbLotNumber.Clear();
                this.tbTotal.ResetText();
                this.tbGood.ResetText();

            });
        }

        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);
            Store.StoreChanged -= OnStoreChanged;
        }

        private void dgv_CurrentCellEndEdit(object sender, Syncfusion.WinForms.DataGrid.Events.CurrentCellEndEditEventArgs e)
        {
            Job job = e.DataRow.RowData as Job;
            Store.Dispatch(new JobUpdateJobAction(job));
        }
    }
}
