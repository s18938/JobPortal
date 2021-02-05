using System;
using System.Collections.Generic;

namespace JobPortal.Models
{
    public partial class Location
    {
        public int LocationId { get; set; }
        public string Location1 { get; set; }
        public int JobOfferJobOfferId { get; set; }
        public int CityCityId { get; set; }

        public virtual City CityCity { get; set; }
        public virtual JobOffer JobOfferJobOffer { get; set; }
    }
}
