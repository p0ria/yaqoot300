using Yaqoot300.Interfaces;

namespace Yaqoot300.State.Job.Actions
{
    public class JobCreateJobSuccessAction : IAction
    {
        public JobCreateJobSuccessAction(Models.Job job)
        {
            this.Payload = job;
        }
        public string Type { get { return JobActionTypes.CREATE_JOB_SUCCESS; } }
        public Models.Job Payload { get; set; }
    }
}