using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KalyanamMatrimony.Models;
using KalyanamMatrimony.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using static KalyanamMatrimony.Models.CustomEnums;

namespace KalyanamMatrimony.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<ApplicationUser> userManager;
        private readonly SignInManager<ApplicationUser> signInManager;
        private readonly RoleManager<IdentityRole> roleManager;

        public AccountController(UserManager<ApplicationUser> userManager,
                                SignInManager<ApplicationUser> signInManager, 
                                RoleManager<IdentityRole> roleManager)
        {
            this.userManager = userManager;
            this.signInManager = signInManager;
            this.roleManager = roleManager;
        }

        [AcceptVerbs("Get", "Post")]
        public async Task<IActionResult> IsEmailInUse(string email)
        {
            var user = await userManager.FindByEmailAsync(email);

            if (user == null)
            {
                return Json(true);
            }
            else
            {
                return Json($"Email {email} is already in use.");
            }
        }

        [HttpGet]
        public IActionResult CreateUser()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateUser(RegisterViewModel model)
        {
            if (ModelState.IsValid)
            {
                ////assign Role to user
                //var role = await roleManager.FindByNameAsync(model.UserRole);
                //if (role == null)
                //{
                //    ModelState.AddModelError(string.Empty, $"Role = {model.UserRole} not be found! Unable to add user");
                //    return View();
                //}

                // Copy data from RegisterViewModel to IdentityUser
                var user = new ApplicationUser
                {
                    UserName = model.Email,
                    Email = model.Email,
                    
                };
                //EndDate = model.EndDate

                // Store user data in AspNetUsers database table
                var result = await userManager.CreateAsync(user, model.Password);

                // If user is successfully created, sign-in the user using
                // SignInManager and redirect to index action of HomeController
                if (result.Succeeded)
                {
                    //var roleResult = await userManager.AddToRoleAsync(user, model.UserRole);
                    //if (roleResult.Succeeded)
                    //{
                    //    return RedirectToAction("index", "home");
                    //}

                    //// If there are any errors, add them to the ModelState object
                    //// which will be displayed by the validation summary tag helper
                    //foreach (var error in roleResult.Errors)
                    //{
                    //    ModelState.AddModelError(string.Empty, error.Description);
                    //}

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

        [HttpPost]
        [Authorize]
        public async Task<IActionResult> Logout()
        {
            await signInManager.SignOutAsync();
            return RedirectToAction("login", "account");
        }

        [HttpGet]
        [AllowAnonymous]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> Login(LoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                var result = await signInManager.PasswordSignInAsync(
                    model.Email, model.Password, model.RememberMe, false);

                if (result.Succeeded)
                {
                    return RedirectToAction("index", "home");
                }

                ModelState.AddModelError(string.Empty, "Invalid Login Attempt");
            }

            return View(model);
        }


        [HttpGet]
        public async Task<IActionResult> UserList()
        {
            var model = new List<UserRoleViewModel>();

            //foreach (var user in userManager.Users)
            //{
            //    var userRoleViewModel = new UserRoleViewModel
            //    {
            //        UserId = user.Id,
            //        UserName = user.UserName
            //    };

            //    model.Add(userRoleViewModel);
            //}
            var groupUsers = await userManager.GetUsersInRoleAsync(Enum.GetName(typeof(CustomRole), CustomRole.Profile));

            foreach (var user in groupUsers)
            {
                var userRoleViewModel = new UserRoleViewModel
                {
                    UserId = user.Id,
                    UserName = user.UserName
                };

                model.Add(userRoleViewModel);
            }

            return View(model);
        }
    }
}
