using KalyanamMatrimony.Models;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using static KalyanamMatrimony.Models.CustomEnums;

namespace KalyanamMatrimony.ViewModels
{
    public class EditUserProfileViewModel : Profile
    {
        public string Email { get; set; }

        public string Password { get; set; }

        [Display(Name = "End Date")]
        public DateTime? EndDate { get; set; }

        public string UserRole { get; set; } = Enum.GetName(typeof(CustomRole), CustomRole.Profile);

        public IFormFile PhotoFile1 { get; set; }
        public IFormFile PhotoFile2 { get; set; }
        public IFormFile PhotoFile3 { get; set; }

        public string ExistingPhotoPath1 { get; set; }
        public string ExistingPhotoPath2 { get; set; }
        public string ExistingPhotoPath3 { get; set; }

        public List<string> profileImages { get; set; }

        public string strDateOfBirth { get; set; }
        public string strHaveChildren { get; set; }
    }
}
