using System.ComponentModel.DataAnnotations;

namespace KalyanamMatrimony.ViewModels
{
    public class LoginViewModel
    {
        [Required]
        [EmailAddress]
        public string UserEmail { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string UserPassword { get; set; }

        [Display(Name = "Remember me")]
        public bool RememberMe { get; set; }
    }
}
