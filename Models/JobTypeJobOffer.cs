using System;
using System.Collections.Generic;

namespace JobPortal.Models
{
    public partial class JobTypeJobOffer
    {
        public int JobTypeJobOfferId { get; set; }
        public int JobTypeJobTypeId { get; set; }
        public int JobOfferJobOfferId { get; set; }

        public virtual JobOffer JobOfferJobOffer { get; set; }
        public virtual JobType JobTypeJobType { get; set; }
    }
}
