using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yaqoot300.Models
{
    [Serializable]
    public class Job
    {
        public int? JobId { get; set; }
        public string LotNumber { get; set; }
        public int Total { get; set; }
        public int Good { get; set; }

        public override bool Equals(object obj)
        {
            Job other = obj as Job;
     
            // If parameter is null, return false.
            if (Object.ReferenceEquals(other, null))
            {
                return false;
            }

            // Optimization for a common success case.
            if (Object.ReferenceEquals(this, other))
            {
                return true;
            }

            // If run-time types are not exactly the same, return false.
            if (this.GetType() != other.GetType())
            {
                return false;
            }

            return this.JobId == other.JobId;
        }

        public override int GetHashCode()
        {
            int id = this.JobId ?? 0;
            return 0x00010000 + id;
        }
    }
}
