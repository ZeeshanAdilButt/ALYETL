using System;
using System.Collections.Generic;

namespace ALYETL.ProdModels
{
    public partial class OrganizationShift
    {
        public int Id { get; set; }
        public string? ShiftName { get; set; }
        public string ShiftStartTime { get; set; } = null!;
        public int? OrganizationId { get; set; }
        public DateTime? CreatedOn { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public int? ModifiedBy { get; set; }
        public string ShiftEndTime { get; set; } = null!;

        public virtual AspNetUser? CreatedByNavigation { get; set; }
        public virtual AspNetUser? ModifiedByNavigation { get; set; }
        public virtual Organization? Organization { get; set; }
    }
}
