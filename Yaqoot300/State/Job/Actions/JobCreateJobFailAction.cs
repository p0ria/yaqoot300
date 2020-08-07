using Yaqoot300.Interfaces;

namespace Yaqoot300.State.Job.Actions
{
    public class JobCreateJobFailAction : IAction
    {
        public JobCreateJobFailAction(string error)
        {
            this.Payload = error;
        }
        public string Type { get { return JobActionTypes.CREATE_JOB_FAIL; } }
        public string Payload { get; set; }
    }
}