using System;
using System.Collections.Generic;

namespace ALYETL.ProdModels
{
    public partial class AuditLog
    {
        public int Id { get; set; }
        public int AuditType { get; set; }
        public int? AuditUser { get; set; }
        public string TableName { get; set; } = null!;
        public string KeyValues { get; set; } = null!;
        public string? OldValues { get; set; }
        public string? NewValues { get; set; }
        public string? ChangedColumns { get; set; }
        public DateTime AuditDateTime { get; set; }
        public int OrganizationId { get; set; }
    }
}
