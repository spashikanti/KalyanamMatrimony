using KalyanamMatrimony.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace KalyanamMatrimony.ViewModels
{
    public class SignUpViewModel
    {
        public SignUpViewModel()
        {
            LicenseTypes = new SelectList(new List<string>()); // empty list of anything...
        }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }
        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Confirm Password")]
        [Compare("Password", ErrorMessage = "Passwords do not match.")]
        public string ConfirmPassword { get; set; }
        [Display(Name = "User Id")]
        public string UserId { get; set; }
        [Display(Name = "Organisation Id")]
        public int OrgId { get; set; }
        [Required]
        [Display(Name = "Organisation Name")]
        public string OrgName { get; set; }
        [Display(Name = "Description")]
        public string OrgDesc { get; set; }
        [Required]
        [Display(Name = "Contact Person Name")]
        public string FullName { get; set; }
        [Required]
        [Phone]
        [Display(Name = "Contact Person Phone")]
        public string Phone { get; set; }
        [Display(Name = "Created Date")]
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        [Display(Name = "End Date")]
        public DateTime EndDate { get; set; }
        [Required]
        [Display(Name = "License")]
        public int LicenseId { get; set; }
        
        [Display(Name = "License Type")]
        public SelectList LicenseTypes { get; set; }

        public CustomEnums.CustomRole UserRole { get; set; } = CustomEnums.CustomRole.Admin;
    }
}
