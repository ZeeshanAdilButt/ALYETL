using System;
using System.Collections.Generic;

namespace ALYETL.StgModels
{
    public partial class CustomEventCalendar
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public decimal BreakHours { get; set; }
        public int TimeSheetId { get; set; }

        public virtual TimeSheet TimeSheet { get; set; } = null!;
    }
}
