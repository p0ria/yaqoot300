using Yaqoot300.Interfaces;

namespace Yaqoot300.State.Job.Actions
{
    public class JobGetJobsAction : IAction
    {
        public string Type { get { return JobActionTypes.GET_JOBS; } }
    }
}