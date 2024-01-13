﻿using System;
using System.Collections.Generic;

namespace ALYETL.ProdModels
{
    public partial class HospitalProgramFacility
    {
        public int Id { get; set; }
        public int? HospitalProgramId { get; set; }
        public string FacilityName { get; set; } = null!;
        public bool? IsActive { get; set; }
        public DateTime? CreatedOn { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public int? ModifiedBy { get; set; }

        public virtual HospitalProgram? HospitalProgram { get; set; }
    }
}
