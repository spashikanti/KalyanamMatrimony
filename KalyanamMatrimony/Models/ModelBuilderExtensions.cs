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
            //PROVIDE ADMIN EMAIL ID IF IT IS INDIVIDUAL at line number 65
            string orgType = Enum.GetName(typeof(CustomEnums.OrgType), CustomEnums.OrgType.Shared);
            //string orgType = Enum.GetName(typeof(CustomEnums.OrgType), CustomEnums.OrgType.Individual);

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

            if (orgType == Enum.GetName(typeof(CustomEnums.OrgType), CustomEnums.OrgType.Individual))
            {
                //Add licenses
                modelBuilder.Entity<License>().HasData(
                    new License
                    {
                        LicenseId = 1,
                        LicenseName = "Life Time 1",
                        Description = "Life Time 1 - Buy the product and host it in your own servers for life time. Pay only for new features or supporting services.",
                        CreatedDate = DateTime.Now,
                        UsersCount = 100,
                        AssistantCount = 5,
                        IsActive = true,
                        LicenseType = LicenseType.Paid,
                        MonthsCount = 12,
                        Price = 15000
                    }
                );

                //Add Organisation
                modelBuilder.Entity<Organisation>().HasData(
                    new Organisation
                    {
                        OrgId = 1,
                        OrgName = "Narayana Matrimony",
                        OrgDesc = "Narayana Matrimony Services",
                        FullName = "Chiluka Narayana",
                        Phone = "8121958960",
                        LicenseId = 1,
                        CreatedDate = DateTime.Now,
                        EndDate = DateTime.Now.AddYears(1)
                    }
                );

                string adminId = Guid.NewGuid().ToString();
                string adminEmail = "sunil8120@gmail.com";//provide valid email id for Admin User
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
                        ConcurrencyStamp = "b8613dba-00ba-4458-954b-31a160196789",
                        OrgId = 1
                    }
                );

                modelBuilder.Entity<IdentityUserRole<string>>().HasData(
                    new IdentityUserRole<string>
                    {
                        RoleId = "1",
                        UserId = superAdminId
                    }
                    , new IdentityUserRole<string>
                    {
                        RoleId = "2",
                        UserId = adminId
                    }
                );
            }
            else
            {
                modelBuilder.Entity<IdentityUserRole<string>>().HasData(
                    new IdentityUserRole<string>
                    {
                        RoleId = "1",
                        UserId = superAdminId
                    }
                );

                //Add licenses
                modelBuilder.Entity<License>().HasData(
                    new License
                    {
                        LicenseId = 1,
                        LicenseName = "Free Trial",
                        Description = "Free Trial",
                        CreatedDate = DateTime.Now,
                        UsersCount = 6,
                        AssistantCount = 2,
                        IsActive = true,
                        LicenseType = LicenseType.Free,
                        MonthsCount = 0.16F,
                        Price = 0
                    },
                    new License
                    {
                        LicenseId = 2,
                        LicenseName = "10 Users Per Month",
                        Description = "Starter - 10 Users Per Month",
                        CreatedDate = DateTime.Now,
                        UsersCount = 10,
                        AssistantCount = 0,
                        IsActive = true,
                        LicenseType = LicenseType.Paid,
                        MonthsCount = 1,
                        Price = 200
                    },
                    new License
                    {
                        LicenseId = 3,
                        LicenseName = "10 Users Per Year",
                        Description = "Starter - 10 Users Per Year",
                        CreatedDate = DateTime.Now,
                        UsersCount = 10,
                        AssistantCount = 0,
                        IsActive = true,
                        LicenseType = LicenseType.Paid,
                        MonthsCount = 12,
                        Price = 2000
                    },
                    new License
                    {
                        LicenseId = 4,
                        LicenseName = "25 Users Per Month",
                        Description = "Silver - 25 Users Per Month",
                        CreatedDate = DateTime.Now,
                        UsersCount = 25,
                        AssistantCount = 1,
                        IsActive = true,
                        LicenseType = LicenseType.Paid,
                        MonthsCount = 1,
                        Price = 400
                    },
                    new License
                    {
                        LicenseId = 5,
                        LicenseName = "25 Users Per Year",
                        Description = "Silver - 25 Users Per Year",
                        CreatedDate = DateTime.Now,
                        UsersCount = 25,
                        AssistantCount = 1,
                        IsActive = true,
                        LicenseType = LicenseType.Paid,
                        MonthsCount = 12,
                        Price = 4000
                    },
                    new License
                    {
                        LicenseId = 6,
                        LicenseName = "50 Users Per Month",
                        Description = "Golden - 50 Users Per Month",
                        CreatedDate = DateTime.Now,
                        UsersCount = 50,
                        AssistantCount = 2,
                        IsActive = true,
                        LicenseType = LicenseType.Paid,
                        MonthsCount = 1,
                        Price = 600
                    },
                    new License
                    {
                        LicenseId = 7,
                        LicenseName = "50 Users Per Year",
                        Description = "Golden - 50 Users Per Year",
                        CreatedDate = DateTime.Now,
                        UsersCount = 50,
                        AssistantCount = 2,
                        IsActive = true,
                        LicenseType = LicenseType.Paid,
                        MonthsCount = 12,
                        Price = 6000
                    },
                    new License
                    {
                        LicenseId = 8,
                        LicenseName = "75 Users Per Month",
                        Description = "Diamond - 75 Users Per Month",
                        CreatedDate = DateTime.Now,
                        UsersCount = 75,
                        AssistantCount = 3,
                        IsActive = true,
                        LicenseType = LicenseType.Paid,
                        MonthsCount = 1,
                        Price = 800
                    },
                    new License
                    {
                        LicenseId = 9,
                        LicenseName = "75 Users Per Year",
                        Description = "Diamond - 75 Users Per Year",
                        CreatedDate = DateTime.Now,
                        UsersCount = 75,
                        AssistantCount = 3,
                        IsActive = true,
                        LicenseType = LicenseType.Paid,
                        MonthsCount = 12,
                        Price = 8000
                    },
                    new License
                    {
                        LicenseId = 10,
                        LicenseName = "100 Users Per Month",
                        Description = "Platinum - 100 Users Per Month",
                        CreatedDate = DateTime.Now,
                        UsersCount = 100,
                        AssistantCount = 4,
                        IsActive = true,
                        LicenseType = LicenseType.Paid,
                        MonthsCount = 1,
                        Price = 1000
                    },
                    new License
                    {
                        LicenseId = 11,
                        LicenseName = "100 Users Per Year",
                        Description = "Platinum - 100 Users Per Year",
                        CreatedDate = DateTime.Now,
                        UsersCount = 100,
                        AssistantCount = 4,
                        IsActive = true,
                        LicenseType = LicenseType.Paid,
                        MonthsCount = 12,
                        Price = 10000
                    },
                    new License
                    {
                        LicenseId = 12,
                        LicenseName = "Life Time 1",
                        Description = "Life Time 1 - Buy the product and host it in your own servers for life time. Pay only for new features or supporting services.",
                        CreatedDate = DateTime.Now,
                        UsersCount = 100,
                        AssistantCount = 5,
                        IsActive = true,
                        LicenseType = LicenseType.Paid,
                        MonthsCount = -1,
                        Price = 15000
                    }
                );
            }
        }
    }
}
