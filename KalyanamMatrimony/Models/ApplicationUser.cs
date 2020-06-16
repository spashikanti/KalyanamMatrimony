using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Policy;
using System.Threading.Tasks;

namespace KalyanamMatrimony.Models
{
    public class ApplicationUser: IdentityUser
    {
        [Display(Name = "End Date")]
        public DateTime? EndDate { get; set; }
    }
}
