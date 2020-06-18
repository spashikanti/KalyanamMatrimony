using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using KalyanamMatrimony.Models;
using KalyanamMatrimony.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace KalyanamMatrimony.Controllers
{
    [Authorize]
    public class ProfileController : Controller
    {
        private readonly UserManager<ApplicationUser> userManager;
        private readonly SignInManager<ApplicationUser> signInManager;
        private readonly RoleManager<IdentityRole> roleManager;
        private readonly IMatrimonyRepository matrimonyRepository;

        public ProfileController(UserManager<ApplicationUser> userManager,
                                SignInManager<ApplicationUser> signInManager,
                                RoleManager<IdentityRole> roleManager,
                                IMatrimonyRepository matrimonyRepository)
        {
            this.userManager = userManager;
            this.signInManager = signInManager;
            this.roleManager = roleManager;
            this.matrimonyRepository = matrimonyRepository;
        }

        public IActionResult Index()
        {
            var profile = matrimonyRepository.GetAllProfiles();
            return View(profile);
        }

        [HttpGet]
        public IActionResult CreateProfile()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateProfile(UserProfileViewModel model)
        {
            if (ModelState.IsValid)
            {
                //assign Role to user
                var role = await roleManager.FindByNameAsync(model.UserRole);
                if (role == null)
                {
                    ModelState.AddModelError(string.Empty, $"Role = {model.UserRole} not be found! Unable to add user");
                    return View();
                }

                // Copy data from RegisterViewModel to IdentityUser
                var user = new ApplicationUser();
                user.UserName = model.Email;
                user.Email = model.Email;
                if (model.EndDate != null)
                {
                    user.EndDate = model.EndDate;
                }

                // Store user data in AspNetUsers database table
                var result = await userManager.CreateAsync(user, model.Password);

                // If user is successfully created, sign-in the user using
                // SignInManager and redirect to index action of HomeController
                if (result.Succeeded)
                {
                    var roleResult = await userManager.AddToRoleAsync(user, model.UserRole);
                    if (roleResult.Succeeded)
                    {
                        string profileId = GenerateProfileNumber();
                        //Add Profile
                        Profile profile = new Profile
                        {
                            FirstName = model.FirstName,
                            LastName = model.LastName,
                            UserId = user.Id,
                            ProfileId = profileId
                        };

                        matrimonyRepository.Add(profile);
                        return RedirectToAction("index", "home");
                    }

                    // If there are any errors, add them to the ModelState object
                    // which will be displayed by the validation summary tag helper
                    foreach (var error in roleResult.Errors)
                    {
                        ModelState.AddModelError(string.Empty, error.Description);
                    }

                    return View(model);
                }

                // If there are any errors, add them to the ModelState object
                // which will be displayed by the validation summary tag helper
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError(string.Empty, error.Description);
                }
            }

            return View(model);
        }

        private string GenerateProfileNumber()
        {
            return "PROF_" + String.Format("{0:d9}", (DateTime.Now.Ticks / 10) % 1000000000);
        }
    }
}
