using System;
using System.Collections.Generic;

namespace ALYETL.StgModels
{
    public partial class NotificationHistory
    {
        public int Id { get; set; }
        public int DoctorId { get; set; }
        public int? ConsultFormId { get; set; }
        public string Subject { get; set; } = null!;
        public string Message { get; set; } = null!;
        public string NotificationType { get; set; } = null!;
        public bool IsRead { get; set; }
        public DateTime CreatedOn { get; set; }
        public int? CreatedBy { get; set; }
        public string? NotificationImage { get; set; }
    }
}
