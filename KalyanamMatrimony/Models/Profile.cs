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
        public Profile()
        {
            DateOfBirth = new DateTime();
        }
        //UserInfo
        [Display(Name = "Profile Id")]
        public string  ProfileId { get; set; }
        public string  UserId { get; set; }

        [Required]
        [Display(Name = "Frist Name")]
        public string FirstName { get; set; }

        [Required]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        //Personal Info
        public int? Age { get; set; } = 0;
        [Display(Name = "Date Of Birth")]
        public DateTime? DateOfBirth { get; set; }
        public ProfileGender? Gender { get; set; } = ProfileGender.None;
        public float? Height { get; set; } = 0;
        [Display(Name = "Marital Status")]
        public string MaritalStatus { get; set; }
        [Display(Name = "Have Children")]
        public bool HaveChildren { get; set; } = false;
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
        [Display(Name = "About Yourself")]
        public string AboutYourself { get; set; }
        [Display(Name = "Blood Group")]
        public string BloodGroup { get; set; }
        [Display(Name = "Current Location")]
        public string CurrentLocation { get; set; }
        [Display(Name = "Spoken Languages")]
        public string SpokenLanguages { get; set; }

        //Education Info
        public string Education { get; set; }
        public string University { get; set; }
        public string Profession { get; set; }
        [Display(Name = "Annual Income")]
        public string AnnualIncome { get; set; }
        [Display(Name = "Working At")]
        public string WorkingAt { get; set; }

        //Family Info
        [Display(Name = "Father Name")]
        public string FatherName { get; set; }
        [Display(Name = "Mother Name")]
        public string MotherName { get; set; }
        [Display(Name = "Father Occupation")]
        public string FatherOccupation { get; set; }
        [Display(Name = "Mother Occupation")]
        public string MotherOccupation { get; set; }
        public int? Brothers { get; set; } = 0;
        [Display(Name = "Married Brothers")]
        public int? MarriedBrothers { get; set; } = 0;
        public int? Sisters { get; set; } = 0;
        [Display(Name = "Married Sisters")]
        public int? MarriedSisters { get; set; } = 0;
        [Display(Name = "Family Values")]
        public string FamilyValues { get; set; }
        [Display(Name = "About Family")]
        public string AboutFamily { get; set; }

        //Hobbies
        public string Hobbies { get; set; }
        [Display(Name = "Favorite Music")]
        public string FavoriteMusic { get; set; }
        [Display(Name = "Favorite Movies")]
        public string FavoriteMovies { get; set; }
        [Display(Name = "Favorite Cuisine")]
        public string FavoriteCuisine { get; set; }
        public string Sports { get; set; }
        [Display(Name = "Preferred Dress")]
        public string PreferredDress { get; set; }

        //Horoscope
        public string Gothram { get; set; }
        public string Rasi { get; set; }
        public string Nakshatram { get; set; }
        public string Manglik { get; set; }
        [Display(Name = "Astrology Profile")]
        public string AstroProfile { get; set; }

        //Photos
        public string Photo1 { get; set; }
        public string Photo2 { get; set; }
        public string Photo3 { get; set; }

        public DateTime CreatedDate { get; set; } = DateTime.Now;

        //Contact Details
        [Display(Name = "Phone Number")]
        public string PhoneNumber { get; set; }
        [Display(Name ="Contact Person Name")]
        public string ContactPersonName { get; set; }
        [Display(Name = "Contact Person Relationship")]
        public string ContactPersonRelationShip { get; set; }
    }
}
