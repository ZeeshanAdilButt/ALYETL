using System;
using System.Collections.Generic;

namespace ALYETL.StgModels
{
    public partial class OrganizationDbqpatient
    {
        public int Id { get; set; }
        public int DbqpatientId { get; set; }
        public int OrganizationId { get; set; }
        public DateTime? CreatedOn { get; set; }
        public int? CreatedBy { get; set; }
        public bool? IsDeleted { get; set; }

        public virtual AspNetUser Dbqpatient { get; set; } = null!;
    }
}
