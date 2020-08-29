using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace KalyanamMatrimony.Models
{
    public static class ClaimsStore
    {
        public static List<Claim> AllClaims = new List<Claim>()
        {
            new Claim("Create Profile","Create Profile"),
            new Claim("View Profile","View Profile"),
            new Claim("Edit Profile","Edit Profile"),
            new Claim("Delete Profile","Delete Profile"),
            new Claim("Search Profile","Search Profile")
        };
    }
}
