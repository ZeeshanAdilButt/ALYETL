using System;
using System.Collections.Generic;

namespace ALYETL.ProdModels
{
    public partial class DoctorSpeciality
    {
        public DoctorSpeciality()
        {
            DbqdoctorSpecialities = new HashSet<DbqdoctorSpeciality>();
            DbqpatientInvites = new HashSet<DbqpatientInvite>();
        }

        public int Id { get; set; }
        public string Speciality { get; set; } = null!;

        public virtual ICollection<DbqdoctorSpeciality> DbqdoctorSpecialities { get; set; }
        public virtual ICollection<DbqpatientInvite> DbqpatientInvites { get; set; }
    }
}
