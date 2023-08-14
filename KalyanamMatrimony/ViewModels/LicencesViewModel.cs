using KalyanamMatrimony.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KalyanamMatrimony.ViewModels
{
    public class LicencesViewModel
    {
        public IEnumerable<License> ActiveLicenses { get; set; }
        public IEnumerable<License> DeActivedLicenses { get; set; }
    }
}
