using System;
using System.Collections.Generic;

namespace ALYETL.StgModels
{
    public partial class CustomConsult
    {
        public int Id { get; set; }
        public string PatientMrn { get; set; } = null!;
        public string ConsultType { get; set; } = null!;
        public DateTime CreatedOn { get; set; }
        public int TimeSheetId { get; set; }
        public string HospitalName { get; set; } = null!;
        public string HospitalProgramName { get; set; } = null!;
        public string? Notes { get; set; }

        public virtual TimeSheet TimeSheet { get; set; } = null!;
    }
}
