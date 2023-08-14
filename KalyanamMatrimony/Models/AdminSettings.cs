using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KalyanamMatrimony.Models
{
    public class AdminSettings
    {
        public int OrgId { get; set; }
        public string ProfileVerificationMessage { get; set; }
        public string InstaMojoClientID { get; set; }
        public string InstaMojoClientSecret { get; set; }

        public string CreatedBy { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime ModifiedDate { get; set; } = DateTime.Now;
    }
}
