using KalyanamMatrimony.Models;
using KalyanamMatrimony.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

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

        public IActionResult Index()
        {
            ProfilesViewModel profilesViewModel = new ProfilesViewModel();
            profilesViewModel.ActiveProfilesCount = matrimonyRepository.GetActiveProfiles(userManager.Users).Count();
            profilesViewModel.DeActivedProfilesCount = matrimonyRepository.GetDeActivedProfiles(userManager.Users).Count();
            profilesViewModel.MaleProfilesCount = matrimonyRepository.GetAllProfiles().Where(x => x.Gender == CustomEnums.ProfileGender.Male).Count();
            profilesViewModel.FemaleProfilesCount = matrimonyRepository.GetAllProfiles().Where(x => x.Gender == CustomEnums.ProfileGender.Female).Count();
            return View(profilesViewModel);
        }
    }
}
