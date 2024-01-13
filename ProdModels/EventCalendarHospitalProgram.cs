using System;
using System.Collections.Generic;

namespace ALYETL.ProdModels
{
    public partial class EventCalendarHospitalProgram
    {
        public int Id { get; set; }
        public int EventCalendarId { get; set; }
        public DateTime? CreatedOn { get; set; }
        public int HospitalProgramId { get; set; }
        public int? CreatedBy { get; set; }

        public virtual EventCalendar EventCalendar { get; set; } = null!;
        public virtual HospitalProgram HospitalProgram { get; set; } = null!;
    }
}
