using System;
using System.Collections.Generic;

namespace ALYETL.ProdModels
{
    public partial class MembersOfChat
    {
        public int Id { get; set; }
        public int MemberId { get; set; }
        public int ConsultFormId { get; set; }

        public virtual ConsultForm ConsultForm { get; set; } = null!;
    }
}
