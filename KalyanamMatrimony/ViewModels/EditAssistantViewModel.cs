using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace KalyanamMatrimony.ViewModels
{
    public class EditAssistantViewModel
    {
        [Display(Name = "User Id")]
        public string UserId { get; set; }
        public string Email { get; set; }
        [Display(Name = "End Date")]
        public DateTime? EndDate { get; set; }
    }
}
