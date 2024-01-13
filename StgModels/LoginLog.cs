using System;
using System.Collections.Generic;

namespace ALYETL.StgModels
{
    public partial class LoginLog
    {
        public int Id { get; set; }
        public DateTime? LoginTime { get; set; }
        public DateTime? LogoutTime { get; set; }
        public int UserId { get; set; }
        public DateTime? CreatedOn { get; set; }
        public bool? IsApp { get; set; }
        public DateTime? ShiftReminderTime { get; set; }

        public virtual AspNetUser User { get; set; } = null!;
    }
}
