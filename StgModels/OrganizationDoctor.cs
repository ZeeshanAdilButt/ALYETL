using System;
using System.Collections.Generic;

namespace ALYETL.StgModels
{
    public partial class OrganizationDoctor
    {
        public int Id { get; set; }
        public int DoctorId { get; set; }
        public int OrganizationId { get; set; }
        public DateTime? CreatedOn { get; set; }
        public int? CreatedBy { get; set; }
        public bool? IsDeleted { get; set; }

        public virtual AspNetUser Doctor { get; set; } = null!;
        public virtual Organization Organization { get; set; } = null!;
    }
}
