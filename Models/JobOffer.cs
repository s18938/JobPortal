using System;
using System.Collections.Generic;

namespace JobPortal.Models
{
    public partial class JobOffer
    {
        public JobOffer()
        {
            JobOfferCandidate = new HashSet<JobOfferCandidate>();
            JobTypeJobOffer = new HashSet<JobTypeJobOffer>();
            Location = new HashSet<Location>();
        }

        public int JobOfferId { get; set; }
        public string Content { get; set; }
        public int? SalaryMax { get; set; }
        public int? SalaryMin { get; set; }
        public int? CommissonMin { get; set; }
        public string RecruitmentLink { get; set; }
        public int? CommissonMax { get; set; }
        public string SalesCycleLength { get; set; }
        public string Title { get; set; }
        public bool CompanyCar { get; set; }
        public int EmployerEmployerId { get; set; }
        public int ClientDatabaseClientDatabaseId { get; set; }
        public int IndustryIndustryId { get; set; }
        public int ClientTypeClientTypeId { get; set; }
        public int PositionPositionId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        public virtual ClientDatabase ClientDatabaseClientDatabase { get; set; }
        public virtual ClientType ClientTypeClientType { get; set; }
        public virtual Employer EmployerEmployer { get; set; }
        public virtual Industry IndustryIndustry { get; set; }
        public virtual Position PositionPosition { get; set; }
        public virtual ICollection<JobOfferCandidate> JobOfferCandidate { get; set; }
        public virtual ICollection<JobTypeJobOffer> JobTypeJobOffer { get; set; }
        public virtual ICollection<Location> Location { get; set; }
    }
}
