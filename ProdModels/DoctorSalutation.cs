using System;
using System.Collections.Generic;

namespace ALYETL.ProdModels
{
    public partial class DoctorSalutation
    {
        public int Id { get; set; }
        public int DoctorId { get; set; }
        public int SalutationId { get; set; }
        public DateTime? CreatedOn { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public int? ModifiedBy { get; set; }
        public bool? IsActive { get; set; }

        public virtual AspNetUser Doctor { get; set; } = null!;
        public virtual Salutation Salutation { get; set; } = null!;
    }
}
