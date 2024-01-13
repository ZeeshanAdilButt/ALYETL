using System;
using System.Collections.Generic;

namespace ALYETL.ProdModels
{
    public partial class RemindarLog
    {
        public int Id { get; set; }
        public int DoctorId { get; set; }
        public string Message { get; set; } = null!;
        public DateTime DateTimeSend { get; set; }
    }
}
