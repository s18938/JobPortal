using System;
using System.Collections.Generic;

namespace JobPortal.Models
{
    public partial class Candidate
    {
        public Candidate()
        {
            Document = new HashSet<Document>();
            Experience = new HashSet<Experience>();
            JobOfferCandidate = new HashSet<JobOfferCandidate>();
        }

        public int CandidateId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public int? CityCityId { get; set; }

        public virtual City CityCity { get; set; }
        public virtual ICollection<Document> Document { get; set; }
        public virtual ICollection<Experience> Experience { get; set; }
        public virtual ICollection<JobOfferCandidate> JobOfferCandidate { get; set; }
    }
}
