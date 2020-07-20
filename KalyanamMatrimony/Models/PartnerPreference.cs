using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using static KalyanamMatrimony.Models.CustomEnums;

namespace KalyanamMatrimony.Models
{
    public class PartnerPreference
    {
        public int PartnerPreferenceId { get; set; }
        //UserInfo
        [Display(Name = "Profile Id")]
        public string ProfileId { get; set; }
        public string UserId { get; set; }
        [Display(Name = "Age From")]
        public int? AgeFrom { get; set; } = 0;
        [Display(Name = "Age To")]
        public int? AgeTo { get; set; } = 0;
        public ProfileGender? Gender { get; set; } = ProfileGender.None;
        [Display(Name = "Height From")]
        public float? HeightFrom { get; set; } = 0;
        [Display(Name = "Height To")]
        public float? HeightTo { get; set; } = 0;
        [Display(Name = "Marital Status")]
        public string MaritalStatus { get; set; }
        [Display(Name = "Body Type")]
        public string BodyType { get; set; }
        public string Complexion { get; set; }
        [Display(Name = "Mother Tongue")]
        public string MotherTongue { get; set; }
        public string Religion { get; set; }
        public string Caste { get; set; }
        [Display(Name = "Sub Caste")]
        public string SubCaste { get; set; }
        public string Diet { get; set; }
        public string Smoke { get; set; }
        public string Drink { get; set; }
        [Display(Name = "Location")]
        public string Location { get; set; }
        public string Education { get; set; }
        public string Profession { get; set; }
        public string Manglik { get; set; }
        public string Description { get; set; }
    }
}
