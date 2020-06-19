using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Transactions;
using KalyanamMatrimony.Models;
using KalyanamMatrimony.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
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
        private readonly IHostingEnvironment hostingEnvironment;

        public ProfileController(UserManager<ApplicationUser> userManager,
                                SignInManager<ApplicationUser> signInManager,
                                RoleManager<IdentityRole> roleManager,
                                IMatrimonyRepository matrimonyRepository,
                                IHostingEnvironment hostingEnvironment)
        {
            this.userManager = userManager;
            this.signInManager = signInManager;
            this.roleManager = roleManager;
            this.matrimonyRepository = matrimonyRepository;
            this.hostingEnvironment = hostingEnvironment;
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

                        var repoResult = matrimonyRepository.Add(CreateProfileModel(model));

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

                            ModelState.AddModelError(string.Empty, "Unable to create profile!!!");
                        }
                        else
                        {
                            return RedirectToAction("index", "home");
                        }
                    }
                    else
                    {
                        // If there are any errors, add them to the ModelState object
                        // which will be displayed by the validation summary tag helper
                        foreach (var error in roleResult.Errors)
                        {
                            ModelState.AddModelError(string.Empty, error.Description);
                        }
                    }
                }
                else
                {
                    // If there are any errors, add them to the ModelState object
                    // which will be displayed by the validation summary tag helper
                    foreach (var error in result.Errors)
                    {
                        ModelState.AddModelError(string.Empty, error.Description);
                    }
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
            if(System.IO.File.Exists(filePath))
                System.IO.File.Delete(filePath);
        }

        private Profile CreateProfileModel(UserProfileViewModel model)
        {
            Profile profile = new Profile();
            profile.FirstName = model.FirstName;
            profile.LastName = model.LastName;
            profile.UserId = model.UserId;
            profile.ProfileId = GenerateProfileNumber();

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

            return profile;
        }
    }
}
