using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KalyanamMatrimony.ViewModels
{
    public class OrgLicenseViewModel
    {
        public IEnumerable<OrganisationViewModel> ActiveOrganisation { get; set; }
        public IEnumerable<OrganisationViewModel> InActiveOrganisation { get; set; }
        public IEnumerable<OrganisationViewModel> LicenseNotMappedOrganisations { get; set; }
    }
}
