using System;
using System.Collections.Generic;

namespace ALYETL.ProdModels
{
    public partial class DbqdoctorSpeciality
    {
        public int Id { get; set; }
        public int DbqdoctorId { get; set; }
        public int DoctorSpecialityId { get; set; }
        public DateTime? CreatedOn { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public int? ModifiedBy { get; set; }
        public bool? IsActive { get; set; }

        public virtual AspNetUser Dbqdoctor { get; set; } = null!;
        public virtual DoctorSpeciality DoctorSpeciality { get; set; } = null!;
    }
}
