using System;
using System.Collections.Generic;

namespace JobPortal.Models
{
    public partial class Industry
    {
        public Industry()
        {
            Experience = new HashSet<Experience>();
            JobOffer = new HashSet<JobOffer>();
        }

        public int IndustryId { get; set; }
        public string IndustryName { get; set; }

        public virtual ICollection<Experience> Experience { get; set; }
        public virtual ICollection<JobOffer> JobOffer { get; set; }
    }
}
