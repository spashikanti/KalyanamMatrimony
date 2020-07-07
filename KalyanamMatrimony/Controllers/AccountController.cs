using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Threading.Tasks;
using KalyanamMatrimony.Models;
using KalyanamMatrimony.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.Extensions.Logging;
using static KalyanamMatrimony.Models.CustomEnums;

namespace KalyanamMatrimony.Controllers
{
    public class AccountController : BaseController
    {
        private readonly UserManager<ApplicationUser> userManager;
        private readonly SignInManager<ApplicationUser> signInManager;
        private readonly RoleManager<IdentityRole> roleManager;
        private readonly ILogger<AccountController> logger;
        private readonly IEmailSender emailSender;
        private readonly IMatrimonyRepository matrimonyRepository;

        public AccountController(UserManager<ApplicationUser> userManager,
                                SignInManager<ApplicationUser> signInManager,
                                RoleManager<IdentityRole> roleManager,
                                ILogger<AccountController> logger,
                                IEmailSender emailSender,
                                IMatrimonyRepository matrimonyRepository)
        {
            this.userManager = userManager;
            this.signInManager = signInManager;
            this.roleManager = roleManager;
            this.logger = logger;
            this.emailSender = emailSender;
            this.matrimonyRepository = matrimonyRepository;
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

        [Authorize(Roles = "SuperAdmin")]
        [HttpGet]
        public IActionResult CreateUser()
        {
            return View();
        }

        [Authorize(Roles = "SuperAdmin")]
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

        [HttpGet]
        [AllowAnonymous]
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
        public async Task<IActionResult> Login(LoginViewModel model, string returnUrl)
        {
            if (ModelState.IsValid)
            {
                var user = await userManager.FindByEmailAsync(model.Email);

                if (user != null && !user.EmailConfirmed &&(await userManager.CheckPasswordAsync(user, model.Password)))
                {
                    ModelState.AddModelError(string.Empty, "Email not confirmed yet");
                    return View(model);
                }
                if (user != null && (user.EndDate != null && user.EndDate.Value < DateTime.Now) && (await userManager.CheckPasswordAsync(user, model.Password)))
                {
                    ModelState.AddModelError(string.Empty, "Your account is not active, please contact administrator");
                    return View(model);
                }

                var result = await signInManager.PasswordSignInAsync(
                    model.Email, model.Password, model.RememberMe, false);

                if (result.Succeeded)
                {
                    if (!string.IsNullOrEmpty(returnUrl) && Url.IsLocalUrl(returnUrl))
                    {
                        return Redirect(returnUrl);
                    }
                    return RedirectToAction("index", "home");
                }

                ModelState.AddModelError(string.Empty, "Invalid Login Attempt");
            }

            return View(model);
        }

        [Authorize(Roles = "SuperAdmin")]
        [HttpGet]
        public async Task<IActionResult> UserList()
        {
            var model = new List<UserRoleViewModel>();
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

        [AllowAnonymous]
        public async Task<IActionResult> ConfirmEmail(string userId, string token)
        {
            if (userId == null || token == null)
            {
                ViewBag.ErrorTitle = "Invalid Token, Please contact Administrator";
                return View("Error");
            }

            var user = await userManager.FindByIdAsync(userId);
            if (user == null)
            {
                ViewBag.ErrorMessage = $"The User ID {userId} is invalid";
                return View("NotFound");
            }

            var result = await userManager.ConfirmEmailAsync(user, token);
            if (result.Succeeded)
            {
                return View();
            }

            ViewBag.ErrorTitle = "Email cannot be confirmed";
            return View("Error");
        }

        [HttpGet]
        [AllowAnonymous]
        public IActionResult ForgotPassword()
        {
            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> ForgotPassword(ForgotPasswordViewModel model)
        {
            if (ModelState.IsValid)
            {
                // Find the user by email
                var user = await userManager.FindByEmailAsync(model.Email);
                // If the user is found AND Email is confirmed
                if (user != null && await userManager.IsEmailConfirmedAsync(user))
                {
                    // Generate the reset password token
                    var token = await userManager.GeneratePasswordResetTokenAsync(user);

                    // Build the password reset link
                    var passwordResetLink = Url.Action("ResetPassword", "Account",
                            new { email = model.Email, token = token }, Request.Scheme);

                    // Log the password reset link
                    logger.Log(LogLevel.Warning, passwordResetLink);
                    await SendEmail(model.Email, passwordResetLink);

                    // Send the user to Forgot Password Confirmation view
                    return View("ForgotPasswordConfirmation");
                }

                // To avoid account enumeration and brute force attacks, don't
                // reveal that the user does not exist or is not confirmed
                return View("ForgotPasswordConfirmation");
            }

            return View(model);
        }

        private async Task SendEmail(string email, string passwordResetLink)
        {
            var content = "Hi " + email + "<br/><br/>" +
                "We got a request to reset your password. <br/><br/>" +
                "<a href='" + passwordResetLink + "' >Click Here to Reset Password</a><br/><br/>" +
                "<br/><br/>" +
                "The Matrimony Team";
            var message = new Message(new string[] { email }, "Reset Your Password", content);
            //emailSender.SendEmail(message);
            await emailSender.SendEmailAsync(message);
        }

        [HttpGet]
        [AllowAnonymous]
        public IActionResult ResetPassword(string token, string email)
        {
            // If password reset token or email is null, most likely the
            // user tried to tamper the password reset link
            if (token == null || email == null)
            {
                ModelState.AddModelError("", "Invalid password reset token");
            }
            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> ResetPassword(ResetPasswordViewModel model)
        {
            if (ModelState.IsValid)
            {
                // Find the user by email
                var user = await userManager.FindByEmailAsync(model.Email);

                if (user != null)
                {
                    // reset the user password
                    var result = await userManager.ResetPasswordAsync(user, model.Token, model.Password);
                    if (result.Succeeded)
                    {
                        return View("ResetPasswordConfirmation");
                    }
                    // Display validation errors. For example, password reset token already
                    // used to change the password or password complexity rules not met
                    foreach (var error in result.Errors)
                    {
                        ModelState.AddModelError("", error.Description);
                    }
                    return View(model);
                }

                // To avoid account enumeration and brute force attacks, don't
                // reveal that the user does not exist
                return View("ResetPasswordConfirmation");
            }
            // Display validation errors if model state is not valid
            return View(model);
        }

        [HttpGet]
        public IActionResult ChangePassword()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> ChangePassword(ChangePasswordViewModel model)
        {
            if (ModelState.IsValid)
            {
                var user = await userManager.GetUserAsync(User);
                if (user == null)
                {
                    return RedirectToAction("Login");
                }

                // ChangePasswordAsync changes the user password
                var result = await userManager.ChangePasswordAsync(user,
                    model.CurrentPassword, model.NewPassword);

                // The new password did not meet the complexity rules or
                // the current password is incorrect. Add these errors to
                // the ModelState and rerender ChangePassword view
                if (!result.Succeeded)
                {
                    foreach (var error in result.Errors)
                    {
                        ModelState.AddModelError(string.Empty, error.Description);
                    }
                    return View();
                }

                // Upon successfully changing the password refresh sign-in cookie
                await signInManager.RefreshSignInAsync(user);
                ToasterServiceCreate("Password changed successfully", CustomEnums.ToastType.Success);
                ToasterServiceDisplay();
                return View("ChangePasswordConfirmation");
            }

            return View(model);
        }

        [HttpGet]
        [AllowAnonymous]
        public IActionResult AccessDenied()
        {
            return View();
        }

        [HttpGet]
        [AllowAnonymous]
        public IActionResult SignUp()
        {
            //Get License Types, bind to SingUpViewModel
            //SignUpViewModel signUpViewModel = new SignUpViewModel();
            //signUpViewModel.LicenseTypes = new SelectList(new List<string>()); // empty list of anything...
            //ViewBag.LicenseTypes = new Microsoft.AspNetCore.Mvc.Rendering.SelectList(matrimonyRepository.GetAllLicenses(), "LicenseId", "Description");
            ViewBag.LicenseTypes = matrimonyRepository.GetAllLicenses();
            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> SignUp(SignUpViewModel model)
        {
            if (ModelState.IsValid)
            {
                Organisation org = new Organisation();

                if (model.LicenseId > 0)
                {
                    //Calculate End Date for org end date
                    License license = matrimonyRepository.GetLicenseById(model.LicenseId);
                    var NoOfDays = license.MonthsCount * 31;//Converting to Number of Days
                    org.EndDate = DateTime.Now.AddDays(NoOfDays);
                }
                
                org.LicenseId = model.LicenseId;
                org.OrgName = model.OrgName;
                org.OrgDesc = model.OrgDesc;
                org.FullName = model.FullName;
                org.Phone = model.Phone;

                //Insert Data Into Organisation table - get OrgId
                var repoResult = matrimonyRepository.AddOrganisation(org);

                if(repoResult == null)
                {
                    ModelState.AddModelError(string.Empty, "Unable to create org");
                    ToasterServiceCreate(model.OrgName + " unable to create org", CustomEnums.ToastType.Error);

                    ViewBag.LicenseTypes = matrimonyRepository.GetAllLicenses();
                    return View(model);
                }

                //Insert Data Into User Table with OrgId
                //assign Role to user
                var strRole = Enum.GetName(typeof(CustomEnums.CustomRole), model.UserRole);
                var role = await roleManager.FindByNameAsync(strRole);
                if (role == null)
                {
                    ModelState.AddModelError(string.Empty, $"Role = {strRole} not be found! Unable to add user");
                    return View();
                }

                // Copy data from RegisterViewModel to IdentityUser
                var user = new ApplicationUser();
                user.UserName = model.Email;
                user.Email = model.Email;
                user.OrgId = repoResult.OrgId;
                //No end date for admin, he should login for renewal

                // Store user data in AspNetUsers database table
                var result = await userManager.CreateAsync(user, model.Password);

                // If user is successfully created, sign-in the user using
                // SignInManager and redirect to index action of HomeController
                if (result.Succeeded)
                {
                    var roleResult = await userManager.AddToRoleAsync(user, strRole);
                    if (roleResult.Succeeded)
                    {
                        //Generate token for confirmation
                        var token = await userManager.GenerateEmailConfirmationTokenAsync(user);
                        var confirmationLink = Url.Action("ConfirmEmail", "Account", new { userId = user.Id, token = token }, Request.Scheme);

                        // Log the password reset link
                        logger.Log(LogLevel.Warning, confirmationLink);
                        await SendEmail(model.Email, confirmationLink);

                        ToasterServiceCreate("Please check your email and click on the confirmation link in the email shared by us.", CustomEnums.ToastType.Info);
                        return RedirectToAction("acknowledge", "account");
                    }
                    else
                    {
                        ModelState.AddModelError(string.Empty, "Unable to Assign Role");
                        ToasterServiceCreate(model.OrgName + " unable to signup", CustomEnums.ToastType.Error);
                    }
                }
                else
                {
                    ModelState.AddModelError(string.Empty, "Unable to Create User");
                    ToasterServiceCreate(model.OrgName + " unable to signup", CustomEnums.ToastType.Error);
                }
            }

            ViewBag.LicenseTypes = matrimonyRepository.GetAllLicenses();
            return View(model);
        }

        [HttpGet]
        [AllowAnonymous]
        public IActionResult Acknowledge()
        {
            return View();
        }
    }
}
