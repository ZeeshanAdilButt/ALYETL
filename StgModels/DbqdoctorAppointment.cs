using System;
using System.Collections.Generic;

namespace ALYETL.StgModels
{
    public partial class DbqdoctorAppointment
    {
        public int Id { get; set; }
        public int DbqdoctorId { get; set; }
        public int DbqpatientId { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public int? StatusId { get; set; }
        public DateTime? CreatedOn { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public int? ModifiedBy { get; set; }
        public int DbqpatientInviteId { get; set; }

        public virtual AspNetUser Dbqdoctor { get; set; } = null!;
        public virtual AspNetUser Dbqpatient { get; set; } = null!;
        public virtual DbqpatientInvite DbqpatientInvite { get; set; } = null!;
    }
}
