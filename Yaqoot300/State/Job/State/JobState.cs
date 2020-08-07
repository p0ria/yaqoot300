using System.Collections.Generic;
using Yaqoot300.Models;

namespace Yaqoot300.State.Job.State
{
    public class JobState
    {
        public JobState()
        {
            this.Jobs = new List<Models.Job>();
        }
        public List<Models.Job> Jobs { get; set; }
        public int?  SelectedJobId { get; set; }

        public Models.Job SelectedJob => this.SelectedJobId != null ? this.Jobs.Find(j => j.JobId == SelectedJobId) : null;
    }

}