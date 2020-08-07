using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Yaqoot300.Commons;
using Yaqoot300.Interfaces;
using Yaqoot300.State.Job.Actions;
using Yaqoot300.State.Job.State;

namespace Yaqoot300.State.Job
{
    public class JobReducer: IReducer<JobState>
    {
        public void Reduce(JobState state, IAction action)
        {
            switch (action.Type)
            {
                case JobActionTypes.GET_JOBS:
                    Task.Run(() =>
                    {
                        Thread.Sleep(1000);
                        var jobs = new List<Models.Job>
                        {
                            new Models.Job {JobId = 1, LotNumber = "LOT 1", Total = 5000, Good = 4900},
                            new Models.Job {JobId = 2, LotNumber = "LOT 2", Total = 6000, Good = 5900},
                            new Models.Job {JobId = 3, LotNumber = "LOT 3", Total = 9000, Good = 8900},
                            new Models.Job {JobId = 4, LotNumber = "LOT 4", Total = 4000, Good = 3900}
                        };
                        ServiceProvider.Store.Dispatch(new JobGetJobsSuccessAction(jobs));
                    });
                    break;
                case JobActionTypes.GET_JOBS_SUCCESS:
                    var getJobsSuccessPayload = ((JobGetJobsSuccessAction)action).Payload;
                    state.Jobs = getJobsSuccessPayload;
                    state.SelectedJob = null;
                    break;
                case JobActionTypes.GET_JOBS_FAIL:
                    MessageBox.Show("GET JOBS FAILED");
                    break;
                case JobActionTypes.SELECT_JOB:
                    var selectJobPayload = ((JobSelectJobAction)action).Payload;
                    var selectedJob = state.Jobs.Find(j => j.JobId == selectJobPayload);
                    state.SelectedJob = selectedJob;
                    break;
                case JobActionTypes.CREATE_JOB:
                    var createJobPayload = ((JobCreateJobAction)action).Payload;
                    Task.Run(() =>
                    {
                        Thread.Sleep(2000);
                        createJobPayload.JobId = state.Jobs.Count + 1;
                        ServiceProvider.Store.Dispatch(new JobCreateJobSuccessAction(createJobPayload));
                    });
                    break;
                case JobActionTypes.CREATE_JOB_SUCCESS:
                    var createJobSuccessPayload = ((JobCreateJobSuccessAction)action).Payload;
                    state.Jobs.Insert(0, createJobSuccessPayload);
                    break;
                case JobActionTypes.CREATE_JOB_FAIL:
                    MessageBox.Show("CREATE JOB FAILED");
                    break;
            }
        }
    }
}
