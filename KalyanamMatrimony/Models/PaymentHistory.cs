using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace KalyanamMatrimony.Models
{
    public class PaymentHistory
    {
        public int PaymentHistoryId { get; set; }
        public int OrgId { get; set; }
        public int LicenseId { get; set; }
        public string UserId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Description { get; set; }
        public double Amount { get; set; }
        public string TransactionId { get; set; }
        public string OrderId { get; set; }
        public string RedirectURL { get; set; }
        public string PaymentURL { get; set; }
        public string Status { get; set; }

        [Display(Name = "Created Date")]
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        [Display(Name = "Created By")]
        public string CreatedBy { get; set; }
        [Display(Name = "Modified By")]
        public string ModifiedBy { get; set; }
        [Display(Name = "Modified Date")]
        public DateTime ModifiedDate { get; set; } = DateTime.Now;
    }
}
