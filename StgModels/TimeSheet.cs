using System;
using System.Collections.Generic;

namespace ALYETL.StgModels
{
    public partial class TimeSheet
    {
        public TimeSheet()
        {
            ConsultForms = new HashSet<ConsultForm>();
            CustomConsults = new HashSet<CustomConsult>();
            CustomEventCalendars = new HashSet<CustomEventCalendar>();
            EventCalendars = new HashSet<EventCalendar>();
        }

        public int Id { get; set; }
        public int OrganizationId { get; set; }
        public int TimeSheetType { get; set; }
        public int TimeSheetOccurenceType { get; set; }
        public int TimeSheetStatus { get; set; }
        public DateTime From { get; set; }
        public DateTime To { get; set; }
        public int DoctorId { get; set; }
        public int TimeSheetLastUpdatedByStatus { get; set; }
        public DateTime CreatedOn { get; set; }
        public int? CreatedBy { get; set; }
        public DateTimeOffset? ModifiedOn { get; set; }
        public long? ModifiedBy { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime? ApprovedByAdminTime { get; set; }
        public DateTime? ApprovedByDoctorTime { get; set; }

        public virtual AspNetUser Doctor { get; set; } = null!;
        public virtual ICollection<ConsultForm> ConsultForms { get; set; }
        public virtual ICollection<CustomConsult> CustomConsults { get; set; }
        public virtual ICollection<CustomEventCalendar> CustomEventCalendars { get; set; }
        public virtual ICollection<EventCalendar> EventCalendars { get; set; }
    }
}
