using System;
using System.Collections.Generic;

namespace ALYETL.ProdModels
{
    public partial class ApplicationClaimUserType
    {
        public int Id { get; set; }
        public int ApplicationClaimId { get; set; }
        public int UserTypeId { get; set; }

        public virtual Claim ApplicationClaim { get; set; } = null!;
    }
}
