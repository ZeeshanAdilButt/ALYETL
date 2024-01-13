using System;
using System.Collections.Generic;

namespace ALYETL.ProdModels
{
    public partial class ConsultFormStatusLog
    {
        public int Id { get; set; }
        public int ConsultFormId { get; set; }
        public int StatusId { get; set; }
        public DateTime? CreatedOn { get; set; }
        public int? CreatedBy { get; set; }

        public virtual ConsultForm ConsultForm { get; set; } = null!;
    }
}
