using System;
using System.Collections.Generic;

namespace ALYETL.StgModels
{
    public partial class ConsultForm
    {
        public ConsultForm()
        {
            ConsultChats = new HashSet<ConsultChat>();
            ConsultFormStatusLogs = new HashSet<ConsultFormStatusLog>();
            ConsultFormTimelines = new HashSet<ConsultFormTimeline>();
            MembersOfChats = new HashSet<MembersOfChat>();
        }

        public int Id { get; set; }
        public int HospitalProgramId { get; set; }
        public int DoctorId { get; set; }
        public string PatientName { get; set; } = null!;
        public string? PatientMrn { get; set; }
        public int? FacilityId { get; set; }
        public int ConsultType { get; set; }
        public string Notes { get; set; } = null!;
        public string ConsultRequester { get; set; } = null!;
        public string? FacilityCallbackNumber { get; set; }
        public string? FacilityCallbackExtension { get; set; }
        public string? ReturnEmail { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public string? FollowupNotes { get; set; }
        public bool? IsPaused { get; set; }
        public DateTime? LastReminderSentDate { get; set; }
        public string? SignedOffNotes { get; set; }
        public bool? IsModeratorSmssent { get; set; }
        public DateTime? FollowupDate { get; set; }
        public DateTime? ReAssignedOn { get; set; }
        public bool IsReAssigned { get; set; }
        public int? LastUpdatedStatusEnum { get; set; }
        public int OrganizationId { get; set; }
        public string? PatientLastName { get; set; }
        public int? TimeSheetId { get; set; }
        public string UpdateNotes { get; set; } = null!;

        public virtual AspNetUser Doctor { get; set; } = null!;
        public virtual HospitalProgram HospitalProgram { get; set; } = null!;
        public virtual TimeSheet? TimeSheet { get; set; }
        public virtual ICollection<ConsultChat> ConsultChats { get; set; }
        public virtual ICollection<ConsultFormStatusLog> ConsultFormStatusLogs { get; set; }
        public virtual ICollection<ConsultFormTimeline> ConsultFormTimelines { get; set; }
        public virtual ICollection<MembersOfChat> MembersOfChats { get; set; }
    }
}
