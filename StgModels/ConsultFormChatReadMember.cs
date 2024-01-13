using System;
using System.Collections.Generic;

namespace ALYETL.StgModels
{
    public partial class ConsultFormChatReadMember
    {
        public int Id { get; set; }
        public int ConsultChatId { get; set; }
        public int UserId { get; set; }

        public virtual ConsultChat ConsultChat { get; set; } = null!;
    }
}
