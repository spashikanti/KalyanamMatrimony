using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using static KalyanamMatrimony.Models.CustomEnums;

namespace KalyanamMatrimony.Models
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>().HasData(
                new Employee
                {
                    Id = 1,
                    Name = "Mark",
                    Department = Dept.IT,
                    Email = "mark@pragimtech.com"
                },
                new Employee
                {
                    Id = 2,
                    Name = "John",
                    Department = Dept.HR,
                    Email = "john@pragimtech.com"
                }
            );

            var hasher = new PasswordHasher<ApplicationUser>();
            string superAdminId = Guid.NewGuid().ToString();
            string superAdminEmail = "sunil.pashikanti@gmail.com";
            string adminId = Guid.NewGuid().ToString();
            string adminEmail = "sunil8120@gmail.com";

            modelBuilder.Entity<ApplicationUser>().HasData(
                new ApplicationUser
                {
                    Id = superAdminId,
                    UserName = superAdminEmail,
                    Email = superAdminEmail,
                    NormalizedUserName = superAdminEmail.ToUpper(),
                    NormalizedEmail = superAdminEmail.ToUpper(),
                    EmailConfirmed = true,
                    PasswordHash = hasher.HashPassword(null, "Welcome@12345"),
                    SecurityStamp = string.Empty
                },
                new ApplicationUser
                {
                    Id = adminId,
                    UserName = adminEmail,
                    Email = adminEmail,
                    NormalizedUserName = adminEmail.ToUpper(),
                    NormalizedEmail = adminEmail.ToUpper(),
                    EmailConfirmed = true,
                    PasswordHash = hasher.HashPassword(null, "Welcome@12345"),
                    SecurityStamp = string.Empty
                }
            );

            modelBuilder.Entity<IdentityRole>().HasData(
                new IdentityRole
                {
                    Id = "1",
                    Name = Enum.GetName(typeof(CustomEnums.CustomRole), CustomEnums.CustomRole.SuperAdmin),
                    NormalizedName = Enum.GetName(typeof(CustomEnums.CustomRole), CustomEnums.CustomRole.SuperAdmin).ToUpper()
                },
                new IdentityRole
                {
                    Id = "2",
                    Name = Enum.GetName(typeof(CustomEnums.CustomRole), CustomEnums.CustomRole.Admin),
                    NormalizedName = Enum.GetName(typeof(CustomEnums.CustomRole), CustomEnums.CustomRole.Admin).ToUpper()
                },
                new IdentityRole
                {
                    Id = "3",
                    Name = Enum.GetName(typeof(CustomEnums.CustomRole), CustomEnums.CustomRole.Profile),
                    NormalizedName = Enum.GetName(typeof(CustomEnums.CustomRole), CustomEnums.CustomRole.Profile).ToUpper()
                }
            );

            modelBuilder.Entity<IdentityUserRole<string>>().HasData(
                new IdentityUserRole<string>
                {
                    RoleId = "1",
                    UserId = superAdminId

                },
                new IdentityUserRole<string>
                {
                    RoleId = "2",
                    UserId = adminId
                }
            );

        }
    }
}
