using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace KalyanamMatrimony.Models
{
    public class MySqlMatrimonyRepository : IMatrimonyRepository
    {
        private readonly AppDbContext context;

        public MySqlMatrimonyRepository(AppDbContext context)
        {
            this.context = context;
        }

        public Profile AddProfile(Profile profile)
        {
            context.Profiles.Add(profile);
            context.SaveChanges();
            return profile;
        }

        public IEnumerable<Profile> GetActiveProfiles(IQueryable<ApplicationUser> usersList)
        {
            return GetActiveOrInActiveProfiles(true, usersList);
        }

        public IEnumerable<Profile> GetAllProfiles()
        {
            return context.Profiles.OrderBy(x => x.CreatedDate);
        }

        public IEnumerable<Profile> GetDeActivedProfiles(IQueryable<ApplicationUser> usersList)
        {
            return GetActiveOrInActiveProfiles(false, usersList);
        }

        private IEnumerable<Profile> GetActiveOrInActiveProfiles(bool isActive, IQueryable<ApplicationUser> usersList)
        {
            List<ApplicationUser> users = isActive == true ?
                usersList.Where(x => x.EndDate != null && x.EndDate.Value > System.DateTime.Now).ToList() :
                usersList.Where(x => x.EndDate != null && x.EndDate.Value < System.DateTime.Now).ToList();
            return GetAllProfiles().Where(profile => users.Any(user => user.Id == profile.UserId));
        }

        //public IEnumerable<Profile> GetLatestProfiles(CustomEnums.ProfileGender gender)
        //{
        //    if (gender == CustomEnums.ProfileGender.Male)
        //    {
        //        //get details of female
        //        return GetAllProfiles().Where(x => x.Gender == CustomEnums.ProfileGender.Female).Take(10);
        //    }
        //    else if (gender == CustomEnums.ProfileGender.Female)
        //    {
        //        //get details of males
        //        return GetAllProfiles().Where(x => x.Gender == CustomEnums.ProfileGender.Male).Take(10);
        //    }
        //    return GetAllProfiles().Take(10);
        //}

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
    }
}
