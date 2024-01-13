using System;
using System.Collections.Generic;

namespace ALYETL.ProdModels
{
    public partial class ErrorLog
    {
        public int Id { get; set; }
        public int? StatusCode { get; set; }
        public string? Exception { get; set; }
        public string? InnerException { get; set; }
        public string? StackTrace { get; set; }
        public DateTime? CreatedOn { get; set; }
        public int? CreatedBy { get; set; }
    }
}
