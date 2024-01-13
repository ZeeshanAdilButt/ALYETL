using System;
using System.Collections.Generic;

namespace ALYETL.ProdModels
{
    public partial class DbqdoctorGlobalSetting
    {
        public int Id { get; set; }
        public int DbqdoctorId { get; set; }
        public int InitialSessionCost { get; set; }
        public int InitialSessionDuration { get; set; }
        public int FollowupSessionCost { get; set; }
        public int FollowupSessionDuration { get; set; }
        public int AppointmentCancellationGracePeriod { get; set; }
        public DateTime? CreatedOn { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public int? ModifiedBy { get; set; }

        public virtual AspNetUser Dbqdoctor { get; set; } = null!;
    }
}
