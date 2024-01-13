using System;
using System.Collections.Generic;

namespace ALYETL.StgModels
{
    public partial class Example
    {
        public long Id { get; set; }
        public string? Name { get; set; }
        public DateTime CreatedOn { get; set; }
        public int? CreatedBy { get; set; }
        public DateTimeOffset? ModifiedOn { get; set; }
        public long? ModifiedBy { get; set; }
        public bool IsDeleted { get; set; }
    }
}
