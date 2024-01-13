using System;
using System.Collections.Generic;

namespace ALYETL.ProdModels
{
    public partial class HospitalProgram
    {
        public HospitalProgram()
        {
            ConsultForms = new HashSet<ConsultForm>();
            EventCalendarHospitalPrograms = new HashSet<EventCalendarHospitalProgram>();
            HospitalProgramFacilities = new HashSet<HospitalProgramFacility>();
            HospitalProgramNotificationEmails = new HashSet<HospitalProgramNotificationEmail>();
        }

        public int Id { get; set; }
        public int HospitalId { get; set; }
        public string? ProgramName { get; set; }
        public decimal SignOffTimeFrame { get; set; }
        public bool? IsConsultUrgentAttention { get; set; }
        public bool? IsPatientNameAnonymous { get; set; }
        public bool? IsSpecialNoteOnConsultForm { get; set; }
        public string? SpecialNotes { get; set; }
        public bool? IsConsultReturnPhoneNumber { get; set; }
        public bool? IsConsultReturnPhoneEntension { get; set; }
        public bool? IsConsultReturnEmail { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public bool? IsActive { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public int ConsultNotesType { get; set; }
        public int ConsultType { get; set; }
        public bool? IsShowDoctorPhoneNumber { get; set; }
        public bool? IsDeleted { get; set; }
        public int? DoctorPaymentType { get; set; }
        public string? ZoomLink { get; set; }
        public string? ZoomBackupLink { get; set; }

        public virtual Hospital Hospital { get; set; } = null!;
        public virtual ICollection<ConsultForm> ConsultForms { get; set; }
        public virtual ICollection<EventCalendarHospitalProgram> EventCalendarHospitalPrograms { get; set; }
        public virtual ICollection<HospitalProgramFacility> HospitalProgramFacilities { get; set; }
        public virtual ICollection<HospitalProgramNotificationEmail> HospitalProgramNotificationEmails { get; set; }
    }
}
