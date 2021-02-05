using System;
using System.Collections.Generic;

namespace JobPortal.Models
{
    public partial class JobType
    {
        public JobType()
        {
            JobTypeJobOffer = new HashSet<JobTypeJobOffer>();
        }

        public int JobTypeId { get; set; }
        public string JobTypeName { get; set; }

        public virtual ICollection<JobTypeJobOffer> JobTypeJobOffer { get; set; }
    }
}
