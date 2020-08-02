using Microsoft.AspNetCore.Identity;
using System;
using System.ComponentModel.DataAnnotations;

namespace KalyanamMatrimony.Models
{
    public class ApplicationUser: IdentityUser
    {
        [Display(Name = "End Date")]
        public DateTime? EndDate { get; set; }
        [Display(Name = "Organisation Id")]
        public int OrgId { get; set; }

        [Display(Name = "Created Date")]
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        [Display(Name = "Created By")]
        public string CreatedBy { get; set; }
        [Display(Name = "Modified By")]
        public string ModifiedBy { get; set; }
        [Display(Name = "Modified Date")]
        public DateTime ModifiedDate { get; set; } = DateTime.Now;
    }
}
