using System;
using System.Collections.Generic;

namespace ALYETL.StgModels
{
    public partial class EventCalendar
    {
        public EventCalendar()
        {
            EventCalendarDoctors = new HashSet<EventCalendarDoctor>();
            EventCalendarHospitalPrograms = new HashSet<EventCalendarHospitalProgram>();
        }

        public int Id { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public bool? IsActive { get; set; }
        public DateTime? CreatedOn { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public int? ModifiedBy { get; set; }
        public int OrganizationId { get; set; }
        public bool? IsAllDay { get; set; }
        public int Occurence { get; set; }
        public int UtcOffset { get; set; }
        public int? EndYear { get; set; }
        public decimal BreakHours { get; set; }
        public bool? HasBreakHours { get; set; }
        public Guid RelatedRecurringEventsReferenceId { get; set; }
        public int TotalHours { get; set; }
        public int? TimeSheetId { get; set; }

        public virtual Organization Organization { get; set; } = null!;
        public virtual TimeSheet? TimeSheet { get; set; }
        public virtual ICollection<EventCalendarDoctor> EventCalendarDoctors { get; set; }
        public virtual ICollection<EventCalendarHospitalProgram> EventCalendarHospitalPrograms { get; set; }
    }
}
