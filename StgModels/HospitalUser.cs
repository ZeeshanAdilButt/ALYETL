using System;
using System.Collections.Generic;

namespace ALYETL.StgModels
{
    public partial class HospitalUser
    {
        public int Id { get; set; }
        public int HospitalId { get; set; }
        public int UserId { get; set; }
        public DateTime? CreatedOn { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public int? ModifiedBy { get; set; }
        public bool? IsActive { get; set; }
        public bool? IsDeleted { get; set; }

        public virtual Hospital Hospital { get; set; } = null!;
        public virtual AspNetUser User { get; set; } = null!;
    }
}
