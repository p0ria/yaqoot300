using Yaqoot300.Interfaces;

namespace Yaqoot300.State.Job.Actions
{
    public class JobGetJobsFailsAction : IAction
    {
        public JobGetJobsFailsAction(string error)
        {
            this.Payload = error;
        }
        public string Type { get { return JobActionTypes.GET_JOBS_FAIL; } }
        public string Payload { get; set; }
    }
}