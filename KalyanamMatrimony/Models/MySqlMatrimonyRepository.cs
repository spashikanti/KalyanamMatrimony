using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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

        public IEnumerable<Profile> GetActiveProfiles(int orgId)
        {
            return GetActiveOrInActiveProfiles(true, userManager.Users.Where(x => x.OrgId == orgId));
        }

        public IEnumerable<Profile> GetDeActivedProfiles(int orgId)
        {
            return GetActiveOrInActiveProfiles(false, userManager.Users.Where(x => x.OrgId == orgId));
        }

        private IEnumerable<Profile> GetActiveOrInActiveProfiles(bool isActive, IQueryable<ApplicationUser> usersList)
        {
            List<ApplicationUser> users = isActive == true ?
                usersList.Where(x => x.EndDate != null && x.EndDate.Value > System.DateTime.Now).ToList() :
                usersList.Where(x => x.EndDate != null && x.EndDate.Value < System.DateTime.Now).ToList();
            return context.Profiles.Where(profile => users.Any(user => user.Id == profile.UserId));
        }

        public Profile GetProfileById(string profileId)
        {
            return context.Profiles.FirstOrDefault(x => x.ProfileId == profileId);
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

        public int DeleteProfileById(string profileId)
        {
            var profile = GetProfileById(profileId);
            context.Profiles.Remove(profile);
            return context.SaveChanges();
        }

        public IEnumerable<License> GetAllLicenses()
        {
            return context.Licenses;
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
            return context.Organisations.ToList();
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
            return GetAllProfilesForSuperAdmin().Take(10);
        }
        public IEnumerable<Profile> GetAllProfilesForSuperAdmin()
        {
            //Get all active profiles across org
            var users = userManager.Users.Where(x => x.EndDate.Value > System.DateTime.Now).ToList();
            return context.Profiles
                .Where(profile => users.Any(userData => userData.Id == profile.UserId))
                .OrderBy(x => x.CreatedDate);
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
            var users = userManager.Users.Where(x => x.EndDate.Value > System.DateTime.Now && x.OrgId == orgId).ToList();
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
            var users = userManager.Users.Where(x => x.EndDate.Value > System.DateTime.Now && x.OrgId == orgId);
            return context.Profiles
                .Where(profile => users.Any(userdata => profile.UserId == userdata.Id) && profile.Gender == CustomEnums.ProfileGender.Male)
                .OrderBy(x => x.CreatedDate);
        }
        public IEnumerable<Profile> GetAllFemaleProfiles(int orgId)
        {
            //Get all active female profiles for the current org
            var users = userManager.Users.Where(x => x.EndDate.Value > System.DateTime.Now && x.OrgId == orgId);
            return context.Profiles
                .Where(profile => users.Any(userdata => profile.UserId == userdata.Id) && profile.Gender == CustomEnums.ProfileGender.Female)
                .OrderBy(x => x.CreatedDate);
        }
    }
}
