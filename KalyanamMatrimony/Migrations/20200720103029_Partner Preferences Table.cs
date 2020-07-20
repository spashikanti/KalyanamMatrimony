using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace KalyanamMatrimony.Migrations
{
    public partial class PartnerPreferencesTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "73225929-311a-42e2-9317-6efe76952066", "1" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "029934e5-b9db-43a3-838b-646fc4571234", "b8613dba-00ba-4458-954b-31a160196789" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "73225929-311a-42e2-9317-6efe76952066", "e7777f79-47db-4972-9075-e7631052ce98" });

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

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "68b0f9c3-afce-4330-8d22-85b279ddeaf5");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "7851d4bd-4c74-4b7d-86c3-b68883e6e9bd");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3",
                column: "ConcurrencyStamp",
                value: "3fdbe254-45c2-4e84-8c00-8f5d708c5a2d");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4",
                column: "ConcurrencyStamp",
                value: "f765f043-fb35-4c0a-a942-e92ffe6b8a58");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "EndDate", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "OrgId", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "882c48b0-c576-4e55-9f75-5bdbadf17984", 0, "e7777f79-47db-4972-9075-e7631052ce98", "sunil.pashikanti@gmail.com", true, null, false, null, "SUNIL.PASHIKANTI@GMAIL.COM", "SUNIL.PASHIKANTI@GMAIL.COM", 0, "AQAAAAEAACcQAAAAEMVQ2KS92P28Ey5dkxOB2j350+h/KpOrwkk2AVvTWDVB1VJGAwCM5DFSYHXW7gnJDQ==", null, false, "TXEFASMBK2TBWRP42UFH6KKKHHLFKAXD", false, "sunil.pashikanti@gmail.com" },
                    { "2cf71cb7-d417-45d9-8f02-e6c0dfb6d337", 0, "b8613dba-00ba-4458-954b-31a160196789", "", true, null, false, null, "", "", 0, "AQAAAAEAACcQAAAAECl7YonDTp4i3s917GD+wSEv3YhSUQ/cXYiZ7XzvIWGW7cZc18ntu2bgSLinOrztyQ==", null, false, "UE2YZGPQD4ZJIX35FVVKTMKJT43XF3OM", false, "" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[] { "882c48b0-c576-4e55-9f75-5bdbadf17984", "1" });

            migrationBuilder.CreateIndex(
                name: "IX_PartnerPreferences_ProfileId",
                table: "PartnerPreferences",
                column: "ProfileId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PartnerPreferences");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "882c48b0-c576-4e55-9f75-5bdbadf17984", "1" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "2cf71cb7-d417-45d9-8f02-e6c0dfb6d337", "b8613dba-00ba-4458-954b-31a160196789" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "882c48b0-c576-4e55-9f75-5bdbadf17984", "e7777f79-47db-4972-9075-e7631052ce98" });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "c3ce1490-41c6-4499-8a9a-3bc779822218");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "08f577ac-1cac-445f-8779-f5aa382eadb5");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3",
                column: "ConcurrencyStamp",
                value: "2f04430c-f74d-4219-9226-01486553185d");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4",
                column: "ConcurrencyStamp",
                value: "9cdf7536-358f-4d73-ab6f-bd1ecd8fcda6");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "EndDate", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "OrgId", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "73225929-311a-42e2-9317-6efe76952066", 0, "e7777f79-47db-4972-9075-e7631052ce98", "sunil.pashikanti@gmail.com", true, null, false, null, "SUNIL.PASHIKANTI@GMAIL.COM", "SUNIL.PASHIKANTI@GMAIL.COM", 0, "AQAAAAEAACcQAAAAEMiGzX0zhxV4fq99lY/KJKtNCWsKsioXqJXDBBu9u6vL7xb/FLGz1pAbnboUu4yAng==", null, false, "TXEFASMBK2TBWRP42UFH6KKKHHLFKAXD", false, "sunil.pashikanti@gmail.com" },
                    { "029934e5-b9db-43a3-838b-646fc4571234", 0, "b8613dba-00ba-4458-954b-31a160196789", "", true, null, false, null, "", "", 0, "AQAAAAEAACcQAAAAEBnolvgh85ECJtmiW6koY55rcubYAnsmsvFRY74pwvDEuvkFTUltYoOFRusaDjVRow==", null, false, "UE2YZGPQD4ZJIX35FVVKTMKJT43XF3OM", false, "" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[] { "73225929-311a-42e2-9317-6efe76952066", "1" });
        }
    }
}
