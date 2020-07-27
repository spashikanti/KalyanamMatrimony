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
    }
}
