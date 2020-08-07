using System.Collections.Generic;
using Yaqoot300.Interfaces;

namespace Yaqoot300.State.Job.Actions
{
    public class JobGetJobsSuccessAction : IAction
    {
        public JobGetJobsSuccessAction(List<Models.Job> jobs)
        {
            this.Payload = jobs;
        }
        public string Type { get { return JobActionTypes.GET_JOBS_SUCCESS; } }
        public List<Models.Job> Payload { get; set; }
    }
}