using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace KalyanamMatrimony.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class License
    {
        [Key]
        [Display(Name = "License Id")]
        public int LicenseId { get; set; }
        [Display(Name = "License Name")]
        public string LicenseName { get; set; }
        [Display(Name = "Description")]
        public string Description { get; set; }
        [Display(Name = "Users Count")]
        public int UsersCount { get; set; }
        [Display(Name = "Months Count")]
        public float MonthsCount { get; set; }
        [Display(Name = "Is Active")]
        public bool IsActive { get; set; }
        [Display(Name = "Created Date")]
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        [Display(Name = "License Type")]
        public CustomEnums.LicenseType LicenseType { get; set; }
        [Display(Name = "Price")]
        public float Price { get; set; }

        public string PayLink { get; set; }
    }
}
