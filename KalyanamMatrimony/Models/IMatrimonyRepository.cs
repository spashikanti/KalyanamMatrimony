using KalyanamMatrimony.ViewModels;
using System.Collections.Generic;
using System.Linq;

namespace KalyanamMatrimony.Models
{
    public interface IMatrimonyRepository
    {
        //SuperAdminRole
        IEnumerable<Profile> GetLatestProfilesForSuperAdmin();
        IEnumerable<Profile> GetAllProfilesForSuperAdmin();

        IEnumerable<License> GetAllLicenses();
        IEnumerable<License> GetAllActiveLicenses();
        IEnumerable<License> GetAllInActiveLicenses();
        License AddLicense(License license);
        License GetLicenseById(int licenseId);
        License UpdateLicense(License license);

        IEnumerable<OrganisationViewModel> GetAllOrganisations();
        IEnumerable<OrganisationViewModel> GetAllActiveOrganisations();
        IEnumerable<OrganisationViewModel> GetAllInActiveOrganisations();
        Organisation AddOrganisation(Organisation organisation);
        Organisation GetOrganisationById(int orgId);
        Organisation UpdateOrganisation(Organisation organisation);

        //AdminRole
        IEnumerable<Profile> GetLatestProfilesForAdmin(int orgId);
        IEnumerable<Profile> GetAllActiveProfilesForAdmin(int orgId);
        IEnumerable<Profile> GetAllProfilesForAdmin(int orgId);
        int GetTotalMaleProfilesCountForAdmin(int orgId);
        int GetTotalFemaleProfilesCountForAdmin(int orgId);

        Profile AddProfile(Profile profile);
        Profile GetProfileById(string profileId);
        Profile GetProfileByUserId(string userId);
        Profile UpdateProfile(Profile profile);
        IEnumerable<Profile> GetActiveProfiles(int orgId);
        IEnumerable<Profile> GetDeActivedProfiles(int orgId);
        int DeleteProfileById(string profileId);

        //Profile
        IEnumerable<Profile> GetLatestMaleProfiles(int orgId);
        IEnumerable<Profile> GetLatestFemaleProfiles(int orgId);
        IEnumerable<Profile> GetAllMaleProfiles(int orgId);
        IEnumerable<Profile> GetAllFemaleProfiles(int orgId);

    }
}
