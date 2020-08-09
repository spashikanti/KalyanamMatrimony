using KalyanamMatrimony.ViewModels;
using System.Collections.Generic;
using System.Linq;

namespace KalyanamMatrimony.Models
{
    public interface IMatrimonyRepository
    {
        //SuperAdminRole
        IEnumerable<Profile> GetLatestProfilesForSuperAdmin();
        IEnumerable<Profile> GetAllActiveProfilesForSuperAdmin();
        IEnumerable<Profile> GetAllDeActivedProfilesForSuperAdmin();

        IEnumerable<License> GetAllLicenses();
        IEnumerable<License> GetAllActiveLicenses();
        IEnumerable<License> GetAllInActiveLicenses();
        License AddLicense(License license);
        License GetLicenseById(int licenseId);
        License UpdateLicense(License license);

        IEnumerable<Organisation> GetAllOrganisations();
        IEnumerable<OrganisationViewModel> GetAllLicensedOrganisations();
        IEnumerable<OrganisationViewModel> GetAllActiveOrganisations();
        IEnumerable<OrganisationViewModel> GetAllInActiveOrganisations();
        IEnumerable<OrganisationViewModel> GetAllLicenseNotMappedOrganisations();
        Organisation AddOrganisation(Organisation organisation);
        Organisation GetOrganisationById(int orgId);
        Organisation UpdateOrganisation(Organisation organisation);
        IEnumerable<AssistantViewModel> GetAllActiveAdminAssitants();
        IEnumerable<AssistantViewModel> GetAllDeActivedAdminAssitants();

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
        PartnerPreference AddPartnerPreference(PartnerPreference partnerPreference);
        PartnerPreference GetPartnerPreferenceByProfileId(string profileId);
        PartnerPreference UpdatePartnerPreference(PartnerPreference partnerPreference);
        IEnumerable<Profile> GetActiveProfiles(int orgId);
        IEnumerable<Profile> GetDeActivedProfiles(int orgId);
        IEnumerable<Profile> GetActiveOrInActiveProfiles(bool isActive, IQueryable<ApplicationUser> usersList);
        IEnumerable<ApplicationUser> GetActiveOrInActiveApplicationUsers(bool isActive, IQueryable<ApplicationUser> usersList);
        IEnumerable<AssistantViewModel> GetActiveAdminAssitants(int orgId);
        IEnumerable<AssistantViewModel> GetDeActivedAdminAssitants(int orgId);
        int DeleteProfileById(string profileId);
        PaymentHistory AddPaymentHistory(PaymentHistory paymentHistory);
        PaymentHistory UpdatePaymentHistory(PaymentHistory paymentHistory);
        PaymentHistory GetPaymentHistoryById(int paymentHistoryId);
        SiteSettings GetSiteSettingsByOrgId(int orgId);
        SiteSettings AddUpdateSiteSettings(SiteSettings siteSettings);

        //Profile
        IEnumerable<Profile> GetLatestMaleProfiles(int orgId);
        IEnumerable<Profile> GetLatestFemaleProfiles(int orgId);
        IEnumerable<Profile> GetAllMaleProfiles(int orgId);
        IEnumerable<Profile> GetAllFemaleProfiles(int orgId);


    }
}
