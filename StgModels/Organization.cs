using System;
using System.Collections.Generic;

namespace ALYETL.StgModels
{
    public partial class Organization
    {
        public Organization()
        {
            EventCalendars = new HashSet<EventCalendar>();
            Hospitals = new HashSet<Hospital>();
            OrganizationDoctors = new HashSet<OrganizationDoctor>();
            OrganizationShifts = new HashSet<OrganizationShift>();
            OrganizationUsers = new HashSet<OrganizationUser>();
        }

        public int Id { get; set; }
        public int UserId { get; set; }
        public string OrganizationName { get; set; } = null!;
        public DateTime? CreatedOn { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public int? ModifiedBy { get; set; }
        public bool? IsActive { get; set; }
        public bool? IsDeleted { get; set; }

        public virtual AspNetUser User { get; set; } = null!;
        public virtual ICollection<EventCalendar> EventCalendars { get; set; }
        public virtual ICollection<Hospital> Hospitals { get; set; }
        public virtual ICollection<OrganizationDoctor> OrganizationDoctors { get; set; }
        public virtual ICollection<OrganizationShift> OrganizationShifts { get; set; }
        public virtual ICollection<OrganizationUser> OrganizationUsers { get; set; }
    }
}
