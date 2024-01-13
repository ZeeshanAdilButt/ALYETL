using System;
using System.Collections.Generic;

namespace ALYETL.StgModels
{
    public partial class OrganizationUser
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int OrganizationId { get; set; }
        public DateTime? CreatedOn { get; set; }
        public int? CreatedBy { get; set; }
        public bool? IsDeleted { get; set; }

        public virtual Organization Organization { get; set; } = null!;
        public virtual AspNetUser User { get; set; } = null!;
    }
}
