﻿// <auto-generated />
using System;
using KalyanamMatrimony.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace KalyanamMatrimony.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
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
                        new { Id = "fcadcc1c-990b-4419-88da-651520f14ada", AccessFailedCount = 0, ConcurrencyStamp = "e7777f79-47db-4972-9075-e7631052ce98", Email = "sunil.pashikanti@gmail.com", EmailConfirmed = true, LockoutEnabled = false, NormalizedEmail = "SUNIL.PASHIKANTI@GMAIL.COM", NormalizedUserName = "SUNIL.PASHIKANTI@GMAIL.COM", OrgId = 0, PasswordHash = "AQAAAAEAACcQAAAAELQf1eXgYmil1ZRHPgBONx8J4c4+uNPPelUPY6hf4HGfT8p4f2FWDNR2cROBZvsJVg==", PhoneNumberConfirmed = false, SecurityStamp = "TXEFASMBK2TBWRP42UFH6KKKHHLFKAXD", TwoFactorEnabled = false, UserName = "sunil.pashikanti@gmail.com" },
                        new { Id = "ebef2fec-69dd-4c71-be0e-b8f6bb658df9", AccessFailedCount = 0, ConcurrencyStamp = "b8613dba-00ba-4458-954b-31a160196789", Email = "", EmailConfirmed = true, LockoutEnabled = false, NormalizedEmail = "", NormalizedUserName = "", OrgId = 0, PasswordHash = "AQAAAAEAACcQAAAAEMFsljM5p0mbOgFdoKMtk6+MjpaxF/1hkQfgDAEmSvoOchgpTB+DYoQvIJjZYDB5ag==", PhoneNumberConfirmed = false, SecurityStamp = "UE2YZGPQD4ZJIX35FVVKTMKJT43XF3OM", TwoFactorEnabled = false, UserName = "" }
                    );
                });

            modelBuilder.Entity("KalyanamMatrimony.Models.License", b =>
                {
                    b.Property<int>("LicenseId")
                        .ValueGeneratedOnAdd();

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
                        new { Id = "1", ConcurrencyStamp = "8028eddf-dace-43d6-a807-c4eceddb0898", Name = "SuperAdmin", NormalizedName = "SUPERADMIN" },
                        new { Id = "2", ConcurrencyStamp = "de60b495-f7ef-4eb8-8034-0821abdb3346", Name = "Admin", NormalizedName = "ADMIN" },
                        new { Id = "3", ConcurrencyStamp = "3cf2e293-f606-4351-95c7-d1c873d00cf9", Name = "AdminAssistant", NormalizedName = "ADMINASSISTANT" },
                        new { Id = "4", ConcurrencyStamp = "9916c136-d127-4ff2-bf89-d57f3cd0aefe", Name = "Profile", NormalizedName = "PROFILE" }
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
                        new { UserId = "fcadcc1c-990b-4419-88da-651520f14ada", RoleId = "1" }
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
