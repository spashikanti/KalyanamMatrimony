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
            var hasher = new PasswordHasher<ApplicationUser>();
            string superAdminId = Guid.NewGuid().ToString();
            string superAdminEmail = "sunil.pashikanti@gmail.com";

            

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
                    SecurityStamp = "TXEFASMBK2TBWRP42UFH6KKKHHLFKAXD",
                    ConcurrencyStamp = "e7777f79-47db-4972-9075-e7631052ce98"
                }
            );

            //Uncomment for creating admin role if selling as a product (uncomment at 2 places, 1 of 2)
            string adminId = Guid.NewGuid().ToString();
            string adminEmail = "";//provide email
            modelBuilder.Entity<ApplicationUser>().HasData(
                new ApplicationUser
                {
                    Id = adminId,
                    UserName = adminEmail,
                    Email = adminEmail,
                    NormalizedUserName = adminEmail.ToUpper(),
                    NormalizedEmail = adminEmail.ToUpper(),
                    EmailConfirmed = true,
                    PasswordHash = hasher.HashPassword(null, "Welcome@12345"),
                    SecurityStamp = "UE2YZGPQD4ZJIX35FVVKTMKJT43XF3OM",
                    ConcurrencyStamp = "b8613dba-00ba-4458-954b-31a160196789"
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
                    Name = Enum.GetName(typeof(CustomEnums.CustomRole), CustomEnums.CustomRole.AdminAssistant),
                    NormalizedName = Enum.GetName(typeof(CustomEnums.CustomRole), CustomEnums.CustomRole.AdminAssistant).ToUpper()
                },
                new IdentityRole
                {
                    Id = "4",
                    Name = Enum.GetName(typeof(CustomEnums.CustomRole), CustomEnums.CustomRole.Profile),
                    NormalizedName = Enum.GetName(typeof(CustomEnums.CustomRole), CustomEnums.CustomRole.Profile).ToUpper()
                }
            );

            modelBuilder.Entity<IdentityUserRole<string>>().HasData(
                new IdentityUserRole<string>
                {
                    RoleId = "1",
                    UserId = superAdminId
                }
                //Uncomment for creating admin role if selling as a product (uncomment at 2 places, 2 of 2)
                //, new IdentityUserRole<string>
                //{
                //    RoleId = "2",
                //    UserId = adminId
                //}
            );

        }
    }
}
