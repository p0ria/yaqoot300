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
        public JobDialog()
        {
            InitializeComponent();
            this.Load += OnLoad;
            this.Store.StoreChanged += OnStoreChanged;
            this.btnCreate.BtnClicked += OnBtnCreateClicked;
            this.dgJobs.SelectionChanged += OnSelectionChanged;
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
                this.dgJobs.DataSource = null;
                this.dgJobs.DataSource = Store.Job.Jobs;
            });
        }

        private void SetSelectedJob()
        {
            
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
            this.btnCreate.Status = status;
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
