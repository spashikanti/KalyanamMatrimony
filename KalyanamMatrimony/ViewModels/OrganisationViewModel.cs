using KalyanamMatrimony.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace KalyanamMatrimony.ViewModels
{
    public class OrganisationViewModel
    {
        [Display(Name = "Organisation Id")]
        public int OrgId { get; set; }
        [Display(Name = "Organisation Name")]
        public string OrgName { get; set; }
        [Display(Name = "Contact Person Name")]
        public string FullName { get; set; }
        [Display(Name = "Contact Person Phone")]
        public string Phone { get; set; }
        [Display(Name = "Created Date")]
        public DateTime CreatedDate { get; set; }
        [Display(Name = "End Date")]
        public DateTime EndDate { get; set; }

        [Display(Name = "License Id")]
        public int LicenseId { get; set; }
        [Display(Name = "License Name")]
        public string LicenseName { get; set; }
        [Display(Name = "Description")]
        public string Description { get; set; }
    }
}
