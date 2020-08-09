using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KalyanamMatrimony.Models
{
    public class SiteSettings
    {
        public int SiteSettingsId { get; set; }
        public int OrgId { get; set; }
        [System.ComponentModel.DataAnnotations.Display(Name = "Profile Verification Message")]
        public string ProfileVerificationMessage { get; set; }
        public string InstaClientId { get; set; }
        public string InstaClientSecret { get; set; }
        //Metadata
        public DateTime CreatedDate { get; set; }
        public DateTime ModifiedDate { get; set; }
        public string CreatedBy { get; set; }
        public string ModifiedBy { get; set; }
    }
}
