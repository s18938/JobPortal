using System;
using System.Collections.Generic;

namespace JobPortal.Models
{
    public partial class Position
    {
        public Position()
        {
            Experience = new HashSet<Experience>();
            JobOffer = new HashSet<JobOffer>();
        }

        public int PositionId { get; set; }
        public string PositionName { get; set; }

        public virtual ICollection<Experience> Experience { get; set; }
        public virtual ICollection<JobOffer> JobOffer { get; set; }
    }
}
