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
using Yaqoot300.Commons;
using Yaqoot300.Controls;
using Yaqoot300.Models;
using Yaqoot300.State;
using Yaqoot300.State.Job.Actions;

namespace Yaqoot300.Modals
{
    public partial class JobDialog : Form
    {
        private Job _selectedJob;
        private List<Job> ds;
        public JobDialog()
        {
            InitializeComponent();
            this.Load += OnLoad;
            this.Store.StoreChanged += OnStoreChanged;
            this.btnCreate.BtnClicked += OnBtnCreateClicked;
            this.dgJobs.SelectionChanged += OnSelectionChanged;
            ds = new List<Job>();
            this.dgJobs.DataSource = ds;
        }

        private void OnSelectionChanged(object sender, EventArgs eventArgs)
        {
            if (this.dgJobs.SelectedRows.Count == 0) _selectedJob = null;
            else _selectedJob = this.dgJobs.SelectedRows[0].DataBoundItem as Job;
        }

        public Job SelectedJob
        {
            get { return _selectedJob; }
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
            }
        }

        private Store Store => ServiceProvider.Store;

        private void SetJobs()
        {
            this.SafeInvoke(() =>
            {
                ds.Clear();
                ds.AddRange(Store.Job.Jobs);
                dgJobs.Refresh();
                dgJobs.Invalidate(true);
                Invalidate(true);
            });
        }

        private void SetSelectedJob()
        {
            this.SafeInvoke(() =>
            {
                if (Store.Job.SelectedJob == null)
                {
                    ResetSelection();
                    return;
                }
                DataGridViewRow selectedRow = null;
                foreach (DataGridViewRow row in dgJobs.Rows)
                {
                    Job job = row.DataBoundItem as Job;
                    if (job.JobId == Store.Job.SelectedJob.JobId)
                    {
                        selectedRow = row;
                        break;
                    }
                }
                if (selectedRow != null)
                {
                    dgJobs.CurrentCell = selectedRow.Cells[1];
                }
                else
                {
                    ResetSelection();
                    return;
                }
            });
        }

        private void ResetSelection()
        {
            if(this.dgJobs.Rows.Count > 0)
                this.dgJobs.CurrentCell = this.dgJobs.Rows[0].Cells[1];
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
    }
}
