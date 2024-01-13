using System;
using System.Collections.Generic;

namespace ALYETL.StgModels
{
    public partial class ClaimGroup
    {
        public ClaimGroup()
        {
            Claims = new HashSet<Claim>();
        }

        public int Id { get; set; }
        public string? Name { get; set; }
        public bool IsDisplay { get; set; }
        public DateTime CreatedOn { get; set; }
        public int? CreatedBy { get; set; }
        public DateTimeOffset? ModifiedOn { get; set; }
        public long? ModifiedBy { get; set; }
        public bool IsDeleted { get; set; }

        public virtual ICollection<Claim> Claims { get; set; }
    }
}
