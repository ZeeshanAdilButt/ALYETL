using System;
using System.Collections.Generic;

namespace ALYETL.StgModels
{
    public partial class Claim
    {
        public Claim()
        {
            ApplicationClaimUserTypes = new HashSet<ApplicationClaimUserType>();
            AspNetRoleClaims = new HashSet<AspNetRoleClaim>();
        }

        public int Id { get; set; }
        public string? ClaimCode { get; set; }
        public string? UiclaimValue { get; set; }
        public string? ClaimValue { get; set; }
        public bool IsDeleted { get; set; }
        public bool IsDisplay { get; set; }
        public int ClaimGroupId { get; set; }
        public DateTime CreatedOn { get; set; }
        public int? CreatedBy { get; set; }
        public DateTimeOffset? ModifiedOn { get; set; }
        public long? ModifiedBy { get; set; }

        public virtual ClaimGroup ClaimGroup { get; set; } = null!;
        public virtual ICollection<ApplicationClaimUserType> ApplicationClaimUserTypes { get; set; }
        public virtual ICollection<AspNetRoleClaim> AspNetRoleClaims { get; set; }
    }
}
