using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace ALYETL.ProdModels
{
    [Table("AspNetRoles")]
    public partial class AspNetRole : IdentityRole<int>
    {
        public AspNetRole()
        {
            AspNetRoleClaims = new HashSet<AspNetRoleClaim>();
            Users = new HashSet<AspNetUser>();
        }

        public int Id { get; set; }
        public string? Name { get; set; }
        public string? NormalizedName { get; set; }
        public string? ConcurrencyStamp { get; set; }
        public string DisplayName { get; set; } = null!;
        public int? HospitalId { get; set; }
        public bool? IsSystemRole { get; set; }
        public int? OrganizationId { get; set; }
        public int UserTypeId { get; set; }

        public virtual ICollection<AspNetRoleClaim> AspNetRoleClaims { get; set; }

        public virtual ICollection<AspNetUserRole> UserRoles { get; set; }
        

        public virtual ICollection<AspNetUser> Users { get; set; }
    }
}
