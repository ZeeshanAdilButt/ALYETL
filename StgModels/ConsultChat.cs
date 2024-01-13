using System;
using System.Collections.Generic;

namespace ALYETL.StgModels
{
    public partial class ConsultChat
    {
        public ConsultChat()
        {
            ConsultFormChatReadMembers = new HashSet<ConsultFormChatReadMember>();
        }

        public int Id { get; set; }
        public int ConsultFormId { get; set; }
        public string? Message { get; set; }
        public string? FileName { get; set; }
        public DateTime CreatedOn { get; set; }
        public int CreatedBy { get; set; }
        public string? FilePath { get; set; }
        public bool IsRead { get; set; }
        public string? PhotoThumbnailPath { get; set; }
        public string? ClientUniqueId { get; set; }

        public virtual ConsultForm ConsultForm { get; set; } = null!;
        public virtual AspNetUser CreatedByNavigation { get; set; } = null!;
        public virtual ICollection<ConsultFormChatReadMember> ConsultFormChatReadMembers { get; set; }
    }
}
