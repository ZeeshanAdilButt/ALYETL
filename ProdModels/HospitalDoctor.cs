using System;
using System.Collections.Generic;

namespace ALYETL.ProdModels
{
    public partial class HospitalDoctor
    {
        public int Id { get; set; }
        public int HospitalId { get; set; }
        public int DoctorId { get; set; }
        public DateTime? CreatedOn { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public int? ModifiedBy { get; set; }
        public bool? IsActive { get; set; }

        public virtual AspNetUser Doctor { get; set; } = null!;
        public virtual Hospital Hospital { get; set; } = null!;
    }
}
