using System;
using System.Collections.Generic;

namespace ALYETL.ProdModels
{
    public partial class DbqpatientInvite
    {
        public DbqpatientInvite()
        {
            DbqdoctorAppointments = new HashSet<DbqdoctorAppointment>();
        }

        public int Id { get; set; }
        public int DbqpatientId { get; set; }
        public int DoctorSpecialityId { get; set; }
        public bool IsConfirmedByPatient { get; set; }
        public DateTime? CreatedOn { get; set; }
        public int? CreatedBy { get; set; }

        public virtual AspNetUser Dbqpatient { get; set; } = null!;
        public virtual DoctorSpeciality DoctorSpeciality { get; set; } = null!;
        public virtual ICollection<DbqdoctorAppointment> DbqdoctorAppointments { get; set; }
    }
}
