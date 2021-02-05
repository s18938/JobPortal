using System;
using System.Collections.Generic;

namespace JobPortal.Models
{
    public partial class Employer
    {
        public Employer()
        {
            JobOffer = new HashSet<JobOffer>();
        }

        public int EmployerId { get; set; }
        public string Name { get; set; }
        public byte[] Logo { get; set; }
        public string Email { get; set; }
        public int? EmployeesNumber { get; set; }
        public string Page { get; set; }

        public virtual ICollection<JobOffer> JobOffer { get; set; }
    }
}
