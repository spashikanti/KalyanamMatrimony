using System.Collections.Generic;
using System.Linq;

namespace KalyanamMatrimony.Models
{
    public interface IMatrimonyRepository
    {
        
        Profile AddProfile(Profile profile);
        Profile GetProfileById(string profileId);
        Profile GetProfileByUserId(string userId);
        Profile UpdateProfile(Profile profile);
        IEnumerable<Profile> GetActiveProfiles(int orgId);
        IEnumerable<Profile> GetDeActivedProfiles(int orgId);
        int DeleteProfileById(string profileId);

        IEnumerable<License> GetAllLicenses();
        License AddLicense(License license);
        License GetLicenseById(int licenseId);
        License UpdateLicense(License license);

        IEnumerable<Organisation> GetAllOrganisations();
        Organisation AddOrganisation(Organisation organisation);
        Organisation GetOrganisationById(int orgId);
        Organisation UpdateOrganisation(Organisation organisation);


        //SuperAdminRole
        IEnumerable<Profile> GetLatestProfilesForSuperAdmin();
        IEnumerable<Profile> GetAllProfilesForSuperAdmin();

        //AdminRole
        IEnumerable<Profile> GetLatestProfilesForAdmin(int orgId);
        IEnumerable<Profile> GetAllActiveProfilesForAdmin(int orgId);
        IEnumerable<Profile> GetAllProfilesForAdmin(int orgId);
        int GetTotalMaleProfilesCountForAdmin(int orgId);
        int GetTotalFemaleProfilesCountForAdmin(int orgId);

        //Profile
        IEnumerable<Profile> GetLatestMaleProfiles(int orgId);
        IEnumerable<Profile> GetLatestFemaleProfiles(int orgId);
        IEnumerable<Profile> GetAllMaleProfiles(int orgId);
        IEnumerable<Profile> GetAllFemaleProfiles(int orgId);

    }
}
