using System;
using System.Collections.Generic;

namespace ALYETL.StgModels
{
    public partial class DbqdoctorAvailability
    {
        public int Id { get; set; }
        public int DbqdoctorId { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public TimeSpan? StartTime { get; set; }
        public TimeSpan? EndTime { get; set; }
        public DateTime? CreatedOn { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public int? ModifiedBy { get; set; }

        public virtual AspNetUser Dbqdoctor { get; set; } = null!;
    }
}
