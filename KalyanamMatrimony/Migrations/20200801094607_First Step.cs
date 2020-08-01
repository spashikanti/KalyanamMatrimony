using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace KalyanamMatrimony.Migrations
{
    public partial class FirstStep : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Name = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    UserName = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(maxLength: 256, nullable: true),
                    Email = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(nullable: false),
                    PasswordHash = table.Column<string>(nullable: true),
                    SecurityStamp = table.Column<string>(nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(nullable: false),
                    TwoFactorEnabled = table.Column<bool>(nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(nullable: true),
                    LockoutEnabled = table.Column<bool>(nullable: false),
                    AccessFailedCount = table.Column<int>(nullable: false),
                    EndDate = table.Column<DateTime>(nullable: true),
                    OrgId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Licenses",
                columns: table => new
                {
                    LicenseId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    LicenseName = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    UsersCount = table.Column<int>(nullable: false),
                    MonthsCount = table.Column<float>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    LicenseType = table.Column<int>(nullable: false),
                    Price = table.Column<float>(nullable: false),
                    PayLink = table.Column<string>(nullable: true),
                    AssistantCount = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Licenses", x => x.LicenseId);
                });

            migrationBuilder.CreateTable(
                name: "Organisations",
                columns: table => new
                {
                    OrgId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    OrgName = table.Column<string>(nullable: true),
                    OrgDesc = table.Column<string>(nullable: true),
                    FullName = table.Column<string>(nullable: true),
                    Phone = table.Column<string>(nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    EndDate = table.Column<DateTime>(nullable: false),
                    LicenseId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Organisations", x => x.OrgId);
                });

            migrationBuilder.CreateTable(
                name: "PaymentHistory",
                columns: table => new
                {
                    PaymentHistoryId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    OrgId = table.Column<int>(nullable: false),
                    LicenseId = table.Column<int>(nullable: false),
                    UserId = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    Phone = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    Amount = table.Column<double>(nullable: false),
                    TransactionId = table.Column<string>(nullable: true),
                    OrderId = table.Column<string>(nullable: true),
                    RedirectURL = table.Column<string>(nullable: true),
                    PaymentURL = table.Column<string>(nullable: true),
                    Status = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PaymentHistory", x => x.PaymentHistoryId);
                });

            migrationBuilder.CreateTable(
                name: "Profiles",
                columns: table => new
                {
                    ProfileId = table.Column<string>(nullable: false),
                    UserId = table.Column<string>(nullable: true),
                    FirstName = table.Column<string>(nullable: false),
                    LastName = table.Column<string>(nullable: false),
                    Age = table.Column<int>(nullable: true),
                    DateOfBirth = table.Column<DateTime>(nullable: true),
                    Gender = table.Column<int>(nullable: true),
                    Height = table.Column<float>(nullable: true),
                    MaritalStatus = table.Column<string>(nullable: true),
                    HaveChildren = table.Column<bool>(nullable: false),
                    BodyType = table.Column<string>(nullable: true),
                    Complexion = table.Column<string>(nullable: true),
                    MotherTongue = table.Column<string>(nullable: true),
                    Religion = table.Column<string>(nullable: true),
                    Caste = table.Column<string>(nullable: true),
                    SubCaste = table.Column<string>(nullable: true),
                    Diet = table.Column<string>(nullable: true),
                    Smoke = table.Column<string>(nullable: true),
                    Drink = table.Column<string>(nullable: true),
                    AboutYourself = table.Column<string>(maxLength: 200, nullable: true),
                    BloodGroup = table.Column<string>(nullable: true),
                    CurrentLocation = table.Column<string>(nullable: true),
                    SpokenLanguages = table.Column<string>(nullable: true),
                    Education = table.Column<string>(nullable: true),
                    University = table.Column<string>(nullable: true),
                    Profession = table.Column<string>(nullable: true),
                    AnnualIncome = table.Column<string>(nullable: true),
                    WorkingAt = table.Column<string>(nullable: true),
                    FatherName = table.Column<string>(nullable: true),
                    MotherName = table.Column<string>(nullable: true),
                    FatherOccupation = table.Column<string>(nullable: true),
                    MotherOccupation = table.Column<string>(nullable: true),
                    Brothers = table.Column<int>(nullable: true),
                    MarriedBrothers = table.Column<int>(nullable: true),
                    Sisters = table.Column<int>(nullable: true),
                    MarriedSisters = table.Column<int>(nullable: true),
                    FamilyValues = table.Column<string>(nullable: true),
                    AboutFamily = table.Column<string>(maxLength: 200, nullable: true),
                    Hobbies = table.Column<string>(nullable: true),
                    FavoriteMusic = table.Column<string>(nullable: true),
                    FavoriteMovies = table.Column<string>(nullable: true),
                    FavoriteCuisine = table.Column<string>(nullable: true),
                    Sports = table.Column<string>(nullable: true),
                    PreferredDress = table.Column<string>(nullable: true),
                    Gothram = table.Column<string>(nullable: true),
                    Rasi = table.Column<string>(nullable: true),
                    Nakshatram = table.Column<string>(nullable: true),
                    Manglik = table.Column<string>(nullable: true),
                    AstroProfile = table.Column<string>(maxLength: 200, nullable: true),
                    Photo1 = table.Column<string>(nullable: true),
                    Photo2 = table.Column<string>(nullable: true),
                    Photo3 = table.Column<string>(nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    PhoneNumber = table.Column<string>(nullable: true),
                    ContactPersonName = table.Column<string>(nullable: true),
                    ContactPersonRelationShip = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Profiles", x => x.ProfileId);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    RoleId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    UserId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(nullable: false),
                    ProviderKey = table.Column<string>(nullable: false),
                    ProviderDisplayName = table.Column<string>(nullable: true),
                    UserId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    RoleId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    LoginProvider = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    Value = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PartnerPreferences",
                columns: table => new
                {
                    PartnerPreferenceId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ProfileId = table.Column<string>(nullable: true),
                    UserId = table.Column<string>(nullable: true),
                    AgeFrom = table.Column<int>(nullable: true),
                    AgeTo = table.Column<int>(nullable: true),
                    Gender = table.Column<int>(nullable: true),
                    HeightFrom = table.Column<float>(nullable: true),
                    HeightTo = table.Column<float>(nullable: true),
                    MaritalStatus = table.Column<string>(nullable: true),
                    BodyType = table.Column<string>(nullable: true),
                    Complexion = table.Column<string>(nullable: true),
                    MotherTongue = table.Column<string>(nullable: true),
                    Religion = table.Column<string>(nullable: true),
                    Caste = table.Column<string>(nullable: true),
                    SubCaste = table.Column<string>(nullable: true),
                    Diet = table.Column<string>(nullable: true),
                    Smoke = table.Column<string>(nullable: true),
                    Drink = table.Column<string>(nullable: true),
                    Location = table.Column<string>(nullable: true),
                    Education = table.Column<string>(nullable: true),
                    Profession = table.Column<string>(nullable: true),
                    Manglik = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PartnerPreferences", x => x.PartnerPreferenceId);
                    table.ForeignKey(
                        name: "FK_PartnerPreferences_Profiles_ProfileId",
                        column: x => x.ProfileId,
                        principalTable: "Profiles",
                        principalColumn: "ProfileId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "4", "96ccf17e-54e6-4493-aea4-fcbcc63d0322", "Profile", "PROFILE" },
                    { "2", "255b6a9b-049e-4850-8942-54c2bcadc044", "Admin", "ADMIN" },
                    { "1", "80dd6a7f-bcc1-405e-bd38-47691e9da570", "SuperAdmin", "SUPERADMIN" },
                    { "3", "77d0bae2-9220-45f5-a0f0-4f9d1e2723c6", "AdminAssistant", "ADMINASSISTANT" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "EndDate", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "OrgId", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "f928927f-32a8-4c4f-bbca-dc2a2605c900", 0, "e7777f79-47db-4972-9075-e7631052ce98", "sunil.pashikanti@gmail.com", true, null, false, null, "SUNIL.PASHIKANTI@GMAIL.COM", "SUNIL.PASHIKANTI@GMAIL.COM", 0, "AQAAAAEAACcQAAAAEKOxDKoa+XqIA/lRQDkZD1MyGLLEaC1lD0B1VaGEU68HwmV7aEbveLexXGT6qfChQQ==", null, false, "TXEFASMBK2TBWRP42UFH6KKKHHLFKAXD", false, "sunil.pashikanti@gmail.com" });

            migrationBuilder.InsertData(
                table: "Licenses",
                columns: new[] { "LicenseId", "AssistantCount", "CreatedDate", "Description", "IsActive", "LicenseName", "LicenseType", "MonthsCount", "PayLink", "Price", "UsersCount" },
                values: new object[,]
                {
                    { 5, 1, new DateTime(2020, 8, 1, 9, 46, 7, 351, DateTimeKind.Local), "Silver - 25 Users Per Year", true, "25 Users Per Year", 1, 12f, null, 4000f, 25 },
                    { 6, 2, new DateTime(2020, 8, 1, 9, 46, 7, 351, DateTimeKind.Local), "Golden - 50 Users Per Month", true, "50 Users Per Month", 1, 1f, null, 600f, 50 },
                    { 7, 2, new DateTime(2020, 8, 1, 9, 46, 7, 351, DateTimeKind.Local), "Golden - 50 Users Per Year", true, "50 Users Per Year", 1, 12f, null, 6000f, 50 },
                    { 3, 0, new DateTime(2020, 8, 1, 9, 46, 7, 351, DateTimeKind.Local), "Starter - 10 Users Per Year", true, "10 Users Per Year", 1, 12f, null, 2000f, 10 },
                    { 9, 3, new DateTime(2020, 8, 1, 9, 46, 7, 351, DateTimeKind.Local), "Diamond - 75 Users Per Year", true, "75 Users Per Year", 1, 12f, null, 8000f, 75 },
                    { 10, 4, new DateTime(2020, 8, 1, 9, 46, 7, 351, DateTimeKind.Local), "Platinum - 100 Users Per Month", true, "100 Users Per Month", 1, 1f, null, 1000f, 100 },
                    { 11, 4, new DateTime(2020, 8, 1, 9, 46, 7, 351, DateTimeKind.Local), "Platinum - 100 Users Per Year", true, "100 Users Per Year", 1, 12f, null, 10000f, 100 },
                    { 12, 5, new DateTime(2020, 8, 1, 9, 46, 7, 351, DateTimeKind.Local), "Life Time 1 - Buy the product and host it in your own servers for life time. Pay only for new features or supporting services.", true, "Life Time 1", 1, -1f, null, 15000f, 100 },
                    { 2, 0, new DateTime(2020, 8, 1, 9, 46, 7, 351, DateTimeKind.Local), "Starter - 10 Users Per Month", true, "10 Users Per Month", 1, 1f, null, 200f, 10 },
                    { 1, 2, new DateTime(2020, 8, 1, 9, 46, 7, 350, DateTimeKind.Local), "Free Trial", true, "Free Trial", 0, 0.16f, null, 0f, 6 },
                    { 4, 1, new DateTime(2020, 8, 1, 9, 46, 7, 351, DateTimeKind.Local), "Silver - 25 Users Per Month", true, "25 Users Per Month", 1, 1f, null, 400f, 25 },
                    { 8, 3, new DateTime(2020, 8, 1, 9, 46, 7, 351, DateTimeKind.Local), "Diamond - 75 Users Per Month", true, "75 Users Per Month", 1, 1f, null, 800f, 75 }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[] { "f928927f-32a8-4c4f-bbca-dc2a2605c900", "1" });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_PartnerPreferences_ProfileId",
                table: "PartnerPreferences",
                column: "ProfileId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Licenses");

            migrationBuilder.DropTable(
                name: "Organisations");

            migrationBuilder.DropTable(
                name: "PartnerPreferences");

            migrationBuilder.DropTable(
                name: "PaymentHistory");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Profiles");
        }
    }
}
