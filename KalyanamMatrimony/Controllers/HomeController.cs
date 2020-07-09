using KalyanamMatrimony.Models;
using KalyanamMatrimony.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace KalyanamMatrimony.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        private readonly IMatrimonyRepository matrimonyRepository;
        private readonly UserManager<ApplicationUser> userManager;

        public HomeController(IMatrimonyRepository matrimonyRepository, 
            UserManager<ApplicationUser> userManager)
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
            IEnumerable<Profile> profilesList = new List<Profile>();
            string userRole = await GetCurrentUserRole();
            string userId = await GetCurrentUserId();
            int orgId = await GetCurrentOrgId();

            var strSuperAdminRole = Enum.GetName(typeof(CustomEnums.CustomRole), CustomEnums.CustomRole.SuperAdmin);
            var strAdminRole = Enum.GetName(typeof(CustomEnums.CustomRole), CustomEnums.CustomRole.Admin);

            //Get search data for the current organisation, active users only
            List<ApplicationUser> users = null;

            if (userRole == strSuperAdminRole)
            {
                //users = userManager.Users.Where(x => x.EndDate.Value > DateTime.Now).ToList();
                //profilesList = matrimonyRepository.GetAllProfiles().Where(profile => users.Any(userData => userData.Id == profile.UserId)).Take(10);
                //return View(profilesList);
                profilesList = matrimonyRepository.GetLatestProfilesForSuperAdmin();
                return View(profilesList);
            }
            else if (userRole == strAdminRole)
            {
                //users = userManager.Users.Where(x => x.EndDate.Value > DateTime.Now && x.OrgId == orgId).ToList();
                //profilesList = matrimonyRepository.GetAllProfiles().Where(profile => users.Any(userData => userData.Id == profile.UserId)).Take(10);
                //return View(profilesList);
                profilesList = matrimonyRepository.GetLatestProfilesForAdmin(orgId);
                return View(profilesList);
            }

            var userProfile = matrimonyRepository.GetProfileByUserId(userId);
            if (userProfile != null)
            {
                if (userProfile.Gender == CustomEnums.ProfileGender.Male)
                {
                    //get details of female
                    //profilesList = matrimonyRepository.GetAllProfiles().Where(profile => profile.Gender == CustomEnums.ProfileGender.Female &&
                    //users.Any(userData => userData.Id == profile.UserId && userData.OrgId == orgId)).Take(10);
                    profilesList = matrimonyRepository.GetLatestFemaleProfiles(orgId);
                }
                else if (userProfile.Gender == CustomEnums.ProfileGender.Female)
                {
                    //get details of males
                    //profilesList = matrimonyRepository.GetAllProfiles().Where(profile => profile.Gender == CustomEnums.ProfileGender.Male &&
                    //users.Any(userData => userData.Id == profile.UserId && userData.OrgId == orgId)).Take(10);
                    profilesList = matrimonyRepository.GetLatestMaleProfiles(orgId);
                }
            }

            return View(profilesList);
        }

        public ViewResult Details(int? id)
        {
            HomeDetailsViewModel homeDetailsViewModel = new HomeDetailsViewModel()
            {
                PageTitle = "Employee Details"
            };
            return View(homeDetailsViewModel);
        }

    }
}
