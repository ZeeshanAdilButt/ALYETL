using System;
using System.Collections.Generic;

namespace ALYETL.StgModels
{
    public partial class ConsultFormTimeline
    {
        public int Id { get; set; }
        public int ConsultFormId { get; set; }
        public int? ActionUserId { get; set; }
        public int TimelineActionType { get; set; }
        public DateTime? CreatedOn { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public int? ModifiedBy { get; set; }
        public bool? IsActive { get; set; }
        public int? PauseReasonType { get; set; }
        public string? PausedReason { get; set; }

        public virtual AspNetUser? ActionUser { get; set; }
        public virtual ConsultForm ConsultForm { get; set; } = null!;
    }
}
