using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;

namespace ALYETL.ProdModels
{
    public partial class AspNetUserClaim : IdentityUserClaim<int>
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string? ClaimType { get; set; }
        public string? ClaimValue { get; set; }

        public virtual AspNetUser User { get; set; } = null!;
    }
}
