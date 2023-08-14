using KalyanamMatrimony.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KalyanamMatrimony.ViewModels
{
    public class ProfilesViewModel
    {
        public IEnumerable<Profile> ActiveProfiles { get; set; }
        public IEnumerable<Profile> DeActivedProfiles { get; set; }
    }
}
