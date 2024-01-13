using System;
using System.Collections.Generic;

namespace ALYETL.StgModels
{
    public partial class EventCalendarDoctor
    {
        public int Id { get; set; }
        public int EventCalendarId { get; set; }
        public DateTime? CreatedOn { get; set; }
        public int DoctorId { get; set; }
        public int? CreatedBy { get; set; }

        public virtual AspNetUser Doctor { get; set; } = null!;
        public virtual EventCalendar EventCalendar { get; set; } = null!;
    }
}
