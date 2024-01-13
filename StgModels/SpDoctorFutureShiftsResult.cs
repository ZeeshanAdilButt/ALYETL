using System;
using System.Collections.Generic;

namespace ALYETL.StgModels
{
    public partial class SpDoctorFutureShiftsResult
    {
        public int Id { get; set; }
        public string ShiftMonth { get; set; } = null!;
        public string ShiftDay { get; set; } = null!;
        public string HospitalName { get; set; } = null!;
        public string ProgramName { get; set; } = null!;
        public string? StartTime { get; set; }
        public string? EndTime { get; set; }
        public int TotalCount { get; set; }
    }
}
