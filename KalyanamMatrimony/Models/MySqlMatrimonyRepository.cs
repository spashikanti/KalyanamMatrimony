using KalyanamMatrimony.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KalyanamMatrimony.Models
{
    public class MySqlMatrimonyRepository : IMatrimonyRepository
    {
        private readonly AppDbContext context;
        private readonly UserManager<ApplicationUser> userManager;
        private readonly RoleManager<IdentityRole> roleManager;

        public MySqlMatrimonyRepository(AppDbContext context,
                                UserManager<ApplicationUser> userManager,
                                RoleManager<IdentityRole> roleManager)
        {
            this.context = context;
            this.userManager = userManager;
            this.roleManager = roleManager;
        }

        public Profile AddProfile(Profile profile)
        {
            context.Profiles.Add(profile);
            context.SaveChanges();
            return profile;
        }
        public PartnerPreference AddPartnerPreference(PartnerPreference partnerPreference)
        {
            context.PartnerPreferences.Add(partnerPreference);
            context.SaveChanges();
            return partnerPreference;
        }
        public IEnumerable<Profile> GetActiveProfiles(int orgId)
        {
            return GetActiveOrInActiveProfiles(true, userManager.Users.Where(x => x.OrgId == orgId));
        }

        public IEnumerable<Profile> GetDeActivedProfiles(int orgId)
        {
            return GetActiveOrInActiveProfiles(false, userManager.Users.Where(x => x.OrgId == orgId));
        }

        public IEnumerable<Profile> GetActiveOrInActiveProfiles(bool isActive, IQueryable<ApplicationUser> usersList)
        {
            List<ApplicationUser> users = GetActiveOrInActiveApplicationUsers(isActive, usersList).ToList();
            return context.Profiles.Where(profile => users.Any(user => user.Id == profile.UserId));
        }

        public IEnumerable<ApplicationUser> GetActiveOrInActiveApplicationUsers(bool isActive, IQueryable<ApplicationUser> usersList)
        {
            IEnumerable<ApplicationUser> users = isActive == true ?
                usersList.Where(x => x.EndDate != null && x.EndDate.Value >= System.DateTime.Now).ToList() :
                usersList.Where(x => x.EndDate != null && x.EndDate.Value < System.DateTime.Now).ToList();
            return users;
        }
        public IEnumerable<AssistantViewModel> GetActiveAdminAssitants(int orgId)
        {
            List<AssistantViewModel> model = new List<AssistantViewModel>();
            List<ApplicationUser> users = GetActiveOrInActiveApplicationUsers(true, userManager.Users.Where(x => x.OrgId == orgId)).ToList();

            if (users != null && users.Count() > 0)
            {
                foreach (var user in users)
                {
                    model.Add(new AssistantViewModel { 
                        Email = user.Email,
                        UserId = user.Id,
                        EndDate = user.EndDate
                    });
                }
            }
            return model;
        }
        //private async Task<IList<ApplicationUser>> GetAdminAssistantUsers(int orgId)
        //{
        //    List<ApplicationUser> users = GetActiveOrInActiveApplicationUsers(true, userManager.Users.Where(x => x.OrgId == orgId)).ToList();
        //    string userRole = Enum.GetName(typeof(CustomEnums.CustomRole), CustomEnums.CustomRole.AdminAssistant);
        //    IList<ApplicationUser> adminAssistantUsers = await userManager.GetUsersInRoleAsync(userRole);
        //    IList<ApplicationUser> filteredUsers = users.Where(user => adminAssistantUsers.Any(aUser => aUser.Id == user.Id)).ToList();
        //    return filteredUsers;
        //}
        public IEnumerable<AssistantViewModel> GetDeActivedAdminAssitants(int orgId)
        {
            List<AssistantViewModel> model = new List<AssistantViewModel>();
            IEnumerable<ApplicationUser> users = GetActiveOrInActiveApplicationUsers(false, userManager.Users.Where(x => x.OrgId == orgId));
            if (users != null && users.Count() > 0)
            {
                foreach (var user in users)
                {
                    model.Add(new AssistantViewModel
                    {
                        Email = user.Email,
                        UserId = user.Id,
                        EndDate = user.EndDate
                    });
                }
            }
            return model;
        }

        public Profile GetProfileById(string profileId)
        {
            return context.Profiles.FirstOrDefault(x => x.ProfileId == profileId);
        }

        public PartnerPreference GetPartnerPreferenceByProfileId(string profileId)
        {
            return context.PartnerPreferences.FirstOrDefault(x => x.ProfileId == profileId);
        }

        public Profile GetProfileByUserId(string userId)
        {
            return context.Profiles.FirstOrDefault(x => x.UserId == userId);
        }

        public Profile UpdateProfile(Profile profile)
        {
            context.Profiles.Update(profile);
            context.Entry(profile).State = EntityState.Modified;
            context.SaveChanges();
            return profile;
        }
        public PartnerPreference UpdatePartnerPreference(PartnerPreference partnerPreference)
        {
            context.PartnerPreferences.Update(partnerPreference);
            context.Entry(partnerPreference).State = EntityState.Modified;
            context.SaveChanges();
            return partnerPreference;
        }
        public int DeleteProfileById(string profileId)
        {
            var profile = GetProfileById(profileId);
            if(profile.PartnerPreference != null)
            {
                context.PartnerPreferences.Remove(profile.PartnerPreference);
            }
            context.Profiles.Remove(profile);
            return context.SaveChanges();
        }

        public IEnumerable<License> GetAllLicenses()
        {
            return context.Licenses;
        }

        public IEnumerable<License> GetAllActiveLicenses()
        {
            return GetAllLicenses().Where(e => e.IsActive == true);
        }

        public IEnumerable<License> GetAllInActiveLicenses()
        {
            return GetAllLicenses().Where(e => e.IsActive == false);
        }

        public License AddLicense(License license)
        {
            context.Licenses.Add(license);
            context.SaveChanges();
            return license;
        }

        public License GetLicenseById(int licenseId)
        {
            return context.Licenses.FirstOrDefault(x => x.LicenseId == licenseId);
        }

        public License UpdateLicense(License license)
        {
            context.Licenses.Update(license);
            context.Entry(license).State = EntityState.Modified;
            context.SaveChanges();
            return license;
        }

        public IEnumerable<Organisation> GetAllOrganisations()
        {
            return context.Organisations;
        }

        public IEnumerable<OrganisationViewModel> GetAllLicensedOrganisations()
        {
            //send org with its license
            List<License> licenses = context.Licenses.ToList();
            List<Organisation> organisations = GetAllOrganisations().ToList();
            return organisations.Join(licenses, org => org.LicenseId, lic => lic.LicenseId, 
                (org, lic) => new OrganisationViewModel{
                    OrgId = org.OrgId,
                    OrgName = org.OrgName,
                    FullName = org.FullName,
                    Phone = org.Phone,
                    CreatedDate = org.CreatedDate,
                    EndDate = org.EndDate,
                    LicenseId = org.LicenseId,
                    LicenseName = lic.LicenseName,
                    Description = lic.Description
            }).ToList();
        }

        public IEnumerable<OrganisationViewModel> GetAllActiveOrganisations()
        {
            return GetAllLicensedOrganisations().Where(x => x.EndDate > DateTime.Now).ToList();
        }

        public IEnumerable<OrganisationViewModel> GetAllInActiveOrganisations()
        {
            return GetAllLicensedOrganisations().Where(x => x.EndDate < DateTime.Now).ToList();
        }
        public IEnumerable<OrganisationViewModel> GetAllLicenseNotMappedOrganisations()
        {
            List<Organisation> organisations = GetAllOrganisations().Where(x => x.LicenseId == 0).ToList();
            List<OrganisationViewModel> organisationViewModel = new List<OrganisationViewModel>();

            if(organisations.Count() > 0)
            {
                foreach (var org in organisations)
                {
                    organisationViewModel.Add(new OrganisationViewModel {
                        OrgId = org.OrgId,
                        OrgName = org.OrgName,
                        FullName = org.FullName,
                        Phone = org.Phone,
                        CreatedDate = org.CreatedDate,
                        EndDate = org.EndDate,
                        LicenseId = org.LicenseId,
                        LicenseName = "No License",
                        Description = "No License"
                    });
                }
            }
            
            return organisationViewModel;
        }

        public Organisation AddOrganisation(Organisation organisation)
        {
            context.Organisations.Add(organisation);
            context.SaveChanges();
            return organisation;
        }

        public Organisation GetOrganisationById(int orgId)
        {
            return context.Organisations.FirstOrDefault(x => x.OrgId == orgId);
        }

        public Organisation UpdateOrganisation(Organisation organisation)
        {
            context.Organisations.Update(organisation);
            context.Entry(organisation).State = EntityState.Modified;
            context.SaveChanges();
            return organisation;
        }

        //SuperAdmin
        public IEnumerable<Profile> GetLatestProfilesForSuperAdmin()
        {
            //Get Top 10 latest active profiles across org
            return GetAllActiveProfilesForSuperAdmin().Take(10);
        }
        public IEnumerable<Profile> GetAllActiveProfilesForSuperAdmin()
        {
            //Get all active profiles across org
            var users = userManager.Users.Where(x => x.EndDate.Value >= System.DateTime.Now).ToList();
            return context.Profiles
                .Where(profile => users.Any(userData => userData.Id == profile.UserId))
                .OrderBy(x => x.CreatedDate);
        }
        public IEnumerable<Profile> GetAllDeActivedProfilesForSuperAdmin()
        {
            //Get all active profiles across org
            var users = userManager.Users.Where(x => x.EndDate.Value < System.DateTime.Now).ToList();
            return context.Profiles
                .Where(profile => users.Any(userData => userData.Id == profile.UserId))
                .OrderBy(x => x.CreatedDate);
        }
        public IEnumerable<AssistantViewModel> GetAllActiveAdminAssitants()
        {
            List<AssistantViewModel> model = new List<AssistantViewModel>();
            List<ApplicationUser> users = GetActiveOrInActiveApplicationUsers(true, userManager.Users).ToList();

            if (users != null && users.Count() > 0)
            {
                foreach (var user in users)
                {
                    model.Add(new AssistantViewModel
                    {
                        Email = user.Email,
                        UserId = user.Id,
                        EndDate = user.EndDate
                    });
                }
            }
            return model;
        }

        public IEnumerable<AssistantViewModel> GetAllDeActivedAdminAssitants()
        {
            List<AssistantViewModel> model = new List<AssistantViewModel>();
            List<ApplicationUser> users = GetActiveOrInActiveApplicationUsers(false, userManager.Users).ToList();

            if (users != null && users.Count() > 0)
            {
                foreach (var user in users)
                {
                    model.Add(new AssistantViewModel
                    {
                        Email = user.Email,
                        UserId = user.Id,
                        EndDate = user.EndDate
                    });
                }
            }
            return model;
        }

        //Admin
        public IEnumerable<Profile> GetLatestProfilesForAdmin(int orgId)
        {
            //Get Top 10 latest active profiles for the current org
            return GetAllActiveProfilesForAdmin(orgId).Take(10);
        }
        public IEnumerable<Profile> GetAllActiveProfilesForAdmin(int orgId)
        {
            //Get all active profiles for the current org
            var users = userManager.Users.Where(x => x.EndDate.Value >= System.DateTime.Now && x.OrgId == orgId).ToList();
            return context.Profiles
                .Where(profile => users.Any(userData => userData.Id == profile.UserId))
                .OrderBy(x => x.CreatedDate);
        }
        public IEnumerable<Profile> GetAllProfilesForAdmin(int orgId)
        {
            //Get all active profiles for the current org
            var users = userManager.Users.Where(x => x.OrgId == orgId).ToList();
            return context.Profiles
                .Where(profile => users.Any(userData => userData.Id == profile.UserId))
                .OrderBy(x => x.CreatedDate);
        }
        public int GetTotalMaleProfilesCountForAdmin(int orgId)
        {
            return GetAllProfilesForAdmin(orgId).Where(x => x.Gender == CustomEnums.ProfileGender.Male).Count();
        }
        public int GetTotalFemaleProfilesCountForAdmin(int orgId)
        {
            return GetAllProfilesForAdmin(orgId).Where(x => x.Gender == CustomEnums.ProfileGender.Female).Count();
        }

        //Profiles
        public IEnumerable<Profile> GetLatestMaleProfiles(int orgId)
        {
            //Get Top 10 latest active male profiles for the current org
            return GetAllMaleProfiles(orgId).Take(10);
        }
        public IEnumerable<Profile> GetLatestFemaleProfiles(int orgId)
        {
            //Get Top 10 latest active female profiles for the current org
            return GetAllFemaleProfiles(orgId).Take(10);
        }
        public IEnumerable<Profile> GetAllMaleProfiles(int orgId)
        {
            //Get all active male profiles for the current org
            var users = userManager.Users.Where(x => x.EndDate.Value >= System.DateTime.Now && x.OrgId == orgId);
            return context.Profiles
                .Where(profile => users.Any(userdata => profile.UserId == userdata.Id) && profile.Gender == CustomEnums.ProfileGender.Male)
                .OrderBy(x => x.CreatedDate);
        }
        public IEnumerable<Profile> GetAllFemaleProfiles(int orgId)
        {
            //Get all active female profiles for the current org
            var users = userManager.Users.Where(x => x.EndDate.Value >= System.DateTime.Now && x.OrgId == orgId);
            return context.Profiles
                .Where(profile => users.Any(userdata => profile.UserId == userdata.Id) && profile.Gender == CustomEnums.ProfileGender.Female)
                .OrderBy(x => x.CreatedDate);
        }

        public PaymentHistory AddPaymentHistory(PaymentHistory paymentHistory)
        {
            context.PaymentHistory.Add(paymentHistory);
            context.SaveChanges();
            return paymentHistory;
        }

        public PaymentHistory UpdatePaymentHistory(PaymentHistory paymentHistory)
        {
            context.PaymentHistory.Update(paymentHistory);
            context.Entry(paymentHistory).State = EntityState.Modified;
            context.SaveChanges();
            return paymentHistory;
        }

        public PaymentHistory GetPaymentHistoryById(int paymentHistoryId)
        {
            return context.PaymentHistory.FirstOrDefault(x => x.PaymentHistoryId == paymentHistoryId);
        }
    }
}
