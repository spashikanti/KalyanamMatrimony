using KalyanamMatrimony.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KalyanamMatrimony.ViewModels
{
    public class AdminDashboardViewModel
    {
        public int ActiveProfilesCount { get; set; }
        public int DeActivedProfilesCount { get; set; }
        public int MaleProfilesCount { get; set; }
        public int FemaleProfilesCount { get; set; }
    }
}
