using KalyanamMatrimony.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.ComponentModel.DataAnnotations;
using static KalyanamMatrimony.Models.CustomEnums;

namespace KalyanamMatrimony.ViewModels
{
    public class UserProfileViewModel : Profile
    {
        [Required]
        [EmailAddress]
        [Remote(action: "IsEmailInUse", controller: "Account")]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirm password")]
        [Compare("Password",
            ErrorMessage = "Password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }

        [Display(Name = "End Date")]
        public DateTime? EndDate { get; set; }

        public string UserRole { get; set; } = Enum.GetName(typeof(CustomRole), CustomRole.Profile);

        public IFormFile PhotoFile1 { get; set; }
        public IFormFile PhotoFile2 { get; set; }
        public IFormFile PhotoFile3 { get; set; }

        public string ExistingPhotoPath1 { get; set; }
        public string ExistingPhotoPath2 { get; set; }
        public string ExistingPhotoPath3 { get; set; }
    }
}
