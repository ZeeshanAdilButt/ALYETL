using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;

namespace ALYETL.ProdModels
{
    public partial class AspNetUserToken : IdentityUserToken<int>
    {
        public int UserId { get; set; }
        public string LoginProvider { get; set; } = null!;
        public string Name { get; set; } = null!;
        public string? Value { get; set; }
        public DateTimeOffset? TokenExpiryTime { get; set; }

        public virtual AspNetUser User { get; set; } = null!;
    }
}
