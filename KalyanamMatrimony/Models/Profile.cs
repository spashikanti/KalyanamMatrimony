using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Threading.Tasks;
using static KalyanamMatrimony.Models.CustomEnums;

namespace KalyanamMatrimony.Models
{
    public class Profile
    {
        //UserInfo
        public string  ProfileId { get; set; }
        [Required]
        public string  UserId { get; set; }

        [Required]
        [Display(Name = "Frist Name")]
        public string FirstName { get; set; }

        [Required]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        //Personal Info
        public int Age { get; set; }
        public DateTime DateOfBirth { get; set; }
        public ProfileGender Gender { get; set; }
        public float Height { get; set; }
        public string MaritalStatus { get; set; }
        public bool HaveChildren { get; set; }
        public string BodyType { get; set; }
        public string Complexion { get; set; }
        public string MotherTongue { get; set; }
        public string Religion { get; set; }
        public string Caste { get; set; }
        public string SubCaste { get; set; }
        public string Diet { get; set; }
        public string Smoke { get; set; }
        public string Drink { get; set; }
        public string AboutYourself { get; set; }
        public string BloodGroup { get; set; }
        public string CurrentLocation { get; set; }

        //Education Info
        public string Education { get; set; }
        public string University { get; set; }
        public string Profession { get; set; }
        public string AnnualIncome { get; set; }
        public string WorkingAt { get; set; }
        
        //Family Info
        public string FamilyValues { get; set; }
        public string FatherName { get; set; }
        public string MotherName { get; set; }
        public string FatherOccupation { get; set; }
        public string MotherOccupation { get; set; }
        public int Brothers { get; set; }
        public int MarriedBrothers { get; set; }
        public int Sisters { get; set; }
        public int MarriedSisters { get; set; }
        public string AboutFamily { get; set; }

        //Photos
        public string Photo1 { get; set; }
        public string Photo2 { get; set; }
        public string Photo3 { get; set; }

        //Hobbies
        public string Hobbies { get; set; }
        public string FavoriteMusic { get; set; }
        public string FavoriteMovies { get; set; }
        public string Sports { get; set; }
        public string FavoriteCuisine { get; set; }
        public string PreferredDress { get; set; }
        public string SpokenLanguages { get; set; }

        //Horoscope
        public string Gothram { get; set; }
        public string Rasi { get; set; }
        public string Nakshatram { get; set; }
        public string Manglik { get; set; }
        public string AstroProfile { get; set; }
    }
}
