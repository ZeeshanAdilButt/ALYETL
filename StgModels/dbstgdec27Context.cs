using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace ALYETL.StgModels
{
    public partial class dbstgdec27Context : DbContext
    {
        public dbstgdec27Context()
        {
        }

        public dbstgdec27Context(DbContextOptions<dbstgdec27Context> options)
            : base(options)
        {
        }

        public virtual DbSet<ApplicationClaimUserType> ApplicationClaimUserTypes { get; set; } = null!;
        public virtual DbSet<AspNetRole> AspNetRoles { get; set; } = null!;
        public virtual DbSet<AspNetRoleClaim> AspNetRoleClaims { get; set; } = null!;
        public virtual DbSet<AspNetUser> AspNetUsers { get; set; } = null!;
        public virtual DbSet<AspNetUserClaim> AspNetUserClaims { get; set; } = null!;
        public virtual DbSet<AspNetUserLogin> AspNetUserLogins { get; set; } = null!;
        public virtual DbSet<AspNetUserToken> AspNetUserTokens { get; set; } = null!;
        public virtual DbSet<AuditLog> AuditLogs { get; set; } = null!;
        public virtual DbSet<Claim> Claims { get; set; } = null!;
        public virtual DbSet<ClaimGroup> ClaimGroups { get; set; } = null!;
        public virtual DbSet<ConsultChat> ConsultChats { get; set; } = null!;
        public virtual DbSet<ConsultForm> ConsultForms { get; set; } = null!;
        public virtual DbSet<ConsultFormChatReadMember> ConsultFormChatReadMembers { get; set; } = null!;
        public virtual DbSet<ConsultFormStatusLog> ConsultFormStatusLogs { get; set; } = null!;
        public virtual DbSet<ConsultFormTimeline> ConsultFormTimelines { get; set; } = null!;
        public virtual DbSet<Country> Countries { get; set; } = null!;
        public virtual DbSet<CustomConsult> CustomConsults { get; set; } = null!;
        public virtual DbSet<CustomEventCalendar> CustomEventCalendars { get; set; } = null!;
        public virtual DbSet<DbqdoctorAppointment> DbqdoctorAppointments { get; set; } = null!;
        public virtual DbSet<DbqdoctorAvailability> DbqdoctorAvailabilities { get; set; } = null!;
        public virtual DbSet<DbqdoctorGlobalSetting> DbqdoctorGlobalSettings { get; set; } = null!;
        public virtual DbSet<DbqdoctorSpeciality> DbqdoctorSpecialities { get; set; } = null!;
        public virtual DbSet<DbqpatientInvite> DbqpatientInvites { get; set; } = null!;
        public virtual DbSet<DoctorSalutation> DoctorSalutations { get; set; } = null!;
        public virtual DbSet<DoctorSpeciality> DoctorSpecialities { get; set; } = null!;
        public virtual DbSet<ErrorLog> ErrorLogs { get; set; } = null!;
        public virtual DbSet<EventCalendar> EventCalendars { get; set; } = null!;
        public virtual DbSet<EventCalendarDoctor> EventCalendarDoctors { get; set; } = null!;
        public virtual DbSet<EventCalendarHospitalProgram> EventCalendarHospitalPrograms { get; set; } = null!;
        public virtual DbSet<Example> Examples { get; set; } = null!;
        public virtual DbSet<Hospital> Hospitals { get; set; } = null!;
        public virtual DbSet<HospitalDoctor> HospitalDoctors { get; set; } = null!;
        public virtual DbSet<HospitalProgram> HospitalPrograms { get; set; } = null!;
        public virtual DbSet<HospitalProgramFacility> HospitalProgramFacilities { get; set; } = null!;
        public virtual DbSet<HospitalProgramNotificationEmail> HospitalProgramNotificationEmails { get; set; } = null!;
        public virtual DbSet<HospitalTeam> HospitalTeams { get; set; } = null!;
        public virtual DbSet<HospitalUser> HospitalUsers { get; set; } = null!;
        public virtual DbSet<LoginLog> LoginLogs { get; set; } = null!;
        public virtual DbSet<MembersOfChat> MembersOfChats { get; set; } = null!;
        public virtual DbSet<NotificationHistory> NotificationHistories { get; set; } = null!;
        public virtual DbSet<Organization> Organizations { get; set; } = null!;
        public virtual DbSet<OrganizationDbqdoctor> OrganizationDbqdoctors { get; set; } = null!;
        public virtual DbSet<OrganizationDbqpatient> OrganizationDbqpatients { get; set; } = null!;
        public virtual DbSet<OrganizationDoctor> OrganizationDoctors { get; set; } = null!;
        public virtual DbSet<OrganizationShift> OrganizationShifts { get; set; } = null!;
        public virtual DbSet<OrganizationUser> OrganizationUsers { get; set; } = null!;
        public virtual DbSet<PushSubscription> PushSubscriptions { get; set; } = null!;
        public virtual DbSet<RemindarLog> RemindarLogs { get; set; } = null!;
        public virtual DbSet<Salutation> Salutations { get; set; } = null!;
        public virtual DbSet<SpDoctorFutureShiftsResult> SpDoctorFutureShiftsResults { get; set; } = null!;
        public virtual DbSet<TimeSheet> TimeSheets { get; set; } = null!;
        public virtual DbSet<UserDeviceToken> UserDeviceTokens { get; set; } = null!;
        public virtual DbSet<UserUsedPassword> UserUsedPasswords { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=.;Initial Catalog=db-stg-dec-27;Integrated Security=True;TrustServerCertificate=true;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ApplicationClaimUserType>(entity =>
            {
                entity.ToTable("ApplicationClaimUserType");

                entity.HasIndex(e => e.ApplicationClaimId, "IX_ApplicationClaimUserType_ApplicationClaimId");

                entity.HasOne(d => d.ApplicationClaim)
                    .WithMany(p => p.ApplicationClaimUserTypes)
                    .HasForeignKey(d => d.ApplicationClaimId);
            });

            modelBuilder.Entity<AspNetRole>(entity =>
            {
                entity.HasIndex(e => e.NormalizedName, "RoleNameIndex")
                    .IsUnique()
                    .HasFilter("([NormalizedName] IS NOT NULL)");

                entity.Property(e => e.DisplayName)
                    .HasMaxLength(256)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.IsSystemRole)
                    .IsRequired()
                    .HasDefaultValueSql("(CONVERT([bit],(0)))");

                entity.Property(e => e.Name).HasMaxLength(256);

                entity.Property(e => e.NormalizedName).HasMaxLength(256);
            });

            modelBuilder.Entity<AspNetRoleClaim>(entity =>
            {
                entity.HasIndex(e => e.ApplicationClaimId, "IX_AspNetRoleClaims_ApplicationClaimId");

                entity.HasIndex(e => e.RoleId, "IX_AspNetRoleClaims_RoleId");

                entity.Property(e => e.IsAssigned)
                    .IsRequired()
                    .HasDefaultValueSql("(CONVERT([bit],(0)))");

                entity.HasOne(d => d.ApplicationClaim)
                    .WithMany(p => p.AspNetRoleClaims)
                    .HasForeignKey(d => d.ApplicationClaimId);

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.AspNetRoleClaims)
                    .HasForeignKey(d => d.RoleId);
            });

            modelBuilder.Entity<AspNetUser>(entity =>
            {
                entity.HasIndex(e => e.NormalizedEmail, "EmailIndex");

                entity.HasIndex(e => e.NormalizedUserName, "UserNameIndex")
                    .IsUnique()
                    .HasFilter("([NormalizedUserName] IS NOT NULL)");

                entity.Property(e => e.CreatedOn).HasDefaultValueSql("('2022-09-19T08:51:11.7481144Z')");

                entity.Property(e => e.Email).HasMaxLength(256);

                entity.Property(e => e.IsActive).HasDefaultValueSql("(CONVERT([bit],(1)))");

                entity.Property(e => e.IsNotificationEnabled).HasDefaultValueSql("(CONVERT([bit],(1)))");

                entity.Property(e => e.Mpin).HasColumnName("MPin");

                entity.Property(e => e.NormalizedEmail).HasMaxLength(256);

                entity.Property(e => e.NormalizedUserName).HasMaxLength(256);

                entity.Property(e => e.UserName).HasMaxLength(256);

                entity.HasMany(d => d.Roles)
                    .WithMany(p => p.Users)
                    .UsingEntity<Dictionary<string, object>>(
                        "AspNetUserRole",
                        l => l.HasOne<AspNetRole>().WithMany().HasForeignKey("RoleId"),
                        r => r.HasOne<AspNetUser>().WithMany().HasForeignKey("UserId"),
                        j =>
                        {
                            j.HasKey("UserId", "RoleId");

                            j.ToTable("AspNetUserRoles");

                           j.HasIndex(new[] { "RoleId" }, "IX_AspNetUserRoles_RoleId");
                        });
            });

            modelBuilder.Entity<AspNetUserClaim>(entity =>
            {
                entity.HasIndex(e => e.UserId, "IX_AspNetUserClaims_UserId");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserClaims)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<AspNetUserLogin>(entity =>
            {
                entity.HasKey(e => new { e.LoginProvider, e.ProviderKey });

                entity.HasIndex(e => e.UserId, "IX_AspNetUserLogins_UserId");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserLogins)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<AspNetUserToken>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.LoginProvider, e.Name });

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserTokens)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<AuditLog>(entity =>
            {
                entity.ToTable("AuditLog");

                entity.Property(e => e.AuditDateTime).HasColumnType("datetime");

                entity.Property(e => e.ChangedColumns).IsUnicode(false);

                entity.Property(e => e.KeyValues).IsUnicode(false);

                entity.Property(e => e.NewValues).IsUnicode(false);

                entity.Property(e => e.OldValues).IsUnicode(false);

                entity.Property(e => e.TableName)
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Claim>(entity =>
            {
                entity.HasIndex(e => e.ClaimGroupId, "IX_Claims_ClaimGroupId");

                entity.Property(e => e.UiclaimValue).HasColumnName("UIClaimValue");

                entity.HasOne(d => d.ClaimGroup)
                    .WithMany(p => p.Claims)
                    .HasForeignKey(d => d.ClaimGroupId);
            });

            modelBuilder.Entity<ConsultChat>(entity =>
            {
                entity.ToTable("ConsultChat");

                entity.HasIndex(e => e.ConsultFormId, "IX_ConsultChat_ConsultFormId");

                entity.HasIndex(e => e.CreatedBy, "IX_ConsultChat_CreatedBy");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.HasOne(d => d.ConsultForm)
                    .WithMany(p => p.ConsultChats)
                    .HasForeignKey(d => d.ConsultFormId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.ConsultChats)
                    .HasForeignKey(d => d.CreatedBy)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<ConsultForm>(entity =>
            {
                entity.ToTable("ConsultForm");

                entity.HasIndex(e => e.DoctorId, "IX_ConsultForm_DoctorId");

                entity.HasIndex(e => e.HospitalProgramId, "IX_ConsultForm_HospitalProgramId");

                entity.HasIndex(e => e.TimeSheetId, "IX_ConsultForm_TimeSheetId");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.IsModeratorSmssent).HasColumnName("IsModeratorSMSSent");

                entity.Property(e => e.PatientMrn).HasColumnName("PatientMRN");

                entity.Property(e => e.UpdateNotes).HasDefaultValueSql("(N'')");

                entity.HasOne(d => d.Doctor)
                    .WithMany(p => p.ConsultForms)
                    .HasForeignKey(d => d.DoctorId);

                entity.HasOne(d => d.HospitalProgram)
                    .WithMany(p => p.ConsultForms)
                    .HasForeignKey(d => d.HospitalProgramId);

                entity.HasOne(d => d.TimeSheet)
                    .WithMany(p => p.ConsultForms)
                    .HasForeignKey(d => d.TimeSheetId);
            });

            modelBuilder.Entity<ConsultFormChatReadMember>(entity =>
            {
                entity.HasIndex(e => e.ConsultChatId, "IX_ConsultFormChatReadMembers_ConsultChatId");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.HasOne(d => d.ConsultChat)
                    .WithMany(p => p.ConsultFormChatReadMembers)
                    .HasForeignKey(d => d.ConsultChatId);
            });

            modelBuilder.Entity<ConsultFormStatusLog>(entity =>
            {
                entity.ToTable("ConsultFormStatusLog");

                entity.HasIndex(e => e.ConsultFormId, "IX_ConsultFormStatusLog_ConsultFormId");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.HasOne(d => d.ConsultForm)
                    .WithMany(p => p.ConsultFormStatusLogs)
                    .HasForeignKey(d => d.ConsultFormId);
            });

            modelBuilder.Entity<ConsultFormTimeline>(entity =>
            {
                entity.ToTable("ConsultFormTimeline");

                entity.HasIndex(e => e.ActionUserId, "IX_ConsultFormTimeline_ActionUserId");

                entity.HasIndex(e => e.ConsultFormId, "IX_ConsultFormTimeline_ConsultFormId");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.PausedReason).IsUnicode(false);

                entity.HasOne(d => d.ActionUser)
                    .WithMany(p => p.ConsultFormTimelines)
                    .HasForeignKey(d => d.ActionUserId);

                entity.HasOne(d => d.ConsultForm)
                    .WithMany(p => p.ConsultFormTimelines)
                    .HasForeignKey(d => d.ConsultFormId);
            });

            modelBuilder.Entity<Country>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Iso)
                    .HasMaxLength(2)
                    .HasColumnName("ISO");

                entity.Property(e => e.Iso3)
                    .HasMaxLength(3)
                    .HasColumnName("ISO3");

                entity.Property(e => e.Name).HasMaxLength(100);

                entity.Property(e => e.NiceName).HasMaxLength(100);
            });

            modelBuilder.Entity<CustomConsult>(entity =>
            {
                entity.ToTable("CustomConsult");

                entity.HasIndex(e => e.TimeSheetId, "IX_CustomConsult_TimeSheetId");

                entity.Property(e => e.HospitalName).HasDefaultValueSql("(N'')");

                entity.Property(e => e.HospitalProgramName).HasDefaultValueSql("(N'')");

                entity.Property(e => e.PatientMrn).HasColumnName("PatientMRN");

                entity.HasOne(d => d.TimeSheet)
                    .WithMany(p => p.CustomConsults)
                    .HasForeignKey(d => d.TimeSheetId);
            });

            modelBuilder.Entity<CustomEventCalendar>(entity =>
            {
                entity.HasIndex(e => e.TimeSheetId, "IX_CustomEventCalendars_TimeSheetId");

                entity.Property(e => e.BreakHours).HasColumnType("decimal(18, 2)");

                entity.HasOne(d => d.TimeSheet)
                    .WithMany(p => p.CustomEventCalendars)
                    .HasForeignKey(d => d.TimeSheetId);
            });

            modelBuilder.Entity<DbqdoctorAppointment>(entity =>
            {
                entity.ToTable("DBQDoctorAppointment");

                entity.HasIndex(e => e.DbqdoctorId, "IX_DBQDoctorAppointment_DBQDoctorId");

                entity.HasIndex(e => e.DbqpatientId, "IX_DBQDoctorAppointment_DBQPatientId");

                entity.HasIndex(e => e.DbqpatientInviteId, "IX_DBQDoctorAppointment_DBQPatientInviteId");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.DbqdoctorId).HasColumnName("DBQDoctorId");

                entity.Property(e => e.DbqpatientId).HasColumnName("DBQPatientId");

                entity.Property(e => e.DbqpatientInviteId).HasColumnName("DBQPatientInviteId");

                entity.HasOne(d => d.Dbqdoctor)
                    .WithMany(p => p.DbqdoctorAppointmentDbqdoctors)
                    .HasForeignKey(d => d.DbqdoctorId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.Dbqpatient)
                    .WithMany(p => p.DbqdoctorAppointmentDbqpatients)
                    .HasForeignKey(d => d.DbqpatientId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.DbqpatientInvite)
                    .WithMany(p => p.DbqdoctorAppointments)
                    .HasForeignKey(d => d.DbqpatientInviteId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<DbqdoctorAvailability>(entity =>
            {
                entity.ToTable("DBQDoctorAvailability");

                entity.HasIndex(e => e.DbqdoctorId, "IX_DBQDoctorAvailability_DBQDoctorId");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.DbqdoctorId).HasColumnName("DBQDoctorId");

                entity.HasOne(d => d.Dbqdoctor)
                    .WithMany(p => p.DbqdoctorAvailabilities)
                    .HasForeignKey(d => d.DbqdoctorId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<DbqdoctorGlobalSetting>(entity =>
            {
                entity.ToTable("DBQDoctorGlobalSetting");

                entity.HasIndex(e => e.DbqdoctorId, "IX_DBQDoctorGlobalSetting_DBQDoctorId");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.DbqdoctorId).HasColumnName("DBQDoctorId");

                entity.HasOne(d => d.Dbqdoctor)
                    .WithMany(p => p.DbqdoctorGlobalSettings)
                    .HasForeignKey(d => d.DbqdoctorId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<DbqdoctorSpeciality>(entity =>
            {
                entity.ToTable("DBQDoctorSpeciality");

                entity.HasIndex(e => e.DbqdoctorId, "IX_DBQDoctorSpeciality_DBQDoctorId");

                entity.HasIndex(e => e.DoctorSpecialityId, "IX_DBQDoctorSpeciality_DoctorSpecialityId");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.DbqdoctorId).HasColumnName("DBQDoctorId");

                entity.HasOne(d => d.Dbqdoctor)
                    .WithMany(p => p.DbqdoctorSpecialities)
                    .HasForeignKey(d => d.DbqdoctorId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.DoctorSpeciality)
                    .WithMany(p => p.DbqdoctorSpecialities)
                    .HasForeignKey(d => d.DoctorSpecialityId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<DbqpatientInvite>(entity =>
            {
                entity.ToTable("DBQPatientInvite");

                entity.HasIndex(e => e.DbqpatientId, "IX_DBQPatientInvite_DBQPatientId");

                entity.HasIndex(e => e.DoctorSpecialityId, "IX_DBQPatientInvite_DoctorSpecialityId");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.DbqpatientId).HasColumnName("DBQPatientId");

                entity.HasOne(d => d.Dbqpatient)
                    .WithMany(p => p.DbqpatientInvites)
                    .HasForeignKey(d => d.DbqpatientId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.DoctorSpeciality)
                    .WithMany(p => p.DbqpatientInvites)
                    .HasForeignKey(d => d.DoctorSpecialityId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<DoctorSalutation>(entity =>
            {
                entity.ToTable("DoctorSalutation");

                entity.HasIndex(e => e.DoctorId, "IX_DoctorSalutation_DoctorId");

                entity.HasIndex(e => e.SalutationId, "IX_DoctorSalutation_SalutationId");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.HasOne(d => d.Doctor)
                    .WithMany(p => p.DoctorSalutations)
                    .HasForeignKey(d => d.DoctorId);

                entity.HasOne(d => d.Salutation)
                    .WithMany(p => p.DoctorSalutations)
                    .HasForeignKey(d => d.SalutationId);
            });

            modelBuilder.Entity<DoctorSpeciality>(entity =>
            {
                entity.ToTable("DoctorSpeciality");

                entity.Property(e => e.Id).HasColumnName("ID");
            });

            modelBuilder.Entity<ErrorLog>(entity =>
            {
                entity.ToTable("ErrorLog");

                entity.Property(e => e.Id).HasColumnName("ID");
            });

            modelBuilder.Entity<EventCalendar>(entity =>
            {
                entity.ToTable("EventCalendar");

                entity.HasIndex(e => e.OrganizationId, "IX_EventCalendar_OrganizationId");

                entity.HasIndex(e => e.TimeSheetId, "IX_EventCalendar_TimeSheetId");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.BreakHours).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.HasBreakHours)
                    .IsRequired()
                    .HasDefaultValueSql("(CONVERT([bit],(0)))");

                entity.HasOne(d => d.Organization)
                    .WithMany(p => p.EventCalendars)
                    .HasForeignKey(d => d.OrganizationId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.TimeSheet)
                    .WithMany(p => p.EventCalendars)
                    .HasForeignKey(d => d.TimeSheetId);
            });

            modelBuilder.Entity<EventCalendarDoctor>(entity =>
            {
                entity.ToTable("EventCalendarDoctor");

                entity.HasIndex(e => e.DoctorId, "IX_EventCalendarDoctor_DoctorId");

                entity.HasIndex(e => e.EventCalendarId, "IX_EventCalendarDoctor_EventCalendarId");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.HasOne(d => d.Doctor)
                    .WithMany(p => p.EventCalendarDoctors)
                    .HasForeignKey(d => d.DoctorId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.EventCalendar)
                    .WithMany(p => p.EventCalendarDoctors)
                    .HasForeignKey(d => d.EventCalendarId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<EventCalendarHospitalProgram>(entity =>
            {
                entity.ToTable("EventCalendarHospitalProgram");

                entity.HasIndex(e => e.EventCalendarId, "IX_EventCalendarHospitalProgram_EventCalendarId");

                entity.HasIndex(e => e.HospitalProgramId, "IX_EventCalendarHospitalProgram_HospitalProgramId");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.HasOne(d => d.EventCalendar)
                    .WithMany(p => p.EventCalendarHospitalPrograms)
                    .HasForeignKey(d => d.EventCalendarId);

                entity.HasOne(d => d.HospitalProgram)
                    .WithMany(p => p.EventCalendarHospitalPrograms)
                    .HasForeignKey(d => d.HospitalProgramId);
            });

            modelBuilder.Entity<Hospital>(entity =>
            {
                entity.ToTable("Hospital");

                entity.HasIndex(e => e.OrganizationId, "IX_Hospital_OrganizationId");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.IsDeleted)
                    .IsRequired()
                    .HasDefaultValueSql("(CONVERT([bit],(0)))");

                entity.HasOne(d => d.Organization)
                    .WithMany(p => p.Hospitals)
                    .HasForeignKey(d => d.OrganizationId);
            });

            modelBuilder.Entity<HospitalDoctor>(entity =>
            {
                entity.ToTable("HospitalDoctor");

                entity.HasIndex(e => e.DoctorId, "IX_HospitalDoctor_DoctorId");

                entity.HasIndex(e => e.HospitalId, "IX_HospitalDoctor_HospitalId");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.HasOne(d => d.Doctor)
                    .WithMany(p => p.HospitalDoctors)
                    .HasForeignKey(d => d.DoctorId);

                entity.HasOne(d => d.Hospital)
                    .WithMany(p => p.HospitalDoctors)
                    .HasForeignKey(d => d.HospitalId);
            });

            modelBuilder.Entity<HospitalProgram>(entity =>
            {
                entity.ToTable("HospitalProgram");

                entity.HasIndex(e => e.HospitalId, "IX_HospitalProgram_HospitalId");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.IsDeleted)
                    .IsRequired()
                    .HasDefaultValueSql("(CONVERT([bit],(0)))");

                entity.Property(e => e.IsShowDoctorPhoneNumber)
                    .IsRequired()
                    .HasDefaultValueSql("(CONVERT([bit],(0)))");

                entity.Property(e => e.SignOffTimeFrame).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ZoomBackupLink)
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.ZoomLink)
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.HasOne(d => d.Hospital)
                    .WithMany(p => p.HospitalPrograms)
                    .HasForeignKey(d => d.HospitalId);
            });

            modelBuilder.Entity<HospitalProgramFacility>(entity =>
            {
                entity.ToTable("HospitalProgramFacility");

                entity.HasIndex(e => e.HospitalProgramId, "IX_HospitalProgramFacility_HospitalProgramId");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.HasOne(d => d.HospitalProgram)
                    .WithMany(p => p.HospitalProgramFacilities)
                    .HasForeignKey(d => d.HospitalProgramId);
            });

            modelBuilder.Entity<HospitalProgramNotificationEmail>(entity =>
            {
                entity.ToTable("HospitalProgramNotificationEmail");

                entity.HasIndex(e => e.HospitalProgramId, "IX_HospitalProgramNotificationEmail_HospitalProgramId");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.HasOne(d => d.HospitalProgram)
                    .WithMany(p => p.HospitalProgramNotificationEmails)
                    .HasForeignKey(d => d.HospitalProgramId);
            });

            modelBuilder.Entity<HospitalTeam>(entity =>
            {
                entity.ToTable("HospitalTeam");

                entity.HasIndex(e => e.HospitalId, "IX_HospitalTeam_HospitalId");

                entity.HasIndex(e => e.UserId, "IX_HospitalTeam_UserId");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.IsDeleted)
                    .IsRequired()
                    .HasDefaultValueSql("(CONVERT([bit],(0)))");

                entity.HasOne(d => d.Hospital)
                    .WithMany(p => p.HospitalTeams)
                    .HasForeignKey(d => d.HospitalId);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.HospitalTeams)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<HospitalUser>(entity =>
            {
                entity.ToTable("HospitalUser");

                entity.HasIndex(e => e.HospitalId, "IX_HospitalUser_HospitalId");

                entity.HasIndex(e => e.UserId, "IX_HospitalUser_UserId");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.IsDeleted)
                    .IsRequired()
                    .HasDefaultValueSql("(CONVERT([bit],(0)))");

                entity.HasOne(d => d.Hospital)
                    .WithMany(p => p.HospitalUsers)
                    .HasForeignKey(d => d.HospitalId);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.HospitalUsers)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<LoginLog>(entity =>
            {
                entity.HasIndex(e => e.UserId, "IX_LoginLogs_UserId");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.IsApp)
                    .IsRequired()
                    .HasDefaultValueSql("(CONVERT([bit],(0)))");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.LoginLogs)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<MembersOfChat>(entity =>
            {
                entity.ToTable("MembersOfChat");

                entity.HasIndex(e => e.ConsultFormId, "IX_MembersOfChat_ConsultFormId");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.HasOne(d => d.ConsultForm)
                    .WithMany(p => p.MembersOfChats)
                    .HasForeignKey(d => d.ConsultFormId);
            });

            modelBuilder.Entity<NotificationHistory>(entity =>
            {
                entity.ToTable("NotificationHistory");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.NotificationType).HasMaxLength(500);

                entity.Property(e => e.Subject).HasMaxLength(2000);
            });

            modelBuilder.Entity<Organization>(entity =>
            {
                entity.ToTable("Organization");

                entity.HasIndex(e => e.UserId, "IX_Organization_UserId");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.IsDeleted)
                    .IsRequired()
                    .HasDefaultValueSql("(CONVERT([bit],(0)))");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Organizations)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<OrganizationDbqdoctor>(entity =>
            {
                entity.ToTable("OrganizationDBQDoctor");

                entity.HasIndex(e => e.DbqdoctorId, "IX_OrganizationDBQDoctor_DBQDoctorId");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.DbqdoctorId).HasColumnName("DBQDoctorId");

                entity.Property(e => e.IsDeleted)
                    .IsRequired()
                    .HasDefaultValueSql("(CONVERT([bit],(0)))");

                entity.HasOne(d => d.Dbqdoctor)
                    .WithMany(p => p.OrganizationDbqdoctors)
                    .HasForeignKey(d => d.DbqdoctorId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<OrganizationDbqpatient>(entity =>
            {
                entity.ToTable("OrganizationDBQPatient");

                entity.HasIndex(e => e.DbqpatientId, "IX_OrganizationDBQPatient_DBQPatientId");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.DbqpatientId).HasColumnName("DBQPatientId");

                entity.Property(e => e.IsDeleted)
                    .IsRequired()
                    .HasDefaultValueSql("(CONVERT([bit],(0)))");

                entity.HasOne(d => d.Dbqpatient)
                    .WithMany(p => p.OrganizationDbqpatients)
                    .HasForeignKey(d => d.DbqpatientId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<OrganizationDoctor>(entity =>
            {
                entity.ToTable("OrganizationDoctor");

                entity.HasIndex(e => e.DoctorId, "IX_OrganizationDoctor_DoctorId");

                entity.HasIndex(e => e.OrganizationId, "IX_OrganizationDoctor_OrganizationId");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.IsDeleted)
                    .IsRequired()
                    .HasDefaultValueSql("(CONVERT([bit],(0)))");

                entity.HasOne(d => d.Doctor)
                    .WithMany(p => p.OrganizationDoctors)
                    .HasForeignKey(d => d.DoctorId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.Organization)
                    .WithMany(p => p.OrganizationDoctors)
                    .HasForeignKey(d => d.OrganizationId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<OrganizationShift>(entity =>
            {
                entity.ToTable("OrganizationShift");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.ShiftEndTime).HasDefaultValueSql("(N'')");

                entity.Property(e => e.ShiftName).HasMaxLength(500);

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.OrganizationShiftCreatedByNavigations)
                    .HasForeignKey(d => d.CreatedBy)
                    .HasConstraintName("FK_OrganizationShift_AspNetUsers");

                entity.HasOne(d => d.ModifiedByNavigation)
                    .WithMany(p => p.OrganizationShiftModifiedByNavigations)
                    .HasForeignKey(d => d.ModifiedBy)
                    .HasConstraintName("FK_OrganizationShift_AspNetUsers1");

                entity.HasOne(d => d.Organization)
                    .WithMany(p => p.OrganizationShifts)
                    .HasForeignKey(d => d.OrganizationId)
                    .HasConstraintName("FK_OrganizationShift_Organization");
            });

            modelBuilder.Entity<OrganizationUser>(entity =>
            {
                entity.ToTable("OrganizationUser");

                entity.HasIndex(e => e.OrganizationId, "IX_OrganizationUser_OrganizationId");

                entity.HasIndex(e => e.UserId, "IX_OrganizationUser_UserId");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.IsDeleted)
                    .IsRequired()
                    .HasDefaultValueSql("(CONVERT([bit],(0)))");

                entity.HasOne(d => d.Organization)
                    .WithMany(p => p.OrganizationUsers)
                    .HasForeignKey(d => d.OrganizationId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.OrganizationUsers)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<PushSubscription>(entity =>
            {
                entity.ToTable("PushSubscription");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.P256dh).HasColumnName("P256DH");
            });

            modelBuilder.Entity<RemindarLog>(entity =>
            {
                entity.ToTable("RemindarLog");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.DateTimeSend).HasColumnType("datetime");

                entity.Property(e => e.Message).HasMaxLength(1000);
            });

            modelBuilder.Entity<Salutation>(entity =>
            {
                entity.ToTable("Salutation");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Name).HasMaxLength(20);
            });

            modelBuilder.Entity<SpDoctorFutureShiftsResult>(entity =>
            {
                entity.ToTable("SP_DoctorFutureShifts_Results");

                entity.Property(e => e.Id).HasColumnName("ID");
            });

            modelBuilder.Entity<TimeSheet>(entity =>
            {
                entity.HasIndex(e => e.DoctorId, "IX_TimeSheets_DoctorId");

                entity.HasOne(d => d.Doctor)
                    .WithMany(p => p.TimeSheets)
                    .HasForeignKey(d => d.DoctorId);
            });

            modelBuilder.Entity<UserDeviceToken>(entity =>
            {
                entity.ToTable("UserDeviceToken");

                entity.HasIndex(e => e.UserId, "IX_UserDeviceToken_UserId");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.UserDeviceTokens)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<UserUsedPassword>(entity =>
            {
                entity.ToTable("UserUsedPassword");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
