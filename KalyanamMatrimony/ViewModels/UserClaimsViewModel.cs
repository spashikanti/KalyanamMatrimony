using Remotion.Linq.Parsing.Structure.ExpressionTreeProcessors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KalyanamMatrimony.ViewModels
{
    public class UserClaimsViewModel
    {
        public UserClaimsViewModel()
        {
            Claims = new List<UserClaim>();
        }

        public string UserId { get; set; }
        public string EmailId { get; set; }
        public List<UserClaim> Claims { get; set; }
    }
}
