using Yaqoot300.Interfaces;

namespace Yaqoot300.State.Job.Actions
{
    public class JobUpdateJobFailAction : IAction
    {
        public JobUpdateJobFailAction(Models.Job job)
        {
            this.Payload = job;
        }
        public string Type { get { return JobActionTypes.UPDATE_JOB_FAIL; } }
        public Models.Job Payload { get; set; }
    }
}