using System.Collections.Generic;
using System.Linq;

namespace KalyanamMatrimony.Models
{
    public interface IMatrimonyRepository
    {
        IEnumerable<Profile> GetAllProfiles();
        Profile AddProfile(Profile profile);
        Profile GetProfileById(string profileId);
        Profile GetProfileByUserId(string userId);
        Profile UpdateProfile(Profile profile);
        IEnumerable<Profile> GetActiveProfiles(IQueryable<ApplicationUser> userList);
        IEnumerable<Profile> GetDeActivedProfiles(IQueryable<ApplicationUser> userList);
        int DeleteProfileById(string profileId);

        IEnumerable<License> GetAllLicenses();
        License AddLicense(License license);
        License GetLicenseById(int licenseId);
        License UpdateLicense(License license);

        IEnumerable<Organisation> GetAllOrganisations();
        Organisation AddOrganisation(Organisation organisation);
        Organisation GetOrganisationById(int orgId);
        Organisation UpdateOrganisation(Organisation organisation);
    }
}
