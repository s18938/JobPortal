using System;
using System.Collections.Generic;

namespace JobPortal.Models
{
    public partial class Document
    {
        public int DocumentId { get; set; }
        public string Name { get; set; }
        public byte[] File { get; set; }
        public int CandidateCandidateId { get; set; }

        public virtual Candidate CandidateCandidate { get; set; }
    }
}
