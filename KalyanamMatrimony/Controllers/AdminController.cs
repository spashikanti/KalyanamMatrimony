using KalyanamMatrimony.Models;
using KalyanamMatrimony.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KalyanamMatrimony.Controllers
{
    [Authorize(Roles ="SuperAdmin, Admin")]
    public class AdminController : BaseController
    {
        private readonly IMatrimonyRepository matrimonyRepository;

        public AdminController(IMatrimonyRepository matrimonyRepository)
        {
            this.matrimonyRepository = matrimonyRepository;
        }

        public async Task<IActionResult> Index()
        {
            int orgId = GetSessionOrgId();
            AdminDashboardViewModel adminDashboardViewModel = new AdminDashboardViewModel();

            if (orgId > 0)
            {
                adminDashboardViewModel.ActiveProfilesCount = matrimonyRepository.GetActiveProfiles(orgId).Count();
                adminDashboardViewModel.DeActivedProfilesCount = matrimonyRepository.GetDeActivedProfiles(orgId).Count();
                adminDashboardViewModel.MaleProfilesCount = matrimonyRepository.GetTotalMaleProfilesCountForAdmin(orgId);
                adminDashboardViewModel.FemaleProfilesCount = matrimonyRepository.GetTotalFemaleProfilesCountForAdmin(orgId);
            }
            return View(adminDashboardViewModel);
        }
    }
}
