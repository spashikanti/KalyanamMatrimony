using KalyanamMatrimony.Models;
using KalyanamMatrimony.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace KalyanamMatrimony.Controllers
{
    [Authorize(Roles ="SuperAdmin, Admin")]
    public class AdminController : BaseController
    {
        private readonly UserManager<ApplicationUser> userManager;
        private readonly SignInManager<ApplicationUser> signInManager;
        private readonly RoleManager<IdentityRole> roleManager;
        private readonly ILogger<AccountController> logger;
        private readonly IEmailSender emailSender;
        private readonly IMatrimonyRepository matrimonyRepository;
        private readonly IConfiguration configuration;

        public AdminController(UserManager<ApplicationUser> userManager,
                                SignInManager<ApplicationUser> signInManager,
                                RoleManager<IdentityRole> roleManager,
                                ILogger<AdminController> logger,
                                IEmailSender emailSender,
                                IMatrimonyRepository matrimonyRepository,
                                IConfiguration configuration)
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

        [HttpGet]
        public async Task<IActionResult> ViewAssistant()
        {
            //Active Profiles Only
            ToasterServiceDisplay();
            AssistantListViewModel model = new AssistantListViewModel();
            int orgId = GetSessionOrgId();
            model.ActiveAssistants = await GetAdminAssistantUsers(matrimonyRepository.GetActiveAdminAssitants(orgId));
            model.DeActivedAssistants = await GetAdminAssistantUsers(matrimonyRepository.GetDeActivedAdminAssitants(orgId));
            return View(model);
        }

        private async Task<IList<AssistantViewModel>> GetAdminAssistantUsers(IEnumerable<AssistantViewModel> users)
        {
            string userRole = Enum.GetName(typeof(CustomEnums.CustomRole), CustomEnums.CustomRole.AdminAssistant);
            IList<ApplicationUser> adminAssistantUsers = await userManager.GetUsersInRoleAsync(userRole);
            List<AssistantViewModel> filteredUsers = users.Where(user => adminAssistantUsers.Any(aUser => aUser.Id == user.UserId)).ToList();
            return filteredUsers;
        }

        [HttpGet]
        public async Task<IActionResult> CreateAssistant()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateAssistant(AssistantViewModel model)
        {
            if (ModelState.IsValid)
            {
                //Insert Data Into User Table with OrgId
                //assign Role to user
                var strRole = model.UserRole;
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
                user.OrgId = GetSessionOrgId();
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
                    var roleResult = await userManager.AddToRoleAsync(user, strRole);
                    if (roleResult.Succeeded)
                    {
                        //Generate token for confirmation
                        var token = await userManager.GenerateEmailConfirmationTokenAsync(user);
                        var confirmationLink = Url.Action("ConfirmEmail", "Account", new { userId = user.Id, token = token }, Request.Scheme);

                        // Log the password reset link
                        logger.Log(LogLevel.Warning, confirmationLink);
                        await SendEmail(model.Email, confirmationLink, "Verify your Email");

                        ToasterServiceCreate("Please check your email and click on the confirmation link in the email shared by us.", CustomEnums.ToastType.Info);
                    }
                    else
                    {
                        ModelState.AddModelError(string.Empty, "Unable to Assign Role");
                        ToasterServiceCreate(model.UserRole + " unable to Assign User Role", CustomEnums.ToastType.Error);
                    }
                }
                else
                {
                    ModelState.AddModelError(string.Empty, "Unable to Create User");
                    ToasterServiceCreate(model.Email + " unable to create user", CustomEnums.ToastType.Error);
                }
            }

            return View(model);
        }

        [HttpGet]
        public async Task<IActionResult> EditAssistant(int id)
        {
            //if (id != null)
            //{
            //    ToasterServiceDisplay();
            //    License license = matrimonyRepository.GetLicenseById(id);
            //    return View(license);
            //}

            return RedirectToAction("NotFound", "Error");
        }

        private async Task SendEmail(string email, string encryptedLink, string subject)
        {
            var content = "";
            if (subject.Contains("Verify"))
            {
                content = "Hi " + email + ", <br/><br/>" +
                    "Thank you for signing up with our matrimony services to run your business.<br/> We are excited to provide you industry best standard services.<br/><br/>" +
                    "To activate your account & to start using our services, please click on the below button to verify your email now.<br/><br/>" +
                    "<a href='" + encryptedLink + "'  class='btn btn-success'>Verify your email</a><br/><br/>" +
                    "Happy Matrimony!!!<br/><br/>" +
                    "Regards,<br/>" +
                    "The Matrimony Team.";
            }
            else if (subject.Contains("Reset"))
            {
                content = "Hi " + email + "<br/><br/>" +
                    "We got a request to reset your password.<br/><br/>" +
                    "<a href='" + encryptedLink + "' >Click Here to Reset Password</a><br/><br/>" +
                    "Happy Matrimony!!!<br/><br/>" +
                    "Regards,<br/>" +
                    "The Matrimony Team.";
            }

            var message = new Message(new string[] { email }, subject, content);
            await emailSender.SendEmailAsync(message);
        }
    }
}
