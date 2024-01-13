using ALYETL.Models;
using ALYETL.ProdModels;
using ALYETL.StgModels;
using AspNetCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Net.Mail;

namespace ALYETL.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly dbstgdec27Context _stgContext;
        private readonly dbproddec27Context _prodContext;



        //old
        //int oldorgId = 128;
        int oldHospitalId = 519;
        //int oldHospitalProgramId = 1445;


        //new
        int newOrgId = 46;
        private int newHospitalProgramId = 357;

        private Dictionary<int, int?> userDict = new Dictionary<int, int?>();


        //int newHospitalId = 210;
        //int newHospitalProgramId = 343;
        //private int organizationUserRoleId = 3;
        //private int hospitalAdminRoleId = 4;
        //private int doctorRoleId = 5;
        //private int hospitalUserRoleId = 6;

        public HomeController(ILogger<HomeController> logger, dbstgdec27Context stgContext, dbproddec27Context prodContext)
        {
            _logger = logger;
            this._stgContext = stgContext;
            this._prodContext = prodContext;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }


        public async Task<IActionResult> CreateOrganizationUser()
        {

            var oldOrganizationUsers = _stgContext.AspNetUsers.Where(x => x.Email == "Mike@alinatelehealth.com" || x.Email == "zeeshan@robot-mail.com");

            //var newusers =
            //   _prodContext.AspNetUsers.Where(x => x.Email == "Mike@alinatelehealth.com" || x.Email == "zeeshan@robot-mail.com").ToList();


            var consultsnew = _prodContext.ConsultForms.Where(x => x.OrganizationId == newOrgId).Take(1).ToList();

            var role =
                _prodContext.AspNetRoles.FirstOrDefault(r => r.Name == "User"); // Replace 'roleName' with the actual role name > this is ORG user


            foreach (var user in oldOrganizationUsers)
            {
                var newUser = new ProdModels.AspNetUser
                {
                    FirstName = user.FirstName,
                    LastName = user.LastName,
                    // Map other properties accordingly
                    UserName = user.UserName,
                    NormalizedUserName = user.NormalizedUserName,
                    Email = user.Email,
                    NormalizedEmail = user.NormalizedEmail,
                    EmailConfirmed = user.EmailConfirmed,
                    PasswordHash = user.PasswordHash,
                    SecurityStamp = user.SecurityStamp,
                    ConcurrencyStamp = user.ConcurrencyStamp,
                    PhoneNumber = user.PhoneNumber,
                    PhoneNumberConfirmed = user.PhoneNumberConfirmed,
                    TwoFactorEnabled = user.TwoFactorEnabled,
                    LockoutEnd = user.LockoutEnd,
                    LockoutEnabled = user.LockoutEnabled,
                    AccessFailedCount = user.AccessFailedCount,
                    IsActive = user.IsActive,
                    IsNotificationEnabled = user.IsNotificationEnabled,
                    PhotoThumbnailPath = user.PhotoThumbnailPath,
                    IsFirstLogin = user.IsFirstLogin,
                    City = user.City,
                    State = user.State,
                    StreetAddress = user.StreetAddress,
                    Zipcode = user.Zipcode,
                    Lat = user.Lat,
                    Long = user.Long,
                    CreatedOn = user.CreatedOn,
                    Mpin = user.Mpin,
                    IsForceLoggedOut = user.IsForceLoggedOut,
                    UserTypeId = user.UserTypeId,
                    //UserRoles = new AspNetUserRole { Role = role, User = null}

                    // Add other properties as needed
                };


                newUser.UserRoles.Add(new AspNetUserRole { Role = role, User = newUser });


                await _prodContext.Users.AddAsync(newUser);
                await _prodContext.SaveChangesAsync();

                //var userRole = new IdentityUserRole<int> {
                //    UserId = newUser.Id,
                //    RoleId = organizationUserRoleId
                //};


                //await _prodContext.AddAsync(userRole);

                //await _prodContext.SaveChangesAsync();

                var orgUSer = new ProdModels.OrganizationUser
                {
                    UserId = newUser.Id,
                    OrganizationId = newOrgId,
                    CreatedOn = DateTime.Now,
                    CreatedBy = 1,
                    IsDeleted = false
                };

                await _prodContext.AddAsync(orgUSer);
                await _prodContext.SaveChangesAsync();

            }

            return View();
        }

        public StgModels.AspNetUser GetOldUserById(int id)
        {

            return _stgContext.AspNetUsers.FirstOrDefault(x => x.Id == id);

        }

        public ProdModels.AspNetUser ConvertUser(StgModels.AspNetUser stageUser)
        {

            return new ProdModels.AspNetUser
            {
                FirstName = stageUser.FirstName,
                LastName = stageUser.LastName,
                // Map other properties accordingly
                UserName = stageUser.UserName,
                NormalizedUserName = stageUser.NormalizedUserName,
                Email = stageUser.Email,
                NormalizedEmail = stageUser.NormalizedEmail,
                EmailConfirmed = stageUser.EmailConfirmed,
                PasswordHash = stageUser.PasswordHash,
                SecurityStamp = stageUser.SecurityStamp,
                ConcurrencyStamp = stageUser.ConcurrencyStamp,
                PhoneNumber = stageUser.PhoneNumber,
                PhoneNumberConfirmed = stageUser.PhoneNumberConfirmed,
                TwoFactorEnabled = stageUser.TwoFactorEnabled,
                LockoutEnd = stageUser.LockoutEnd,
                LockoutEnabled = stageUser.LockoutEnabled,
                AccessFailedCount = stageUser.AccessFailedCount,
                IsActive = stageUser.IsActive,
                IsNotificationEnabled = stageUser.IsNotificationEnabled,
                PhotoThumbnailPath = stageUser.PhotoThumbnailPath,
                IsFirstLogin = stageUser.IsFirstLogin,
                City = stageUser.City,
                State = stageUser.State,
                StreetAddress = stageUser.StreetAddress,
                Zipcode = stageUser.Zipcode,
                Lat = stageUser.Lat,
                Long = stageUser.Long,
                CreatedOn = stageUser.CreatedOn,
                Mpin = stageUser.Mpin,
                IsForceLoggedOut = stageUser.IsForceLoggedOut,
                UserTypeId = stageUser.UserTypeId,
            };

        }


        public ProdModels.AspNetRole GetProdRoleIdByName(string Name)
        {
            return _prodContext.AspNetRoles.FirstOrDefault(r => r.Name == Name);
        }


        public ProdModels.AspNetRole GetProdHospitalAdminRole()
        {

            return GetProdRoleIdByName("HospitalAdmin");
        }

        public ProdModels.AspNetRole GetProdHospitalUserRole()
        {
            return GetProdRoleIdByName("HospitalStaff");
        }

        public ProdModels.AspNetRole GetProdDoctorRole()
        {
            return GetProdRoleIdByName("Doctor");
        }

        public int? ConvertStageUserIdToProdUserID(int? stageuserId)
        {

            if (stageuserId == null)
            {
                return null;
            }

            if (userDict.ContainsKey(stageuserId.Value))
                return userDict[stageuserId.Value];

            var olduser = _stgContext.AspNetUsers.FirstOrDefault(x => x.Id == stageuserId);

            var prodUser = _prodContext.AspNetUsers.FirstOrDefault(x => x.Email == olduser.Email);

            userDict.Add(stageuserId.Value, prodUser.Id);

            return userDict[stageuserId.Value];
        }

        public async Task<IActionResult> MigrateHospital()
        {

            var oldhospital = _stgContext.Hospitals
                                .Include(x => x.HospitalUsers)
                                    .ThenInclude(x => x.User)
                                .Include(x => x.HospitalTeams)
                                    .ThenInclude(x => x.User)
                                .Include(x => x.HospitalDoctors)
                                    .ThenInclude(x => x.Doctor)

                                .Include(x => x.HospitalPrograms)
                                    .ThenInclude(x => x.HospitalProgramNotificationEmails)

                                .Include(x => x.HospitalPrograms)
                                    .ThenInclude(x => x.ConsultForms)
                                        .ThenInclude(x => x.ConsultFormStatusLogs)

                                 .Include(x => x.HospitalPrograms)
                                    .ThenInclude(x => x.ConsultForms)
                                        .ThenInclude(x => x.ConsultFormTimelines)

                                 .Include(x => x.HospitalPrograms)
                                    .ThenInclude(x => x.ConsultForms)
                                        .ThenInclude(x => x.ConsultChats)
                                            .ThenInclude(x => x.ConsultFormChatReadMembers)

                                .FirstOrDefault(x => x.Id == oldHospitalId);


            //AddHospital
            ALYETL.ProdModels.Hospital newHospital = new ProdModels.Hospital
            {
                //Id = source.Id,
                HospitalName = oldhospital.HospitalName,
                LogoPath = oldhospital.LogoPath,
                IsActive = oldhospital.IsActive,
                CreatedOn = DateTime.UtcNow,
                CreatedBy = 1,
                ModifiedOn = oldhospital.ModifiedOn,
                ModifiedBy = oldhospital.ModifiedBy,
                OrganizationId = newOrgId,
                IsDeleted = false,
            };

            //add hospital profgram
            foreach (var oldHospitalProgram in oldhospital.HospitalPrograms)
            {

                var newhospitalProgram = new ALYETL.ProdModels.HospitalProgram
                {

                    //Id = oldHospitalProgram.Id,
                    //HospitalId = oldHospitalProgram.HospitalId,
                    ProgramName = oldHospitalProgram.ProgramName,
                    SignOffTimeFrame = oldHospitalProgram.SignOffTimeFrame,
                    IsConsultUrgentAttention = oldHospitalProgram.IsConsultUrgentAttention,
                    IsPatientNameAnonymous = oldHospitalProgram.IsPatientNameAnonymous,
                    IsSpecialNoteOnConsultForm = oldHospitalProgram.IsSpecialNoteOnConsultForm,
                    SpecialNotes = oldHospitalProgram.SpecialNotes,
                    IsConsultReturnPhoneNumber = oldHospitalProgram.IsConsultReturnPhoneNumber,
                    IsConsultReturnPhoneEntension = oldHospitalProgram.IsConsultReturnPhoneEntension,
                    IsConsultReturnEmail = oldHospitalProgram.IsConsultReturnEmail,
                    CreatedBy = 1,
                    CreatedOn = DateTime.UtcNow,
                    IsActive = oldHospitalProgram.IsActive,
                    ModifiedBy = oldHospitalProgram.ModifiedBy,
                    ModifiedOn = oldHospitalProgram.ModifiedOn,
                    ConsultNotesType = oldHospitalProgram.ConsultNotesType,
                    ConsultType = oldHospitalProgram.ConsultType,
                    IsShowDoctorPhoneNumber = oldHospitalProgram.IsShowDoctorPhoneNumber,
                    IsDeleted = oldHospitalProgram.IsDeleted,
                    DoctorPaymentType = oldHospitalProgram.DoctorPaymentType,
                    ZoomLink = oldHospitalProgram.ZoomLink,
                    ZoomBackupLink = oldHospitalProgram.ZoomBackupLink,
                };


                //add hospital profram notification
                foreach (var oldhospitalProgramNotification in oldHospitalProgram.HospitalProgramNotificationEmails)
                {

                    var newhospitalProgramNotification = new ProdModels.HospitalProgramNotificationEmail
                    {
                        //Id = oldhospitalProgramNotification.Id,
                        //HospitalProgramId = oldhospitalProgramNotification.HospitalProgramId,
                        EmailAddress = oldhospitalProgramNotification.EmailAddress,
                        IsActive = oldhospitalProgramNotification.IsActive,
                        CreatedOn = oldhospitalProgramNotification.CreatedOn,
                        CreatedBy = oldhospitalProgramNotification.CreatedBy,
                        ModifiedOn = oldhospitalProgramNotification.ModifiedOn,
                        ModifiedBy = oldhospitalProgramNotification.ModifiedBy,
                    };

                    newhospitalProgram.HospitalProgramNotificationEmails.Add(newhospitalProgramNotification);

                }


                newHospital.HospitalPrograms.Add(newhospitalProgram);
            }

            //add hospital admin

            foreach (var oldHospitalUser in oldhospital.HospitalUsers)
            {

                var newHospitalAdmin = new ProdModels.HospitalUser
                {
                    //Id = oldHospitalUser.Id,
                    //HospitalId = oldHospitalUser.HospitalId,

                    CreatedOn = oldHospitalUser.CreatedOn,
                    CreatedBy = oldHospitalUser.CreatedBy,
                    ModifiedOn = oldHospitalUser.ModifiedOn,
                    ModifiedBy = oldHospitalUser.ModifiedBy,
                    IsActive = oldHospitalUser.IsActive,
                };

                //add doctor
                var newHospitalAdminUser = ConvertUser(oldHospitalUser.User);
                var hospitaladminRole = GetProdHospitalAdminRole();
                newHospitalAdminUser.UserRoles.Add(new AspNetUserRole { Role = hospitaladminRole, User = newHospitalAdminUser });


                newHospitalAdmin.User = newHospitalAdminUser;
                newHospital.HospitalUsers.Add(newHospitalAdmin);
            }

            //add hospital users

            foreach (var oldHospitalTeam in oldhospital.HospitalTeams)
            {

                var newHospitalTeam = new ProdModels.HospitalTeam
                {
                    //Id = oldHospitalTeam.Id,
                    //HospitalId = oldHospitalTeam.HospitalId,

                    CreatedOn = oldHospitalTeam.CreatedOn,
                    CreatedBy = oldHospitalTeam.CreatedBy,
                    ModifiedOn = oldHospitalTeam.ModifiedOn,
                    ModifiedBy = oldHospitalTeam.ModifiedBy,
                    IsActive = oldHospitalTeam.IsActive,
                };

                //add doctor
                var newHospitalTeamUser = ConvertUser(oldHospitalTeam.User);
                var hospitalTeamRole = GetProdHospitalUserRole();
                newHospitalTeamUser.UserRoles.Add(new AspNetUserRole { Role = hospitalTeamRole, User = newHospitalTeamUser });


                newHospitalTeam.User = newHospitalTeamUser;
                newHospital.HospitalTeams.Add(newHospitalTeam);
            }

            //add hospital doctors
            foreach (var oldHospitalDoctor in oldhospital.HospitalDoctors)
            {

                var newHospitalDoctor = new ProdModels.HospitalDoctor
                {
                    //Id = oldHospitalDoctor.Id,
                    //HospitalId = oldHospitalDoctor.HospitalId,

                    CreatedOn = oldHospitalDoctor.CreatedOn,
                    CreatedBy = oldHospitalDoctor.CreatedBy,
                    ModifiedOn = oldHospitalDoctor.ModifiedOn,
                    ModifiedBy = oldHospitalDoctor.ModifiedBy,
                    IsActive = oldHospitalDoctor.IsActive,
                };

                //add doctor
                var newDoctorUser = ConvertUser(oldHospitalDoctor.Doctor);
                var doctorRole = GetProdDoctorRole();
                newDoctorUser.UserRoles.Add(new AspNetUserRole { Role = doctorRole, User = newDoctorUser });


                newHospitalDoctor.Doctor = newDoctorUser;
                newHospital.HospitalDoctors.Add(newHospitalDoctor);
            }





            _prodContext.Hospitals.Add(newHospital);

            _prodContext.SaveChanges();
            return View();
        }


        public async Task<IActionResult> MigrateConsults()
        {

            var oldhospital = _stgContext.Hospitals
                                .Include(x => x.HospitalUsers)
                                    .ThenInclude(x => x.User)
                                .Include(x => x.HospitalTeams)
                                    .ThenInclude(x => x.User)
                                .Include(x => x.HospitalDoctors)
                                    .ThenInclude(x => x.Doctor)

                                .Include(x => x.HospitalPrograms)
                                    .ThenInclude(x => x.HospitalProgramNotificationEmails)

                                .Include(x => x.HospitalPrograms)
                                    .ThenInclude(x => x.ConsultForms)
                                        .ThenInclude(x => x.ConsultFormStatusLogs)

                                 .Include(x => x.HospitalPrograms)
                                    .ThenInclude(x => x.ConsultForms)
                                        .ThenInclude(x => x.ConsultFormTimelines)

                                 .Include(x => x.HospitalPrograms)
                                    .ThenInclude(x => x.ConsultForms)
                                        .ThenInclude(x => x.ConsultChats)
                                            .ThenInclude(x => x.ConsultFormChatReadMembers)

                                .FirstOrDefault(x => x.Id == oldHospitalId);

            var oldHospitalProgram = oldhospital.HospitalPrograms.FirstOrDefault();

            var newHospitalProgram = _prodContext.HospitalPrograms.FirstOrDefault(x => x.Id == newHospitalProgramId);


            //add consults
            foreach (var oldconsultForm in oldHospitalProgram.ConsultForms)
            {
                var newConsult = new ProdModels.ConsultForm
                {


                    PatientName = oldconsultForm.PatientName,
                    PatientMrn = oldconsultForm.PatientMrn,
                    FacilityId = oldconsultForm.FacilityId,
                    ConsultType = oldconsultForm.ConsultType,
                    Notes = oldconsultForm.Notes,
                    ConsultRequester = oldconsultForm.ConsultRequester,
                    FacilityCallbackNumber = oldconsultForm.FacilityCallbackNumber,
                    FacilityCallbackExtension = oldconsultForm.FacilityCallbackExtension,
                    ReturnEmail = oldconsultForm.ReturnEmail,
                    CreatedBy = ConvertStageUserIdToProdUserID(oldconsultForm.CreatedBy),
                    CreatedOn = oldconsultForm.CreatedOn,
                    ModifiedBy = ConvertStageUserIdToProdUserID(oldconsultForm.ModifiedBy),
                    ModifiedOn = oldconsultForm.ModifiedOn,
                    FollowupNotes = oldconsultForm.FollowupNotes,
                    IsPaused = oldconsultForm.IsPaused,
                    LastReminderSentDate = oldconsultForm.LastReminderSentDate,
                    SignedOffNotes = oldconsultForm.SignedOffNotes,
                    IsModeratorSmssent = oldconsultForm.IsModeratorSmssent,
                    FollowupDate = oldconsultForm.FollowupDate,
                    ReAssignedOn = oldconsultForm.ReAssignedOn,
                    IsReAssigned = oldconsultForm.IsReAssigned,
                    LastUpdatedStatusEnum = oldconsultForm.LastUpdatedStatusEnum.Value,

                    PatientLastName = oldconsultForm.PatientLastName,
                    TimeSheetId = oldconsultForm.TimeSheetId,
                    OrganizationId = newOrgId
                };

                newConsult.DoctorId = ConvertStageUserIdToProdUserID(oldconsultForm.DoctorId).Value;

                //consult members of chat with memeber id
                foreach (var oldmemberofChat in oldconsultForm.MembersOfChats)
                {
                    var newmemberOfChat = new ProdModels.MembersOfChat
                    {

                        MemberId = ConvertStageUserIdToProdUserID(oldmemberofChat.MemberId).Value
                    };

                    newConsult.MembersOfChats.Add(newmemberOfChat);
                }

                //consult form status log
                foreach (var oldConsultFormStatusLog in oldconsultForm.ConsultFormStatusLogs)
                {
                    var newConsultFormStatusLog = new ProdModels.ConsultFormStatusLog
                    {

                        StatusId = oldConsultFormStatusLog.StatusId,
                        CreatedOn = oldConsultFormStatusLog.CreatedOn,
                        CreatedBy = ConvertStageUserIdToProdUserID(oldConsultFormStatusLog.CreatedBy.Value)
                    };

                    newConsult.ConsultFormStatusLogs.Add(newConsultFormStatusLog);
                }

                //consult form time line
                foreach (var oldConsultFormTimeline in oldconsultForm.ConsultFormTimelines)
                {
                    var newConsultFormTimeline = new ProdModels.ConsultFormTimeline
                    {

                        ActionUserId = ConvertStageUserIdToProdUserID(oldConsultFormTimeline.ActionUserId.Value),
                        TimelineActionType = oldConsultFormTimeline.TimelineActionType,
                        CreatedOn = oldConsultFormTimeline.CreatedOn,
                        CreatedBy = ConvertStageUserIdToProdUserID(oldConsultFormTimeline.CreatedBy.Value),
                        ModifiedOn = oldConsultFormTimeline.ModifiedOn,
                        ModifiedBy = oldConsultFormTimeline.ModifiedBy,
                        IsActive = oldConsultFormTimeline.IsActive,
                        PauseReasonType = oldConsultFormTimeline.PauseReasonType,
                        PausedReason = oldConsultFormTimeline.PausedReason,

                    };

                    newConsult.ConsultFormTimelines.Add(newConsultFormTimeline);
                }


                //consult form chat
                foreach (var oldConsultChat in oldconsultForm.ConsultChats)
                {
                    var newConsultChat = new ProdModels.ConsultChat
                    {

                        Message = oldConsultChat.Message,
                        FileName = oldConsultChat.FileName,
                        CreatedOn = oldConsultChat.CreatedOn,
                        CreatedBy = oldConsultChat.CreatedBy,
                        FilePath = oldConsultChat.FilePath,
                        IsRead = oldConsultChat.IsRead,
                        PhotoThumbnailPath = oldConsultChat.PhotoThumbnailPath,
                        ClientUniqueId = oldConsultChat.ClientUniqueId,

                    };

                    //consult form chat read memebers
                    foreach (var oldconsultChatReadMemeber in oldConsultChat.ConsultFormChatReadMembers)
                    {
                        var newConsultChatReadMember = new ProdModels.ConsultFormChatReadMember
                        {
                            UserId = ConvertStageUserIdToProdUserID(oldconsultChatReadMemeber.UserId).Value
                        };

                        newConsultChat.ConsultFormChatReadMembers.Add(newConsultChatReadMember);
                    }

                    newConsult.ConsultChats.Add(newConsultChat);
                }


                newHospitalProgram.ConsultForms.Add(newConsult);
            }


            return View();

        }
    }
}