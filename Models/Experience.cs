using System;
using System.Collections.Generic;

namespace JobPortal.Models
{
    public partial class Experience
    {
        public int ExperienceId { get; set; }
        public string CompanyName { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public int CandidateCandidateId { get; set; }
        public int ClientDatabaseClientDatabaseId { get; set; }
        public int IndustryIndustryId { get; set; }
        public int ClientTypeClientTypeId { get; set; }
        public int PositionPositionId { get; set; }

        public virtual Candidate CandidateCandidate { get; set; }
        public virtual ClientDatabase ClientDatabaseClientDatabase { get; set; }
        public virtual ClientType ClientTypeClientType { get; set; }
        public virtual Industry IndustryIndustry { get; set; }
        public virtual Position PositionPosition { get; set; }
    }
}
