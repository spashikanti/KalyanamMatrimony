using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KalyanamMatrimony.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using static KalyanamMatrimony.Models.CustomEnums;
using Microsoft.AspNetCore.Http;

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
    }
}
