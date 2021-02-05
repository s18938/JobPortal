using System;
using System.Collections.Generic;

namespace JobPortal.Models
{
    public partial class City
    {
        public City()
        {
            Candidate = new HashSet<Candidate>();
            LocationNavigation = new HashSet<Location>();
        }

        public int CityId { get; set; }
        public string CityName { get; set; }
        public string Location { get; set; }

        public virtual ICollection<Candidate> Candidate { get; set; }
        public virtual ICollection<Location> LocationNavigation { get; set; }
    }
}
