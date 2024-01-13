using System;
using System.Collections.Generic;

namespace ALYETL.ProdModels
{
    public partial class UserUsedPassword
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string HashPassword { get; set; } = null!;
        public DateTime CreatedDate { get; set; }
    }
}
