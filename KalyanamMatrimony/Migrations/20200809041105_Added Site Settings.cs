using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace KalyanamMatrimony.Migrations
{
    public partial class AddedSiteSettings : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "20ccc3b9-75e7-4bd4-94df-c8a63a204d41", "1" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "20ccc3b9-75e7-4bd4-94df-c8a63a204d41", "e7777f79-47db-4972-9075-e7631052ce98" });

            migrationBuilder.CreateTable(
                name: "SiteSettings",
                columns: table => new
                {
                    SiteSettingsId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    OrgId = table.Column<int>(nullable: false),
                    ProfileVerificationMessage = table.Column<string>(nullable: true),
                    InstaClientId = table.Column<string>(nullable: true),
                    InstaClientSecret = table.Column<string>(nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    ModifiedDate = table.Column<DateTime>(nullable: false),
                    CreatedBy = table.Column<string>(nullable: true),
                    ModifiedBy = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SiteSettings", x => x.SiteSettingsId);
                });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "4a27f8b1-e272-48b8-9491-48142acab6a8");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "18115ee6-5c7e-4aba-84d9-72e9c0697b4b");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3",
                column: "ConcurrencyStamp",
                value: "c17e5a7a-043c-46c8-aa02-df099939f20b");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4",
                column: "ConcurrencyStamp",
                value: "1be5ad3f-79bc-467f-a41e-98951cf327cf");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "CreatedBy", "CreatedDate", "Email", "EmailConfirmed", "EndDate", "LockoutEnabled", "LockoutEnd", "ModifiedBy", "ModifiedDate", "NormalizedEmail", "NormalizedUserName", "OrgId", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "0e929bc5-1e54-4433-b8a3-b2fd71df50e7", 0, "e7777f79-47db-4972-9075-e7631052ce98", null, new DateTime(2020, 8, 9, 9, 41, 3, 993, DateTimeKind.Local), "sunil.pashikanti@gmail.com", true, null, false, null, null, new DateTime(2020, 8, 9, 9, 41, 3, 994, DateTimeKind.Local), "SUNIL.PASHIKANTI@GMAIL.COM", "SUNIL.PASHIKANTI@GMAIL.COM", 0, "AQAAAAEAACcQAAAAEHijTIOgSMcslNvk2+bKhHlvZBt9l6BVXXa8lye9gDEejwyWs+EtUOJjUIA1w0UhUQ==", null, false, "TXEFASMBK2TBWRP42UFH6KKKHHLFKAXD", false, "sunil.pashikanti@gmail.com" });

            migrationBuilder.UpdateData(
                table: "Licenses",
                keyColumn: "LicenseId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2020, 8, 9, 9, 41, 4, 40, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Licenses",
                keyColumn: "LicenseId",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2020, 8, 9, 9, 41, 4, 40, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Licenses",
                keyColumn: "LicenseId",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2020, 8, 9, 9, 41, 4, 40, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Licenses",
                keyColumn: "LicenseId",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2020, 8, 9, 9, 41, 4, 40, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Licenses",
                keyColumn: "LicenseId",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2020, 8, 9, 9, 41, 4, 40, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Licenses",
                keyColumn: "LicenseId",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2020, 8, 9, 9, 41, 4, 40, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Licenses",
                keyColumn: "LicenseId",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2020, 8, 9, 9, 41, 4, 40, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Licenses",
                keyColumn: "LicenseId",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2020, 8, 9, 9, 41, 4, 40, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Licenses",
                keyColumn: "LicenseId",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2020, 8, 9, 9, 41, 4, 40, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Licenses",
                keyColumn: "LicenseId",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2020, 8, 9, 9, 41, 4, 40, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Licenses",
                keyColumn: "LicenseId",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2020, 8, 9, 9, 41, 4, 40, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Licenses",
                keyColumn: "LicenseId",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2020, 8, 9, 9, 41, 4, 40, DateTimeKind.Local));

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[] { "0e929bc5-1e54-4433-b8a3-b2fd71df50e7", "1" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SiteSettings");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "0e929bc5-1e54-4433-b8a3-b2fd71df50e7", "1" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "0e929bc5-1e54-4433-b8a3-b2fd71df50e7", "e7777f79-47db-4972-9075-e7631052ce98" });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "16315202-a31c-451a-a772-d8c88ad9408c");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "64691293-a1c9-471e-8d41-16519d5a3a0e");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3",
                column: "ConcurrencyStamp",
                value: "1d1009a0-0f3e-4e83-b4fe-026f1216e53d");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4",
                column: "ConcurrencyStamp",
                value: "d637f953-751c-4bfa-bdf5-cc4609b4a249");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "CreatedBy", "CreatedDate", "Email", "EmailConfirmed", "EndDate", "LockoutEnabled", "LockoutEnd", "ModifiedBy", "ModifiedDate", "NormalizedEmail", "NormalizedUserName", "OrgId", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "20ccc3b9-75e7-4bd4-94df-c8a63a204d41", 0, "e7777f79-47db-4972-9075-e7631052ce98", null, new DateTime(2020, 8, 4, 7, 39, 27, 459, DateTimeKind.Local), "sunil.pashikanti@gmail.com", true, null, false, null, null, new DateTime(2020, 8, 4, 7, 39, 27, 460, DateTimeKind.Local), "SUNIL.PASHIKANTI@GMAIL.COM", "SUNIL.PASHIKANTI@GMAIL.COM", 0, "AQAAAAEAACcQAAAAEM0yv8lgbVLteHVtYYQqMnP+ykPwSwXY9ntcbJ8gEp1Br/Z7YbCAUXf6s2jlvdTNyA==", null, false, "TXEFASMBK2TBWRP42UFH6KKKHHLFKAXD", false, "sunil.pashikanti@gmail.com" });

            migrationBuilder.UpdateData(
                table: "Licenses",
                keyColumn: "LicenseId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2020, 8, 4, 7, 39, 27, 498, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Licenses",
                keyColumn: "LicenseId",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2020, 8, 4, 7, 39, 27, 500, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Licenses",
                keyColumn: "LicenseId",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2020, 8, 4, 7, 39, 27, 500, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Licenses",
                keyColumn: "LicenseId",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2020, 8, 4, 7, 39, 27, 500, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Licenses",
                keyColumn: "LicenseId",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2020, 8, 4, 7, 39, 27, 500, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Licenses",
                keyColumn: "LicenseId",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2020, 8, 4, 7, 39, 27, 500, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Licenses",
                keyColumn: "LicenseId",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2020, 8, 4, 7, 39, 27, 500, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Licenses",
                keyColumn: "LicenseId",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2020, 8, 4, 7, 39, 27, 500, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Licenses",
                keyColumn: "LicenseId",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2020, 8, 4, 7, 39, 27, 500, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Licenses",
                keyColumn: "LicenseId",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2020, 8, 4, 7, 39, 27, 500, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Licenses",
                keyColumn: "LicenseId",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2020, 8, 4, 7, 39, 27, 500, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Licenses",
                keyColumn: "LicenseId",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2020, 8, 4, 7, 39, 27, 500, DateTimeKind.Local));

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[] { "20ccc3b9-75e7-4bd4-94df-c8a63a204d41", "1" });
        }
    }
}
