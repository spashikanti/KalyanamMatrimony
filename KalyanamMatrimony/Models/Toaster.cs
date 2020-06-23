using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static KalyanamMatrimony.Models.CustomEnums;

namespace KalyanamMatrimony.Models
{
    public class Toaster
    {
        public ToastType Type { get; set; }
        public string Message { get; set; }
    }
}
