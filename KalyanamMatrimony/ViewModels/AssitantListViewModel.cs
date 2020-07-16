using KalyanamMatrimony.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KalyanamMatrimony.ViewModels
{
    public class AssistantListViewModel
    {
        public IEnumerable<AssistantViewModel> ActiveAssistants { get; set; }
        public IEnumerable<AssistantViewModel> DeActivedAssistants { get; set; }
    }
}
