using System;
using System.Collections.Generic;

namespace ALYETL.ProdModels
{
    public partial class UserDeviceToken
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string DeviceToken { get; set; } = null!;
        public DateTime? CreatedOn { get; set; }

        public virtual AspNetUser User { get; set; } = null!;
    }
}
