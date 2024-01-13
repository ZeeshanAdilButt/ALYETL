using System;
using System.Collections.Generic;

namespace ALYETL.ProdModels
{
    public partial class PushSubscription
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string Endpoint { get; set; } = null!;
        public string P256dh { get; set; } = null!;
        public string Auth { get; set; } = null!;
        public DateTime? CreatedOn { get; set; }
        public bool? IsActive { get; set; }
    }
}
