using System.ComponentModel.DataAnnotations;
using static KalyanamMatrimony.Models.CustomEnums;

namespace KalyanamMatrimony.Models
{
    public class Employee
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(50, ErrorMessage = "Name cannot exceed 50 characters")]
        public string Name { get; set; }
        [Required]
        [RegularExpression(@"^([a-zA-Z0-9_\-\.]+)@([a-zA-Z0-9_\-\.]+)\.([a-zA-Z]{2,5})$", 
            ErrorMessage = "Invalid Email Format")]
        [Display(Name = "User Email")]
        public string Email { get; set; }
        [Required]
        public Dept? Department { get; set; }
    }
}
