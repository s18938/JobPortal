using System;
using System.Collections.Generic;

namespace JobPortal.Models
{
    public partial class JobOfferCandidate
    {
        public int JobOfferCandidateId { get; set; }
        public int JobOfferJobOfferId { get; set; }
        public int CandidateCandidateId { get; set; }
        public DateTime AddDate { get; set; }

        public virtual Candidate CandidateCandidate { get; set; }
        public virtual JobOffer JobOfferJobOffer { get; set; }
    }
}
