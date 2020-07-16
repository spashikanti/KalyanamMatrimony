using KalyanamMatrimony.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KalyanamMatrimony.ViewModels
{
    public class SuperAdminDashboardViewModel
    {
        public int ActiveOrganisationsCount { get; set; }
        public int InActiveOrganisationsCount { get; set; }
        public int LicenseNotMappedOrganisationsCount { get; set; }
    }
}
