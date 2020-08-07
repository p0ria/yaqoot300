using Yaqoot300.Interfaces;

namespace Yaqoot300.State.Job.Actions
{
    public class JobUpdateJobSuccessAction : IAction
    {
        public JobUpdateJobSuccessAction(Models.Job job)
        {
            this.Payload = job;
        }
        public string Type { get { return JobActionTypes.UPDATE_JOB_SUCCESS; } }
        public Models.Job Payload { get; set; }
    }
}