using KalyanamMatrimony.Models;
using KalyanamMatrimony.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KalyanamMatrimony.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        private readonly IEmployeeRepository _employeeRepository;
        private readonly IMatrimonyRepository matrimonyRepository;
        private readonly UserManager<ApplicationUser> userManager;

        public HomeController(IEmployeeRepository employeeRepository, IMatrimonyRepository matrimonyRepository, 
            UserManager<ApplicationUser> userManager)
        {
            _employeeRepository = employeeRepository;
            this.matrimonyRepository = matrimonyRepository;
            this.userManager = userManager;
        }

        public async Task<IActionResult> Index()
        {
            IEnumerable<Profile> profilesList = new List<Profile>();
            var user = await userManager.GetUserAsync(User);

            if (user != null)
            {
                var strSuperAdminRole = Enum.GetName(typeof(CustomEnums.CustomRole), CustomEnums.CustomRole.SuperAdmin);
                var strAdminRole = Enum.GetName(typeof(CustomEnums.CustomRole), CustomEnums.CustomRole.SuperAdmin);

                if (await userManager.IsInRoleAsync(user, strSuperAdminRole) || await userManager.IsInRoleAsync(user, strAdminRole))
                {
                    profilesList = matrimonyRepository.GetAllProfiles().Take(10);
                    return View(profilesList);
                }

                var userProfile = matrimonyRepository.GetProfileByUserId(user.Id);
                if (userProfile != null)
                {
                    if (userProfile.Gender == CustomEnums.ProfileGender.Male)
                    {
                        //get details of female
                        profilesList = matrimonyRepository.GetAllProfiles().Where(x => x.Gender == CustomEnums.ProfileGender.Female).Take(10);
                    }
                    else if (userProfile.Gender == CustomEnums.ProfileGender.Female)
                    {
                        //get details of males
                        profilesList = matrimonyRepository.GetAllProfiles().Where(x => x.Gender == CustomEnums.ProfileGender.Male).Take(10);
                    }
                }
            }

            //var model = _employeeRepository.GetAllEmployee();
            return View(profilesList);
        }

        public ViewResult Details(int? id)
        {
            HomeDetailsViewModel homeDetailsViewModel = new HomeDetailsViewModel()
            {
                Employee = _employeeRepository.GetEmployee(id??1),
                PageTitle = "Employee Details"
            };
            return View(homeDetailsViewModel);
        }

    }
}
