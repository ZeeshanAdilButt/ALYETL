using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;

namespace ALYETL.ProdModels
{
    public partial class AspNetRoleClaim : IdentityRoleClaim<int>
    {
        public int Id { get; set; }
        public int RoleId { get; set; }
        public string? ClaimType { get; set; }
        public string? ClaimValue { get; set; }
        public int ApplicationClaimId { get; set; }
        public bool? IsAssigned { get; set; }

        public virtual Claim ApplicationClaim { get; set; } = null!;
        public virtual AspNetRole Role { get; set; } = null!;
    }
}
