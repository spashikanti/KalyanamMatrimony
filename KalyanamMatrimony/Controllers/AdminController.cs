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
    public class AdminController : Controller
    {
        private readonly IMatrimonyRepository matrimonyRepository;
        private readonly UserManager<ApplicationUser> userManager;

        public AdminController(IMatrimonyRepository matrimonyRepository, UserManager<ApplicationUser> userManager)
        {
            this.matrimonyRepository = matrimonyRepository;
            this.userManager = userManager;
        }

        private Task<ApplicationUser> GetCurrentUserAsync() => userManager.GetUserAsync(HttpContext.User);
        private async Task<string> GetCurrentUserId()
        {
            ApplicationUser user = await GetCurrentUserAsync();
            return user?.Id;
        }
        private async Task<int> GetCurrentOrgId()
        {
            ApplicationUser user = await GetCurrentUserAsync();
            return user.OrgId;
        }
        private async Task<string> GetCurrentUserRole()
        {
            ApplicationUser user = await GetCurrentUserAsync();
            IList<string> roles = await userManager.GetRolesAsync(user);
            return roles[0];
        }

        public async Task<IActionResult> Index()
        {
            ProfilesViewModel profilesViewModel = new ProfilesViewModel();
            int orgId = await GetCurrentOrgId();
            profilesViewModel.ActiveProfilesCount = matrimonyRepository.GetActiveProfiles(orgId).Count();
            profilesViewModel.DeActivedProfilesCount = matrimonyRepository.GetDeActivedProfiles(orgId).Count();
            profilesViewModel.MaleProfilesCount = matrimonyRepository.GetTotalMaleProfilesCountForAdmin(orgId);
            profilesViewModel.FemaleProfilesCount = matrimonyRepository.GetTotalFemaleProfilesCountForAdmin(orgId);
            return View(profilesViewModel);
        }
    }
}
