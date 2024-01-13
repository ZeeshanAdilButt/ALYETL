using System;
using System.Collections.Generic;

namespace ALYETL.StgModels
{
    public partial class AspNetUser
    {
        public AspNetUser()
        {
            AspNetUserClaims = new HashSet<AspNetUserClaim>();
            AspNetUserLogins = new HashSet<AspNetUserLogin>();
            AspNetUserTokens = new HashSet<AspNetUserToken>();
            ConsultChats = new HashSet<ConsultChat>();
            ConsultFormTimelines = new HashSet<ConsultFormTimeline>();
            ConsultForms = new HashSet<ConsultForm>();
            DbqdoctorAppointmentDbqdoctors = new HashSet<DbqdoctorAppointment>();
            DbqdoctorAppointmentDbqpatients = new HashSet<DbqdoctorAppointment>();
            DbqdoctorAvailabilities = new HashSet<DbqdoctorAvailability>();
            DbqdoctorGlobalSettings = new HashSet<DbqdoctorGlobalSetting>();
            DbqdoctorSpecialities = new HashSet<DbqdoctorSpeciality>();
            DbqpatientInvites = new HashSet<DbqpatientInvite>();
            DoctorSalutations = new HashSet<DoctorSalutation>();
            EventCalendarDoctors = new HashSet<EventCalendarDoctor>();
            HospitalDoctors = new HashSet<HospitalDoctor>();
            HospitalTeams = new HashSet<HospitalTeam>();
            HospitalUsers = new HashSet<HospitalUser>();
            LoginLogs = new HashSet<LoginLog>();
            OrganizationDbqdoctors = new HashSet<OrganizationDbqdoctor>();
            OrganizationDbqpatients = new HashSet<OrganizationDbqpatient>();
            OrganizationDoctors = new HashSet<OrganizationDoctor>();
            OrganizationShiftCreatedByNavigations = new HashSet<OrganizationShift>();
            OrganizationShiftModifiedByNavigations = new HashSet<OrganizationShift>();
            OrganizationUsers = new HashSet<OrganizationUser>();
            Organizations = new HashSet<Organization>();
            TimeSheets = new HashSet<TimeSheet>();
            UserDeviceTokens = new HashSet<UserDeviceToken>();
            Roles = new HashSet<AspNetRole>();
        }

        public int Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? UserName { get; set; }
        public string? NormalizedUserName { get; set; }
        public string? Email { get; set; }
        public string? NormalizedEmail { get; set; }
        public bool EmailConfirmed { get; set; }
        public string? PasswordHash { get; set; }
        public string? SecurityStamp { get; set; }
        public string? ConcurrencyStamp { get; set; }
        public string? PhoneNumber { get; set; }
        public bool PhoneNumberConfirmed { get; set; }
        public bool TwoFactorEnabled { get; set; }
        public DateTimeOffset? LockoutEnd { get; set; }
        public bool LockoutEnabled { get; set; }
        public int AccessFailedCount { get; set; }
        public bool? IsActive { get; set; }
        public bool? IsNotificationEnabled { get; set; }
        public string? PhotoThumbnailPath { get; set; }
        public bool? IsFirstLogin { get; set; }
        public string? City { get; set; }
        public string? State { get; set; }
        public string? StreetAddress { get; set; }
        public string? Zipcode { get; set; }
        public double? Lat { get; set; }
        public double? Long { get; set; }
        public DateTime? CreatedOn { get; set; }
        public int? Mpin { get; set; }
        public bool IsForceLoggedOut { get; set; }
        public int UserTypeId { get; set; }

        public virtual ICollection<AspNetUserClaim> AspNetUserClaims { get; set; }
        public virtual ICollection<AspNetUserLogin> AspNetUserLogins { get; set; }
        public virtual ICollection<AspNetUserToken> AspNetUserTokens { get; set; }
        public virtual ICollection<ConsultChat> ConsultChats { get; set; }
        public virtual ICollection<ConsultFormTimeline> ConsultFormTimelines { get; set; }
        public virtual ICollection<ConsultForm> ConsultForms { get; set; }
        public virtual ICollection<DbqdoctorAppointment> DbqdoctorAppointmentDbqdoctors { get; set; }
        public virtual ICollection<DbqdoctorAppointment> DbqdoctorAppointmentDbqpatients { get; set; }
        public virtual ICollection<DbqdoctorAvailability> DbqdoctorAvailabilities { get; set; }
        public virtual ICollection<DbqdoctorGlobalSetting> DbqdoctorGlobalSettings { get; set; }
        public virtual ICollection<DbqdoctorSpeciality> DbqdoctorSpecialities { get; set; }
        public virtual ICollection<DbqpatientInvite> DbqpatientInvites { get; set; }
        public virtual ICollection<DoctorSalutation> DoctorSalutations { get; set; }
        public virtual ICollection<EventCalendarDoctor> EventCalendarDoctors { get; set; }
        public virtual ICollection<HospitalDoctor> HospitalDoctors { get; set; }
        public virtual ICollection<HospitalTeam> HospitalTeams { get; set; }
        public virtual ICollection<HospitalUser> HospitalUsers { get; set; }
        public virtual ICollection<LoginLog> LoginLogs { get; set; }
        public virtual ICollection<OrganizationDbqdoctor> OrganizationDbqdoctors { get; set; }
        public virtual ICollection<OrganizationDbqpatient> OrganizationDbqpatients { get; set; }
        public virtual ICollection<OrganizationDoctor> OrganizationDoctors { get; set; }
        public virtual ICollection<OrganizationShift> OrganizationShiftCreatedByNavigations { get; set; }
        public virtual ICollection<OrganizationShift> OrganizationShiftModifiedByNavigations { get; set; }
        public virtual ICollection<OrganizationUser> OrganizationUsers { get; set; }
        public virtual ICollection<Organization> Organizations { get; set; }
        public virtual ICollection<TimeSheet> TimeSheets { get; set; }
        public virtual ICollection<UserDeviceToken> UserDeviceTokens { get; set; }

        public virtual ICollection<AspNetRole> Roles { get; set; }
    }
}
