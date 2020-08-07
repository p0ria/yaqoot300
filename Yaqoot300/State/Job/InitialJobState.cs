using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Yaqoot300.State.Job.State;

namespace Yaqoot300.State.Job
{
    public static class InitialJobState
    {
        private static readonly JobState _instance = new JobState
        {
            Jobs = new List<Models.Job>(),
            SelectedJobId = null
        };

        public static JobState Instance => _instance;
    }
}
