using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;

namespace ALYETL.ProdModels
{
    public partial class AspNetUserLogin : IdentityUserLogin<int>
    {
        public string LoginProvider { get; set; } = null!;
        public string ProviderKey { get; set; } = null!;
        public string? ProviderDisplayName { get; set; }
        public int UserId { get; set; }

        public virtual AspNetUser User { get; set; } = null!;
    }
}
