using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using KalyanamMatrimony.Models;
using KalyanamMatrimony.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace KalyanamMatrimony.Controllers
{
    [Authorize]
    public class ProfileController : BaseController
    {
        private readonly UserManager<ApplicationUser> userManager;
        private readonly SignInManager<ApplicationUser> signInManager;
        private readonly RoleManager<IdentityRole> roleManager;
        private readonly IMatrimonyRepository matrimonyRepository;
        private readonly IHostingEnvironment hostingEnvironment;
        private readonly ILogger<ProfileController> logger;
        private readonly IEmailSender emailSender;
        private readonly IConfiguration configuration;

        public ProfileController(UserManager<ApplicationUser> userManager,
                                SignInManager<ApplicationUser> signInManager,
                                RoleManager<IdentityRole> roleManager,
                                IMatrimonyRepository matrimonyRepository,
                                IHostingEnvironment hostingEnvironment,
                                ILogger<ProfileController> logger,
                                IEmailSender emailSender,
                                IConfiguration configuration)
        {
            this.userManager = userManager;
            this.signInManager = signInManager;
            this.roleManager = roleManager;
            this.matrimonyRepository = matrimonyRepository;
            this.hostingEnvironment = hostingEnvironment;
            this.logger = logger;
            this.emailSender = emailSender;
            this.configuration = configuration;
        }

        [Authorize(Roles = "SuperAdmin, Admin")]
        public async Task<IActionResult> Index()
        {
            //Active Profiles Only
            ToasterServiceDisplay();
            ProfilesViewModel profilesViewModel = new ProfilesViewModel();
            int orgId = GetSessionOrgId();
            profilesViewModel.ActiveProfiles = matrimonyRepository.GetActiveProfiles(orgId);
            profilesViewModel.DeActivedProfiles = matrimonyRepository.GetDeActivedProfiles(orgId);
            return View(profilesViewModel);
        }

        [Authorize(Roles = "SuperAdmin, Admin")]
        [HttpGet]
        public IActionResult CreateProfile()
        {
            return View();
        }

        [Authorize(Roles = "SuperAdmin, Admin")]
        [HttpPost]
        public async Task<IActionResult> CreateProfile(UserProfileViewModel model)
        {
            if (ModelState.IsValid)
            {
                string orgType = configuration.GetSection("OrgConfiguration").GetSection("OrgType").Value;
                //bool isValidLicense = IsValidLicense(orgType);
                //if(!isValidLicense)
                //{
                //    ModelState.AddModelError("", "Your license is expired!!! Please renew your license.");
                //    return RedirectToAction("UpdateLicense", "Account");
                //}

                //assign Role to user
                var role = await roleManager.FindByNameAsync(model.UserRole);
                if (role == null)
                {
                    ModelState.AddModelError(string.Empty, $"Role = {model.UserRole} not be found! Unable to add user");
                    return View(model);
                }

                // Copy data from RegisterViewModel to IdentityUser
                var user = new ApplicationUser();
                user.UserName = model.Email;
                user.Email = model.Email;
                if (model.EndDate != null)
                {
                    user.EndDate = model.EndDate;
                }
                user.OrgId = GetSessionOrgId();

                // Store user data in AspNetUsers database table
                var result = await userManager.CreateAsync(user, model.Password);

                // If user is successfully created, sign-in the user using
                // SignInManager and redirect to index action of HomeController
                if (result.Succeeded)
                {
                    var roleResult = await userManager.AddToRoleAsync(user, model.UserRole);
                    if (roleResult.Succeeded)
                    {
                        //Generate token for confirmation
                        var token = await userManager.GenerateEmailConfirmationTokenAsync(user);
                        var confirmationLink = Url.Action("ConfirmEmail", "Account", new { userId = user.Id, token = token }, Request.Scheme);

                        // Log the password reset link
                        logger.Log(LogLevel.Warning, confirmationLink);
                        await SendEmail(model.Email, confirmationLink, "Email Confirmation");

                        model.UserId = user.Id;
                        if (model.PhotoFile1 != null && model.PhotoFile1.Length > 0)
                        {
                            model.Photo1 = UploadImage(model.PhotoFile1);
                        }
                        if (model.PhotoFile2 != null && model.PhotoFile2.Length > 0)
                        {
                            model.Photo2 = UploadImage(model.PhotoFile2);
                        }
                        if (model.PhotoFile3 != null && model.PhotoFile3.Length > 0)
                        {
                            model.Photo3 = UploadImage(model.PhotoFile3);
                        }

                        var repoResult = matrimonyRepository.AddProfile(CreateProfileModel(model));

                        if (repoResult == null)
                        {
                            //Delete the created images
                            if (model.PhotoFile1 != null && model.PhotoFile1.Length > 0)
                            {
                                DeleteImage(model.Photo1);
                            }
                            if (model.PhotoFile2 != null && model.PhotoFile2.Length > 0)
                            {
                                DeleteImage(model.Photo2);
                            }
                            if (model.PhotoFile3 != null && model.PhotoFile3.Length > 0)
                            {
                                DeleteImage(model.Photo3);
                            }

                            ModelState.AddModelError(string.Empty, "Unable to create profile");
                            ToasterServiceCreate(model.FirstName + " unable to create profile", CustomEnums.ToastType.Error);
                        }
                        else
                        {
                            //ToasterServiceCreate(model.FirstName + " profile added successfully", CustomEnums.ToastType.Success);
                            ToasterServiceCreate(model.FirstName + " profile added successfully" + " Please ask user to check email to verify account.", CustomEnums.ToastType.Info);
                            return RedirectToAction("index", "profile");
                        }
                    }
                    else
                    {
                        // If there are any errors, add them to the ModelState object
                        // which will be displayed by the validation summary tag helper
                        foreach (var error in roleResult.Errors)
                        {
                            ModelState.AddModelError(string.Empty, error.Description);
                            ToasterServiceCreate(error.Description, CustomEnums.ToastType.Error);
                        }
                    }
                }
                else
                {
                    // If there are any errors, add them to the ModelState object
                    // which will be displayed by the validation summary tag helper
                    foreach (var error in result.Errors)
                    {
                        logger.Log(LogLevel.Error, error.Description);
                        ModelState.AddModelError(string.Empty, error.Description);
                        ToasterServiceCreate(error.Description, CustomEnums.ToastType.Error);
                    }
                }
            }

            return View(model);
        }

        [Authorize(Roles = "SuperAdmin, Admin")]
        [HttpGet]
        public async Task<IActionResult> EditProfile(string id)
        {
            ToasterServiceDisplay();

            Profile profile = matrimonyRepository.GetProfileById(id);
            ApplicationUser userData = await userManager.FindByIdAsync(profile.UserId);
            EditUserProfileViewModel userProfileViewModel = EditUserProfileViewModel(profile);
            userProfileViewModel.Email = userData.Email;
            userProfileViewModel.EndDate = userData.EndDate;
            userProfileViewModel.ExistingPhotoPath1 = userProfileViewModel.Photo1;
            userProfileViewModel.ExistingPhotoPath2 = userProfileViewModel.Photo2;
            userProfileViewModel.ExistingPhotoPath3 = userProfileViewModel.Photo3;

            return View(userProfileViewModel);
        }

        [Authorize(Roles = "SuperAdmin, Admin")]
        [HttpPost]
        public async Task<IActionResult> EditProfile(EditUserProfileViewModel model)
        {
            if (ModelState.IsValid)
            {
                if (model.EndDate != null)
                {
                    ApplicationUser user = await userManager.FindByIdAsync(model.UserId);
                    if (user.EndDate != model.EndDate)
                    {
                        user.EndDate = model.EndDate;
                        var result = await userManager.UpdateAsync(user);

                        if (!result.Succeeded)
                        {
                            foreach (var error in result.Errors)
                            {
                                logger.Log(LogLevel.Error, error.Description);
                                ModelState.AddModelError(string.Empty, error.Description);
                                ToasterServiceCreate(error.Description, CustomEnums.ToastType.Error);
                            }
                        }
                    }
                }

                if (model.PhotoFile1 != null && model.PhotoFile1.Length > 0)
                {
                    model.Photo1 = UploadImage(model.PhotoFile1);
                    if (model.ExistingPhotoPath1 != null)
                    {
                        DeleteImage(model.ExistingPhotoPath1);
                    }
                }
                else
                {
                    model.Photo1 = model.ExistingPhotoPath1;
                }
                if (model.PhotoFile2 != null && model.PhotoFile2.Length > 0)
                {
                    model.Photo2 = UploadImage(model.PhotoFile2);
                    if (model.ExistingPhotoPath2 != null)
                    {
                        DeleteImage(model.ExistingPhotoPath2);
                    }
                }
                else
                {
                    model.Photo2 = model.ExistingPhotoPath2;
                }
                if (model.PhotoFile3 != null && model.PhotoFile3.Length > 0)
                {
                    model.Photo3 = UploadImage(model.PhotoFile3);
                    if (model.ExistingPhotoPath3 != null)
                    {
                        DeleteImage(model.ExistingPhotoPath3);
                    }
                }
                else
                {
                    model.Photo3 = model.ExistingPhotoPath3;
                }

                var repoResult = matrimonyRepository.UpdateProfile(EditUserProfileViewModel(model));

                if (repoResult == null)
                {
                    //Delete the created images
                    if (model.PhotoFile1 != null && model.PhotoFile1.Length > 0)
                    {
                        DeleteImage(model.Photo1);
                    }
                    if (model.PhotoFile2 != null && model.PhotoFile2.Length > 0)
                    {
                        DeleteImage(model.Photo2);
                    }
                    if (model.PhotoFile3 != null && model.PhotoFile3.Length > 0)
                    {
                        DeleteImage(model.Photo3);
                    }

                    logger.Log(LogLevel.Error, "Unable to update profile");
                    ModelState.AddModelError(string.Empty, "Unable to update profile");
                    ToasterServiceCreate(model.FirstName + " unable to update profile", CustomEnums.ToastType.Error);
                }
                else
                {
                    ToasterServiceCreate(model.FirstName + " profile updated successfully", CustomEnums.ToastType.Success);
                    return RedirectToAction("viewprofile", "profile", new { id = model.ProfileId });
                }
            }

            return View(model);
        }

        [Authorize]
        [HttpGet]
        public async Task<IActionResult> ViewProfile(string id)
        {
            ToasterServiceDisplay();

            if (!string.IsNullOrEmpty(id))
            {
                Profile profile = matrimonyRepository.GetProfileById(id);
                ApplicationUser userData = await userManager.FindByIdAsync(profile.UserId);
                EditUserProfileViewModel userProfileViewModel = EditUserProfileViewModel(profile);
                userProfileViewModel.Email = userData.Email;
                userProfileViewModel.EndDate = userData.EndDate;
                userProfileViewModel.ExistingPhotoPath1 = userProfileViewModel.Photo1;
                userProfileViewModel.ExistingPhotoPath2 = userProfileViewModel.Photo2;
                userProfileViewModel.ExistingPhotoPath3 = userProfileViewModel.Photo3;
                userProfileViewModel.profileImages = new List<string>();

                if (userProfileViewModel.Photo1 != null)
                {
                    userProfileViewModel.profileImages.Add(userProfileViewModel.Photo1);
                }
                if (userProfileViewModel.Photo2 != null)
                {
                    userProfileViewModel.profileImages.Add(userProfileViewModel.Photo2);
                }
                if (userProfileViewModel.Photo3 != null)
                {
                    userProfileViewModel.profileImages.Add(userProfileViewModel.Photo3);
                }

                return View(userProfileViewModel);
            }

            return RedirectToAction("NotFound", "Error", new { statusCode = 404 });
        }

        [Authorize]
        [HttpGet]
        public async Task<IActionResult> ViewMyProfile(string id)
        {
            ToasterServiceDisplay();
            Profile profile = null;

            if (string.IsNullOrEmpty(id))
            {
                string currentUserId = GetSessionUserId();
                profile = matrimonyRepository.GetProfileByUserId(currentUserId);
            }
            else
            {
                profile = matrimonyRepository.GetProfileById(id);
            }

            EditUserProfileViewModel userProfileViewModel = new EditUserProfileViewModel();

            if (profile != null)
            {
                userProfileViewModel = EditUserProfileViewModel(profile);
                //userProfileViewModel.Email = userData.Email;
                //userProfileViewModel.EndDate = userData.EndDate;
                userProfileViewModel.ExistingPhotoPath1 = userProfileViewModel.Photo1;
                userProfileViewModel.ExistingPhotoPath2 = userProfileViewModel.Photo2;
                userProfileViewModel.ExistingPhotoPath3 = userProfileViewModel.Photo3;
                userProfileViewModel.profileImages = new List<string>();

                if (userProfileViewModel.Photo1 != null)
                {
                    userProfileViewModel.profileImages.Add(userProfileViewModel.Photo1);
                }
                if (userProfileViewModel.Photo2 != null)
                {
                    userProfileViewModel.profileImages.Add(userProfileViewModel.Photo2);
                }
                if (userProfileViewModel.Photo3 != null)
                {
                    userProfileViewModel.profileImages.Add(userProfileViewModel.Photo3);
                }
            }

            return View(userProfileViewModel);
        }

        [Authorize]
        [HttpGet]
        public async Task<IActionResult> EditMyProfile()
        {
            ToasterServiceDisplay();

            string currentUserId = GetSessionUserId();
            ApplicationUser userData = await userManager.FindByIdAsync(currentUserId);
            Profile profile = matrimonyRepository.GetProfileByUserId(currentUserId);
            EditUserProfileViewModel userProfileViewModel = new EditUserProfileViewModel();

            if (profile != null)
            {
                userProfileViewModel = EditUserProfileViewModel(profile);
                userProfileViewModel.Email = userData.Email;
                userProfileViewModel.EndDate = userData.EndDate;
                userProfileViewModel.ExistingPhotoPath1 = userProfileViewModel.Photo1;
                userProfileViewModel.ExistingPhotoPath2 = userProfileViewModel.Photo2;
                userProfileViewModel.ExistingPhotoPath3 = userProfileViewModel.Photo3;
                userProfileViewModel.profileImages = new List<string>();

                if (userProfileViewModel.Photo1 != null)
                {
                    userProfileViewModel.profileImages.Add(userProfileViewModel.Photo1);
                }
                if (userProfileViewModel.Photo2 != null)
                {
                    userProfileViewModel.profileImages.Add(userProfileViewModel.Photo2);
                }
                if (userProfileViewModel.Photo3 != null)
                {
                    userProfileViewModel.profileImages.Add(userProfileViewModel.Photo3);
                }
            }

            return View(userProfileViewModel);
        }

        [Authorize]
        [HttpPost]
        public async Task<IActionResult> EditMyProfile(EditUserProfileViewModel model)
        {
            if (ModelState.IsValid)
            {
                if (model.EndDate != null)
                {
                    ApplicationUser user = await userManager.FindByIdAsync(model.UserId);
                    if (user.EndDate != model.EndDate)
                    {
                        user.EndDate = model.EndDate;
                        var result = await userManager.UpdateAsync(user);

                        if (!result.Succeeded)
                        {
                            foreach (var error in result.Errors)
                            {
                                logger.Log(LogLevel.Error, error.Description);
                                ModelState.AddModelError(string.Empty, error.Description);
                                ToasterServiceCreate(error.Description, CustomEnums.ToastType.Error);
                            }
                        }
                    }
                }

                if (model.PhotoFile1 != null && model.PhotoFile1.Length > 0)
                {
                    model.Photo1 = UploadImage(model.PhotoFile1);
                    if (model.ExistingPhotoPath1 != null)
                    {
                        DeleteImage(model.ExistingPhotoPath1);
                    }
                }
                else
                {
                    model.Photo1 = model.ExistingPhotoPath1;
                }
                if (model.PhotoFile2 != null && model.PhotoFile2.Length > 0)
                {
                    model.Photo2 = UploadImage(model.PhotoFile2);
                    if (model.ExistingPhotoPath2 != null)
                    {
                        DeleteImage(model.ExistingPhotoPath2);
                    }
                }
                else
                {
                    model.Photo2 = model.ExistingPhotoPath2;
                }
                if (model.PhotoFile3 != null && model.PhotoFile3.Length > 0)
                {
                    model.Photo3 = UploadImage(model.PhotoFile3);
                    if (model.ExistingPhotoPath3 != null)
                    {
                        DeleteImage(model.ExistingPhotoPath3);
                    }
                }
                else
                {
                    model.Photo3 = model.ExistingPhotoPath3;
                }

                var repoResult = matrimonyRepository.UpdateProfile(EditUserProfileViewModel(model));

                if (repoResult == null)
                {
                    //Delete the created images
                    if (model.PhotoFile1 != null && model.PhotoFile1.Length > 0)
                    {
                        DeleteImage(model.Photo1);
                    }
                    if (model.PhotoFile2 != null && model.PhotoFile2.Length > 0)
                    {
                        DeleteImage(model.Photo2);
                    }
                    if (model.PhotoFile3 != null && model.PhotoFile3.Length > 0)
                    {
                        DeleteImage(model.Photo3);
                    }

                    logger.Log(LogLevel.Error, model.Email + " Unable to update profile");
                    ModelState.AddModelError(string.Empty, "Unable to update profile");
                    ToasterServiceCreate(model.FirstName + " unable to update profile", CustomEnums.ToastType.Error);
                }
                else
                {
                    ToasterServiceCreate(model.FirstName + " profile updated successfully", CustomEnums.ToastType.Success);
                    return RedirectToAction("viewmyprofile", "profile");
                }
            }

            return View(model);
        }

        private string GenerateProfileNumber()
        {
            return "PROF_" + String.Format("{0:d9}", (DateTime.Now.Ticks / 10) % 1000000000);
        }

        private string UploadImage(IFormFile imageFile)
        {
            string uniqueFileName;

            string uploadsFolder = Path.Combine(hostingEnvironment.WebRootPath, "images");
            uniqueFileName = Guid.NewGuid().ToString() + "_" + imageFile.FileName;
            string filePath = Path.Combine(uploadsFolder, uniqueFileName);

            using (var fileStream = new FileStream(filePath, FileMode.Create))
            {
                imageFile.CopyTo(fileStream);
            }

            return uniqueFileName;
        }

        private void DeleteImage(string uniqueFileName)
        {
            string uploadsFolder = Path.Combine(hostingEnvironment.WebRootPath, "images");
            string filePath = Path.Combine(uploadsFolder, uniqueFileName);
            if (System.IO.File.Exists(filePath))
                System.IO.File.Delete(filePath);
        }

        private Profile CreateProfileModel(UserProfileViewModel model)
        {
            Profile profile = new Profile();
            profile.FirstName = model.FirstName;
            profile.LastName = model.LastName;

            if (model.ProfileId == null)
            {
                profile.UserId = model.UserId;
                profile.ProfileId = GenerateProfileNumber();
            }

            profile.Age = model.Age;
            profile.DateOfBirth = model.DateOfBirth;
            profile.Gender = model.Gender;
            profile.Height = model.Height;
            profile.MaritalStatus = model.MaritalStatus;
            profile.HaveChildren = model.HaveChildren;
            profile.BodyType = model.BodyType;
            profile.Complexion = model.Complexion;
            profile.MotherTongue = model.MotherTongue;
            profile.Religion = model.Religion;
            profile.Caste = model.Caste;
            profile.SubCaste = model.SubCaste;
            profile.Diet = model.Diet;
            profile.Smoke = model.Smoke;
            profile.Drink = model.Drink;
            profile.AboutYourself = model.AboutYourself;
            profile.BloodGroup = model.BloodGroup;
            profile.CurrentLocation = model.CurrentLocation;
            profile.SpokenLanguages = model.SpokenLanguages;

            //Education Info
            profile.Education = model.Education;
            profile.University = model.University;
            profile.Profession = model.Profession;
            profile.AnnualIncome = model.AnnualIncome;
            profile.WorkingAt = model.WorkingAt;

            //Family Info
            profile.FatherName = model.FatherName;
            profile.MotherName = model.MotherName;
            profile.FatherOccupation = model.FatherOccupation;
            profile.MotherOccupation = model.MotherOccupation;
            profile.Brothers = model.Brothers;
            profile.MarriedBrothers = model.MarriedBrothers;
            profile.Sisters = model.Sisters;
            profile.MarriedSisters = model.MarriedSisters;
            profile.FamilyValues = model.FamilyValues;
            profile.AboutFamily = model.AboutFamily;

            //Hobbies
            profile.Hobbies = model.Hobbies;
            profile.FavoriteMusic = model.FavoriteMusic;
            profile.FavoriteMovies = model.FavoriteMovies;
            profile.FavoriteCuisine = model.FavoriteCuisine;
            profile.Sports = model.Sports;
            profile.PreferredDress = model.PreferredDress;

            //Horoscope
            profile.Gothram = model.Gothram;
            profile.Rasi = model.Rasi;
            profile.Nakshatram = model.Nakshatram;
            profile.Manglik = model.Manglik;
            profile.AstroProfile = model.AstroProfile;

            //Photos
            profile.Photo1 = model.Photo1;
            profile.Photo2 = model.Photo2;
            profile.Photo3 = model.Photo3;

            //ContactInfo
            profile.PhoneNumber = model.PhoneNumber;
            profile.ContactPersonName = model.ContactPersonName;
            profile.ContactPersonRelationShip = model.ContactPersonRelationShip;

            profile.CreatedDate = DateTime.Now;

            return profile;
        }

        private EditUserProfileViewModel EditUserProfileViewModel(Profile model)
        {
            EditUserProfileViewModel profile = new EditUserProfileViewModel();
            profile.FirstName = model.FirstName;
            profile.LastName = model.LastName;
            profile.UserId = model.UserId;
            profile.ProfileId = model.ProfileId;

            profile.Age = model.Age;
            profile.DateOfBirth = model.DateOfBirth;
            profile.Gender = model.Gender;
            profile.Height = model.Height;
            profile.MaritalStatus = model.MaritalStatus;
            profile.HaveChildren = model.HaveChildren;
            profile.BodyType = model.BodyType;
            profile.Complexion = model.Complexion;
            profile.MotherTongue = model.MotherTongue;
            profile.Religion = model.Religion;
            profile.Caste = model.Caste;
            profile.SubCaste = model.SubCaste;
            profile.Diet = model.Diet;
            profile.Smoke = model.Smoke;
            profile.Drink = model.Drink;
            profile.AboutYourself = model.AboutYourself;
            profile.BloodGroup = model.BloodGroup;
            profile.CurrentLocation = model.CurrentLocation;
            profile.SpokenLanguages = model.SpokenLanguages;

            //Education Info
            profile.Education = model.Education;
            profile.University = model.University;
            profile.Profession = model.Profession;
            profile.AnnualIncome = model.AnnualIncome;
            profile.WorkingAt = model.WorkingAt;

            //Family Info
            profile.FatherName = model.FatherName;
            profile.MotherName = model.MotherName;
            profile.FatherOccupation = model.FatherOccupation;
            profile.MotherOccupation = model.MotherOccupation;
            profile.Brothers = model.Brothers;
            profile.MarriedBrothers = model.MarriedBrothers;
            profile.Sisters = model.Sisters;
            profile.MarriedSisters = model.MarriedSisters;
            profile.FamilyValues = model.FamilyValues;
            profile.AboutFamily = model.AboutFamily;

            //Hobbies
            profile.Hobbies = model.Hobbies;
            profile.FavoriteMusic = model.FavoriteMusic;
            profile.FavoriteMovies = model.FavoriteMovies;
            profile.FavoriteCuisine = model.FavoriteCuisine;
            profile.Sports = model.Sports;
            profile.PreferredDress = model.PreferredDress;

            //Horoscope
            profile.Gothram = model.Gothram;
            profile.Rasi = model.Rasi;
            profile.Nakshatram = model.Nakshatram;
            profile.Manglik = model.Manglik;
            profile.AstroProfile = model.AstroProfile;

            //Photos
            profile.Photo1 = model.Photo1;
            profile.Photo2 = model.Photo2;
            profile.Photo3 = model.Photo3;

            //ContactInfo
            profile.PhoneNumber = model.PhoneNumber;
            profile.ContactPersonName = model.ContactPersonName;
            profile.ContactPersonRelationShip = model.ContactPersonRelationShip;

            profile.strDateOfBirth = model.DateOfBirth != null ? model.DateOfBirth.Value.ToString("dd/MMM/yyyy") : "";
            profile.strHaveChildren = model.HaveChildren == true ? "Yes" : "No";

            return profile;
        }

        [Authorize]
        [HttpGet]
        public async Task<IActionResult> Search()
        {
            List<Profile> profilesList = new List<Profile>();
            string userRole = GetSessionUserRole();
            string userId = GetSessionUserId();
            int orgId = GetSessionOrgId();

            var strSuperAdminRole = Enum.GetName(typeof(CustomEnums.CustomRole), CustomEnums.CustomRole.SuperAdmin);
            var strAdminRole = Enum.GetName(typeof(CustomEnums.CustomRole), CustomEnums.CustomRole.Admin);

            if (userRole == strSuperAdminRole)
            {
                profilesList = matrimonyRepository.GetAllProfilesForSuperAdmin().ToList();
                return View(profilesList);
            }
            else if (userRole == strAdminRole)
            {
                profilesList = matrimonyRepository.GetAllActiveProfilesForAdmin(orgId).ToList();
                return View(profilesList);
            }

            var userProfile = matrimonyRepository.GetProfileByUserId(userId);
            if (userProfile != null)
            {
                if (userProfile.Gender == CustomEnums.ProfileGender.Male)
                {
                    profilesList = matrimonyRepository.GetAllFemaleProfiles(orgId).ToList();
                }
                else if (userProfile.Gender == CustomEnums.ProfileGender.Female)
                {
                    profilesList = matrimonyRepository.GetAllMaleProfiles(orgId).ToList();
                }
            }

            return View(profilesList);
        }

        [Authorize]
        [HttpGet]
        public IActionResult ViewSearchProfile(string id)
        {
            if (!string.IsNullOrEmpty(id))
            {
                Profile profile = matrimonyRepository.GetProfileById(id);
                EditUserProfileViewModel userProfileViewModel = new EditUserProfileViewModel();

                if (profile != null)
                {
                    userProfileViewModel = EditUserProfileViewModel(profile);
                    userProfileViewModel.ExistingPhotoPath1 = userProfileViewModel.Photo1;
                    userProfileViewModel.ExistingPhotoPath2 = userProfileViewModel.Photo2;
                    userProfileViewModel.ExistingPhotoPath3 = userProfileViewModel.Photo3;
                    userProfileViewModel.profileImages = new List<string>();

                    if (userProfileViewModel.Photo1 != null)
                    {
                        userProfileViewModel.profileImages.Add(userProfileViewModel.Photo1);
                    }
                    if (userProfileViewModel.Photo2 != null)
                    {
                        userProfileViewModel.profileImages.Add(userProfileViewModel.Photo2);
                    }
                    if (userProfileViewModel.Photo3 != null)
                    {
                        userProfileViewModel.profileImages.Add(userProfileViewModel.Photo3);
                    }

                    return View(userProfileViewModel);
                }
            }

            return RedirectToAction("NotFound", "Error");
        }

        [Authorize(Roles = "SuperAdmin, Admin")]
        [HttpPost]
        public async Task<IActionResult> DeleteProfile(string userId)
        {
            //string userIds = HttpContext.Request.Query["userId"].ToString();
            if (string.IsNullOrEmpty(userId))
            {
                ModelState.AddModelError(string.Empty, "Invalid Request");
                return RedirectToAction("ViewProfile", "Profile", new { id = userId });
            }
            else
            {
                var user = await userManager.FindByIdAsync(userId);
                if (user == null)
                {
                    return RedirectToAction("NotFound", "Error", new { statusCode = 404 });
                }
                else
                {
                    //Get User and Profile Details
                    var profile = matrimonyRepository.GetProfileByUserId(userId);

                    //Delete images - DONE
                    if (!string.IsNullOrEmpty(profile.Photo1))
                    {
                        DeleteImage(profile.Photo1);
                    }
                    if (!string.IsNullOrEmpty(profile.Photo2))
                    {
                        DeleteImage(profile.Photo2);
                    }
                    if (!string.IsNullOrEmpty(profile.Photo3))
                    {
                        DeleteImage(profile.Photo3);
                    }

                    //Delete Profile
                    matrimonyRepository.DeleteProfileById(profile.ProfileId);
                    //Delete UserRole
                    var roles = await userManager.GetRolesAsync(user);
                    var result = await userManager.RemoveFromRolesAsync(user, roles);
                    if (!result.Succeeded)
                    {
                        logger.Log(LogLevel.Error, "Cannot remove user existing roles");
                        ModelState.AddModelError("", "Cannot remove user existing roles");
                        return RedirectToAction("NotFound", "Error", new { statusCode = 404 });
                    }
                    else
                    {
                        //Delete User
                        var resultUser = await userManager.DeleteAsync(user);

                        if (!resultUser.Succeeded)
                        {
                            logger.Log(LogLevel.Error, "Cannot remove user");
                            ModelState.AddModelError("", "Cannot remove user");
                            return RedirectToAction("NotFound", "Error", new { statusCode = 404 });
                        }
                        else
                        {
                            ToasterServiceCreate("Profile deleted successfully", CustomEnums.ToastType.Success);
                            return RedirectToAction("index", "profile");
                        }
                    }
                }
            }
        }

        private async Task SendEmail(string email, string encryptedLink, string subject)
        {
            var content = "";
             if (subject.Contains("Email Confirmation"))
            {
                content = "Hi " + email + ", <br/><br/>" +
                    "Thank you for signing up with our portal! You must follow this link to activate your account:<br/><br/>" +
                    "<a href='" + encryptedLink + "' >Confirm your email</a><br/><br/>" +
                    "Happy Matrimony!!!<br/><br/>" +
                    "Regards<br/>" +
                    "The Matrimony Team";
            }

            var message = new Message(new string[] { email }, subject, content);
            await emailSender.SendEmailAsync(message);
        }
    }
}
