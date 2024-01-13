using System;
using System.Collections.Generic;

namespace ALYETL.ProdModels
{
    public partial class Salutation
    {
        public Salutation()
        {
            DoctorSalutations = new HashSet<DoctorSalutation>();
        }

        public int Id { get; set; }
        public string? Name { get; set; }
        public bool? IsActive { get; set; }

        public virtual ICollection<DoctorSalutation> DoctorSalutations { get; set; }
    }
}
