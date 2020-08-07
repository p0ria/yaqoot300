using Yaqoot300.Interfaces;

namespace Yaqoot300.State.Job.Actions
{
    public class JobCreateJobAction : IAction
    {
        public JobCreateJobAction(Models.Job job)
        {
            this.Payload = job;
        }
        public string Type { get { return JobActionTypes.CREATE_JOB; } }
        public Models.Job Payload { get; set; }
    }
}