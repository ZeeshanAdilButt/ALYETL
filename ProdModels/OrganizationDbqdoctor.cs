using System;
using System.Collections.Generic;

namespace ALYETL.ProdModels
{
    public partial class OrganizationDbqdoctor
    {
        public int Id { get; set; }
        public int DbqdoctorId { get; set; }
        public int OrganizationId { get; set; }
        public DateTime? CreatedOn { get; set; }
        public int? CreatedBy { get; set; }
        public bool? IsDeleted { get; set; }

        public virtual AspNetUser Dbqdoctor { get; set; } = null!;
    }
}
