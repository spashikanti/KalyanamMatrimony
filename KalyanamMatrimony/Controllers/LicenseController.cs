using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KalyanamMatrimony.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using static KalyanamMatrimony.Models.CustomEnums;
using Microsoft.AspNetCore.Http;
using KalyanamMatrimony.ViewModels;

namespace KalyanamMatrimony.Controllers
{
    public class LicenseController : BaseController
    {
        private readonly IMatrimonyRepository matrimonyRepository;

        public LicenseController(IMatrimonyRepository matrimonyRepository)
        {
            this.matrimonyRepository = matrimonyRepository;
        }

        [HttpGet]
        [Authorize(Roles = "SuperAdmin, Admin")]
        public IActionResult UpdateLicense()
        {
            int licenseId = GetSessionLicenseId();
            if (licenseId == 0)
            {
                ViewBag.LicenseTypes = matrimonyRepository.GetAllLicenses();
            }
            else
            {
                ViewBag.LicenseTypes = matrimonyRepository.GetAllLicenses().Where(x => x.LicenseType != LicenseType.Free);
            }
            //Get FullName, Phone, OrgId - GetOrganisation by OrgId
            //Purpose is license Text
            //Total amount is the amount

            //GetLicenses
            ViewBag.UsersCount = matrimonyRepository.GetAllActiveLicenses()
                                .Select(uc => uc.UsersCount)
                                .Distinct();
            IEnumerable<License> licenses = matrimonyRepository.GetAllActiveLicenses();
            return View(licenses);
        }

        [HttpPost]
        [Authorize(Roles = "SuperAdmin, Admin")]
        public IActionResult UpdateLicense(int licenseId, float monthsCount)
        {
            if (licenseId > 0)
            {
                int orgId = GetSessionOrgId();
                Organisation org = matrimonyRepository.GetOrganisationById(orgId);
                org.LicenseId = licenseId;
                //Update org end date
                float numOfDays = 31 * monthsCount;
                org.EndDate = DateTime.Now.AddDays(numOfDays);
                org = matrimonyRepository.UpdateOrganisation(org);
                SetSessionOrgDetails(org);
                //Update PaymentHistory Table for Org
                //Navigate to acknowledge page for successful license update
                return View("AcknowledgeLicense");
            }

            //GetLicenses
            ViewBag.UsersCount = matrimonyRepository.GetAllActiveLicenses()
                                .Select(uc => uc.UsersCount)
                                .Distinct();
            IEnumerable<License> licenses = matrimonyRepository.GetAllActiveLicenses();
            return View(licenses);

        }

        [HttpGet]
        [Authorize(Roles = "SuperAdmin, Admin")]
        public IActionResult AcknowledgeLicense()
        {
            return View();
        }
    }
}
