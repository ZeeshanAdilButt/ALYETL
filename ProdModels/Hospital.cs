using System;
using System.Collections.Generic;

namespace ALYETL.ProdModels
{
    public partial class Hospital
    {
        public Hospital()
        {
            HospitalDoctors = new HashSet<HospitalDoctor>();
            HospitalPrograms = new HashSet<HospitalProgram>();
            HospitalTeams = new HashSet<HospitalTeam>();
            HospitalUsers = new HashSet<HospitalUser>();
        }

        public int Id { get; set; }
        public string HospitalName { get; set; } = null!;
        public string LogoPath { get; set; } = null!;
        public bool? IsActive { get; set; }
        public DateTime? CreatedOn { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public int? ModifiedBy { get; set; }
        public int? OrganizationId { get; set; }
        public bool? IsDeleted { get; set; }

        public virtual Organization? Organization { get; set; }
        public virtual ICollection<HospitalDoctor> HospitalDoctors { get; set; }
        public virtual ICollection<HospitalProgram> HospitalPrograms { get; set; }
        public virtual ICollection<HospitalTeam> HospitalTeams { get; set; }
        public virtual ICollection<HospitalUser> HospitalUsers { get; set; }
    }
}
