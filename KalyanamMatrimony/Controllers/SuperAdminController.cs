using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KalyanamMatrimony.Models;
using KalyanamMatrimony.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace KalyanamMatrimony.Controllers
{
    public class SuperAdminController : BaseController
    {
        private readonly IMatrimonyRepository matrimonyRepository;

        public SuperAdminController(IMatrimonyRepository matrimonyRepository)
        {
            this.matrimonyRepository = matrimonyRepository;
        }

        public IActionResult Index()
        {
            return View();
        }

        //CRUD Licenses (D is inactive - soft delete)

        [Authorize(Roles = "SuperAdmin")]
        [HttpGet]
        public async Task<IActionResult> ViewLicenses()
        {
            //Active Profiles Only
            ToasterServiceDisplay();
            LicencesViewModel licensesModel = new LicencesViewModel();
            licensesModel.ActiveLicenses = matrimonyRepository.GetAllLicenses().Where(e => e.IsActive == true);
            licensesModel.DeActivedLicenses = matrimonyRepository.GetAllLicenses().Where(e => e.IsActive == false);
            return View(licensesModel);
        }

        [Authorize(Roles = "SuperAdmin")]
        [HttpGet]
        public IActionResult CreateLicense()
        {
            return View();
        }

        [Authorize(Roles = "SuperAdmin")]
        [HttpPost]
        public async Task<IActionResult> CreateLicense(License model)
        {
            if (ModelState.IsValid)
            {
                var repoResult = matrimonyRepository.AddLicense(model);

                if (repoResult == null)
                {
                    ModelState.AddModelError(string.Empty, "Unable to create License");
                    ToasterServiceCreate(model.LicenseName + " unable to create License", CustomEnums.ToastType.Error);
                }
                else
                {
                    ToasterServiceCreate(model.LicenseName + " License added successfully", CustomEnums.ToastType.Success);
                    return RedirectToAction("ViewLicenses", "SuperAdmin");
                }
            }

            return View(model);
        }

        [Authorize(Roles = "SuperAdmin")]
        [HttpGet]
        public async Task<IActionResult> EditLicense(int id)
        {
            if (id != null)
            {
                ToasterServiceDisplay();
                License license = matrimonyRepository.GetLicenseById(id);
                return View(license);
            }

            return RedirectToAction("NotFound", "Error");
        }

        [Authorize(Roles = "SuperAdmin")]
        [HttpPost]
        public async Task<IActionResult> EditLicense(License model)
        {
            if (ModelState.IsValid)
            {
                var repoResult = matrimonyRepository.UpdateLicense(model);
                ToasterServiceCreate(model.LicenseName + " license updated successfully", CustomEnums.ToastType.Success);
                return RedirectToAction("ViewLicenses", "superadmin");
            }

            return View(model);
        }
    }
}
