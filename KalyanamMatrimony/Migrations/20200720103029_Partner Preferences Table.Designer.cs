﻿// <auto-generated />
using System;
using KalyanamMatrimony.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace KalyanamMatrimony.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20200720103029_Partner Preferences Table")]
    partial class PartnerPreferencesTable
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.14-servicing-32113")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("KalyanamMatrimony.Models.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<DateTime?>("EndDate");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256);

                    b.Property<int>("OrgId");

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("SecurityStamp");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex");

                    b.ToTable("AspNetUsers");

                    b.HasData(
                        new { Id = "882c48b0-c576-4e55-9f75-5bdbadf17984", AccessFailedCount = 0, ConcurrencyStamp = "e7777f79-47db-4972-9075-e7631052ce98", Email = "sunil.pashikanti@gmail.com", EmailConfirmed = true, LockoutEnabled = false, NormalizedEmail = "SUNIL.PASHIKANTI@GMAIL.COM", NormalizedUserName = "SUNIL.PASHIKANTI@GMAIL.COM", OrgId = 0, PasswordHash = "AQAAAAEAACcQAAAAEMVQ2KS92P28Ey5dkxOB2j350+h/KpOrwkk2AVvTWDVB1VJGAwCM5DFSYHXW7gnJDQ==", PhoneNumberConfirmed = false, SecurityStamp = "TXEFASMBK2TBWRP42UFH6KKKHHLFKAXD", TwoFactorEnabled = false, UserName = "sunil.pashikanti@gmail.com" },
                        new { Id = "2cf71cb7-d417-45d9-8f02-e6c0dfb6d337", AccessFailedCount = 0, ConcurrencyStamp = "b8613dba-00ba-4458-954b-31a160196789", Email = "", EmailConfirmed = true, LockoutEnabled = false, NormalizedEmail = "", NormalizedUserName = "", OrgId = 0, PasswordHash = "AQAAAAEAACcQAAAAECl7YonDTp4i3s917GD+wSEv3YhSUQ/cXYiZ7XzvIWGW7cZc18ntu2bgSLinOrztyQ==", PhoneNumberConfirmed = false, SecurityStamp = "UE2YZGPQD4ZJIX35FVVKTMKJT43XF3OM", TwoFactorEnabled = false, UserName = "" }
                    );
                });

            modelBuilder.Entity("KalyanamMatrimony.Models.License", b =>
                {
                    b.Property<int>("LicenseId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AssistantCount");

                    b.Property<DateTime>("CreatedDate");

                    b.Property<string>("Description");

                    b.Property<bool>("IsActive");

                    b.Property<string>("LicenseName");

                    b.Property<int>("LicenseType");

                    b.Property<float>("MonthsCount");

                    b.Property<string>("PayLink");

                    b.Property<float>("Price");

                    b.Property<int>("UsersCount");

                    b.HasKey("LicenseId");

                    b.ToTable("Licenses");
                });

            modelBuilder.Entity("KalyanamMatrimony.Models.Organisation", b =>
                {
                    b.Property<int>("OrgId")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreatedDate");

                    b.Property<DateTime>("EndDate");

                    b.Property<string>("FullName");

                    b.Property<int>("LicenseId");

                    b.Property<string>("OrgDesc");

                    b.Property<string>("OrgName");

                    b.Property<string>("Phone");

                    b.HasKey("OrgId");

                    b.ToTable("Organisations");
                });

            modelBuilder.Entity("KalyanamMatrimony.Models.PartnerPreference", b =>
                {
                    b.Property<int>("PartnerPreferenceId")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("AgeFrom");

                    b.Property<int?>("AgeTo");

                    b.Property<string>("BodyType");

                    b.Property<string>("Caste");

                    b.Property<string>("Complexion");

                    b.Property<string>("Description");

                    b.Property<string>("Diet");

                    b.Property<string>("Drink");

                    b.Property<string>("Education");

                    b.Property<int?>("Gender");

                    b.Property<float?>("HeightFrom");

                    b.Property<float?>("HeightTo");

                    b.Property<string>("Location");

                    b.Property<string>("Manglik");

                    b.Property<string>("MaritalStatus");

                    b.Property<string>("MotherTongue");

                    b.Property<string>("Profession");

                    b.Property<string>("ProfileId");

                    b.Property<string>("Religion");

                    b.Property<string>("Smoke");

                    b.Property<string>("SubCaste");

                    b.Property<string>("UserId");

                    b.HasKey("PartnerPreferenceId");

                    b.HasIndex("ProfileId")
                        .IsUnique();

                    b.ToTable("PartnerPreferences");
                });

            modelBuilder.Entity("KalyanamMatrimony.Models.Profile", b =>
                {
                    b.Property<string>("ProfileId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("AboutFamily")
                        .HasMaxLength(200);

                    b.Property<string>("AboutYourself")
                        .HasMaxLength(200);

                    b.Property<int?>("Age");

                    b.Property<string>("AnnualIncome");

                    b.Property<string>("AstroProfile")
                        .HasMaxLength(200);

                    b.Property<string>("BloodGroup");

                    b.Property<string>("BodyType");

                    b.Property<int?>("Brothers");

                    b.Property<string>("Caste");

                    b.Property<string>("Complexion");

                    b.Property<string>("ContactPersonName");

                    b.Property<string>("ContactPersonRelationShip");

                    b.Property<DateTime>("CreatedDate");

                    b.Property<string>("CurrentLocation");

                    b.Property<DateTime?>("DateOfBirth");

                    b.Property<string>("Diet");

                    b.Property<string>("Drink");

                    b.Property<string>("Education");

                    b.Property<string>("FamilyValues");

                    b.Property<string>("FatherName");

                    b.Property<string>("FatherOccupation");

                    b.Property<string>("FavoriteCuisine");

                    b.Property<string>("FavoriteMovies");

                    b.Property<string>("FavoriteMusic");

                    b.Property<string>("FirstName")
                        .IsRequired();

                    b.Property<int?>("Gender");

                    b.Property<string>("Gothram");

                    b.Property<bool>("HaveChildren");

                    b.Property<float?>("Height");

                    b.Property<string>("Hobbies");

                    b.Property<string>("LastName")
                        .IsRequired();

                    b.Property<string>("Manglik");

                    b.Property<string>("MaritalStatus");

                    b.Property<int?>("MarriedBrothers");

                    b.Property<int?>("MarriedSisters");

                    b.Property<string>("MotherName");

                    b.Property<string>("MotherOccupation");

                    b.Property<string>("MotherTongue");

                    b.Property<string>("Nakshatram");

                    b.Property<string>("PhoneNumber");

                    b.Property<string>("Photo1");

                    b.Property<string>("Photo2");

                    b.Property<string>("Photo3");

                    b.Property<string>("PreferredDress");

                    b.Property<string>("Profession");

                    b.Property<string>("Rasi");

                    b.Property<string>("Religion");

                    b.Property<int?>("Sisters");

                    b.Property<string>("Smoke");

                    b.Property<string>("SpokenLanguages");

                    b.Property<string>("Sports");

                    b.Property<string>("SubCaste");

                    b.Property<string>("University");

                    b.Property<string>("UserId");

                    b.Property<string>("WorkingAt");

                    b.HasKey("ProfileId");

                    b.ToTable("Profiles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Name")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex");

                    b.ToTable("AspNetRoles");

                    b.HasData(
                        new { Id = "1", ConcurrencyStamp = "68b0f9c3-afce-4330-8d22-85b279ddeaf5", Name = "SuperAdmin", NormalizedName = "SUPERADMIN" },
                        new { Id = "2", ConcurrencyStamp = "7851d4bd-4c74-4b7d-86c3-b68883e6e9bd", Name = "Admin", NormalizedName = "ADMIN" },
                        new { Id = "3", ConcurrencyStamp = "3fdbe254-45c2-4e84-8c00-8f5d708c5a2d", Name = "AdminAssistant", NormalizedName = "ADMINASSISTANT" },
                        new { Id = "4", ConcurrencyStamp = "f765f043-fb35-4c0a-a942-e92ffe6b8a58", Name = "Profile", NormalizedName = "PROFILE" }
                    );
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("RoleId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider");

                    b.Property<string>("ProviderKey");

                    b.Property<string>("ProviderDisplayName");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");

                    b.HasData(
                        new { UserId = "882c48b0-c576-4e55-9f75-5bdbadf17984", RoleId = "1" }
                    );
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("LoginProvider");

                    b.Property<string>("Name");

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("KalyanamMatrimony.Models.PartnerPreference", b =>
                {
                    b.HasOne("KalyanamMatrimony.Models.Profile")
                        .WithOne("PartnerPreference")
                        .HasForeignKey("KalyanamMatrimony.Models.PartnerPreference", "ProfileId");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("KalyanamMatrimony.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("KalyanamMatrimony.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("KalyanamMatrimony.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("KalyanamMatrimony.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
