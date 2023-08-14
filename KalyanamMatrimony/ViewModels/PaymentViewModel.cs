using KalyanamMatrimony.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KalyanamMatrimony.ViewModels
{
    public class PaymentViewModel: PaymentHistory
    {
        public IEnumerable<License> Licenses { get; set; }
        public string OrgName { get; set; }
        public string EndDate { get; set; }
        public string LicenseDesc { get; set; }
    }
}
