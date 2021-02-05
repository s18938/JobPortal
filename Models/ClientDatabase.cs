using System;
using System.Collections.Generic;

namespace JobPortal.Models
{
    public partial class ClientDatabase
    {
        public ClientDatabase()
        {
            Experience = new HashSet<Experience>();
            JobOffer = new HashSet<JobOffer>();
        }

        public int ClientDatabaseId { get; set; }
        public string ClientDatabaseName { get; set; }

        public virtual ICollection<Experience> Experience { get; set; }
        public virtual ICollection<JobOffer> JobOffer { get; set; }
    }
}
