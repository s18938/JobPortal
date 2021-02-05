using System;
using System.Collections.Generic;

namespace JobPortal.Models
{
    public partial class ClientType
    {
        public ClientType()
        {
            Experience = new HashSet<Experience>();
            JobOffer = new HashSet<JobOffer>();
        }

        public int ClientTypeId { get; set; }
        public string ClientTypeName { get; set; }

        public virtual ICollection<Experience> Experience { get; set; }
        public virtual ICollection<JobOffer> JobOffer { get; set; }
    }
}
