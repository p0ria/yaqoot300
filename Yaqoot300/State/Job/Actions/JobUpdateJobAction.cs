using Yaqoot300.Interfaces;

namespace Yaqoot300.State.Job.Actions
{
    public class JobUpdateJobAction : IAction
    {
        public JobUpdateJobAction(Models.Job job)
        {
            this.Payload = job;
        }
        public string Type { get { return JobActionTypes.UPDATE_JOB; } }
        public Models.Job Payload { get; set; }
    }
}