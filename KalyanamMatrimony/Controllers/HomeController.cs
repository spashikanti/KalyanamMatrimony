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
    [RedirectingActionAttribute]
    [Authorize]
    public class HomeController : BaseController
    {
        private readonly IMatrimonyRepository matrimonyRepository;

        public HomeController(IMatrimonyRepository matrimonyRepository)
        {
            this.matrimonyRepository = matrimonyRepository;
        }

        public async Task<IActionResult> Index()
        {
            IEnumerable<Profile> profilesList = new List<Profile>();
           
            string userRole = GetSessionUserRole();
            string userId = GetSessionUserId();
            int orgId = GetSessionOrgId();
            ViewBag.OrgType = GetSessionOrgType();
            var strSuperAdminRole = Enum.GetName(typeof(CustomEnums.CustomRole), CustomEnums.CustomRole.SuperAdmin);
            var strAdminRole = Enum.GetName(typeof(CustomEnums.CustomRole), CustomEnums.CustomRole.Admin);
            var strAdminAssistantRole = Enum.GetName(typeof(CustomEnums.CustomRole), CustomEnums.CustomRole.AdminAssistant);

            if (userRole == strSuperAdminRole)
            {
                profilesList = matrimonyRepository.GetLatestProfilesForSuperAdmin();
                return View(profilesList);
            }
            else if (userRole == strAdminRole || userRole == strAdminAssistantRole)
            {
                profilesList = matrimonyRepository.GetLatestProfilesForAdmin(orgId);
                return View(profilesList);
            }

            var userProfile = matrimonyRepository.GetProfileByUserId(userId);
            if (userProfile != null)
            {
                if (userProfile.Gender == CustomEnums.ProfileGender.Male)
                {
                    //get details of female
                    profilesList = matrimonyRepository.GetLatestFemaleProfiles(orgId);
                }
                else if (userProfile.Gender == CustomEnums.ProfileGender.Female)
                {
                    //get details of males
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
