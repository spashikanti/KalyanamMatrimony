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

                }
            );

        }
    }
}
