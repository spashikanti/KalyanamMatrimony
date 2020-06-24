using Microsoft.AspNetCore.Identity;
using System;
using System.ComponentModel.DataAnnotations;

namespace KalyanamMatrimony.Models
{
    public class ApplicationUser: IdentityUser
    {
        [Display(Name = "End Date")]
        public DateTime? EndDate { get; set; }
    }
}
