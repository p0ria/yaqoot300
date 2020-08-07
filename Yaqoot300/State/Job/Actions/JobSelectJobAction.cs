using Yaqoot300.Interfaces;

namespace Yaqoot300.State.Job.Actions
{
    public class JobSelectJobAction : IAction
    {
        public JobSelectJobAction(int jobId)
        {
            this.Payload = jobId;
        }
        public string Type { get { return JobActionTypes.GET_JOBS_FAIL; } }
        public int Payload { get; set; }
    }
}