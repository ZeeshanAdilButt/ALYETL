using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ALYETL.ProdModels
{
    [Table("AspNetUserRoles")]
    public class AspNetUserRole : IdentityUserRole<int>
    {
        public virtual AspNetUser User { get; set; }
        public virtual AspNetRole Role { get; set; }
    }
}