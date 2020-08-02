using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace KalyanamMatrimony.Migrations
{
    public partial class AddedModifieddatestoUserTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "e7bc0a61-a4ea-4813-91ca-824557ee5afb", "1" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "e7bc0a61-a4ea-4813-91ca-824557ee5afb", "e7777f79-47db-4972-9075-e7631052ce98" });

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "AspNetUsers",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "ModifiedBy",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedDate",
                table: "AspNetUsers",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "5b6b335c-d9d5-4d7f-bd1e-d095e6b6a224");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "2d41ceca-8de4-4ad6-b995-eb7a87e31f61");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3",
                column: "ConcurrencyStamp",
                value: "1ab74bf3-f40d-4afb-a6e6-12a12f0c428e");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4",
                column: "ConcurrencyStamp",
                value: "11103ac4-d70d-4b64-9b69-47437219c6be");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "CreatedBy", "CreatedDate", "Email", "EmailConfirmed", "EndDate", "LockoutEnabled", "LockoutEnd", "ModifiedBy", "ModifiedDate", "NormalizedEmail", "NormalizedUserName", "OrgId", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "5a9749b3-416b-4307-99be-f53bcc63106d", 0, "e7777f79-47db-4972-9075-e7631052ce98", null, new DateTime(2020, 8, 2, 12, 52, 9, 265, DateTimeKind.Local), "sunil.pashikanti@gmail.com", true, null, false, null, null, new DateTime(2020, 8, 2, 12, 52, 9, 266, DateTimeKind.Local), "SUNIL.PASHIKANTI@GMAIL.COM", "SUNIL.PASHIKANTI@GMAIL.COM", 0, "AQAAAAEAACcQAAAAEAD8AUrxH3PFNx2XBfDycpbpdGTDC/MfCacY33JI3qomhvKGazOOCcC75YIRmL4tLA==", null, false, "TXEFASMBK2TBWRP42UFH6KKKHHLFKAXD", false, "sunil.pashikanti@gmail.com" });

            migrationBuilder.UpdateData(
                table: "Licenses",
                keyColumn: "LicenseId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2020, 8, 2, 12, 52, 9, 301, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Licenses",
                keyColumn: "LicenseId",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2020, 8, 2, 12, 52, 9, 301, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Licenses",
                keyColumn: "LicenseId",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2020, 8, 2, 12, 52, 9, 301, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Licenses",
                keyColumn: "LicenseId",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2020, 8, 2, 12, 52, 9, 301, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Licenses",
                keyColumn: "LicenseId",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2020, 8, 2, 12, 52, 9, 301, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Licenses",
                keyColumn: "LicenseId",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2020, 8, 2, 12, 52, 9, 301, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Licenses",
                keyColumn: "LicenseId",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2020, 8, 2, 12, 52, 9, 301, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Licenses",
                keyColumn: "LicenseId",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2020, 8, 2, 12, 52, 9, 301, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Licenses",
                keyColumn: "LicenseId",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2020, 8, 2, 12, 52, 9, 301, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Licenses",
                keyColumn: "LicenseId",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2020, 8, 2, 12, 52, 9, 301, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Licenses",
                keyColumn: "LicenseId",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2020, 8, 2, 12, 52, 9, 301, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Licenses",
                keyColumn: "LicenseId",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2020, 8, 2, 12, 52, 9, 301, DateTimeKind.Local));

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[] { "5a9749b3-416b-4307-99be-f53bcc63106d", "1" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "5a9749b3-416b-4307-99be-f53bcc63106d", "1" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "5a9749b3-416b-4307-99be-f53bcc63106d", "e7777f79-47db-4972-9075-e7631052ce98" });

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "ModifiedBy",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "ModifiedDate",
                table: "AspNetUsers");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "1d74ee28-d390-4bfe-92d2-732b6000db33");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "c61f3477-b773-4220-be5d-f30a73360295");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3",
                column: "ConcurrencyStamp",
                value: "4f8f22e5-3182-40d2-bf6c-daf2696f2757");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4",
                column: "ConcurrencyStamp",
                value: "953b006e-af98-44ff-8ce7-ec09a8cce8cb");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "EndDate", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "OrgId", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "e7bc0a61-a4ea-4813-91ca-824557ee5afb", 0, "e7777f79-47db-4972-9075-e7631052ce98", "sunil.pashikanti@gmail.com", true, null, false, null, "SUNIL.PASHIKANTI@GMAIL.COM", "SUNIL.PASHIKANTI@GMAIL.COM", 0, "AQAAAAEAACcQAAAAEL4TjzmkLCjy/6wYKF2P7mAx65fdF8dG6lBqlW6HNBR+Kiojv/PGSvnezCSAkrRJuQ==", null, false, "TXEFASMBK2TBWRP42UFH6KKKHHLFKAXD", false, "sunil.pashikanti@gmail.com" });

            migrationBuilder.UpdateData(
                table: "Licenses",
                keyColumn: "LicenseId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2020, 8, 2, 12, 16, 53, 151, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Licenses",
                keyColumn: "LicenseId",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2020, 8, 2, 12, 16, 53, 152, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Licenses",
                keyColumn: "LicenseId",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2020, 8, 2, 12, 16, 53, 152, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Licenses",
                keyColumn: "LicenseId",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2020, 8, 2, 12, 16, 53, 152, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Licenses",
                keyColumn: "LicenseId",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2020, 8, 2, 12, 16, 53, 152, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Licenses",
                keyColumn: "LicenseId",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2020, 8, 2, 12, 16, 53, 152, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Licenses",
                keyColumn: "LicenseId",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2020, 8, 2, 12, 16, 53, 152, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Licenses",
                keyColumn: "LicenseId",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2020, 8, 2, 12, 16, 53, 152, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Licenses",
                keyColumn: "LicenseId",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2020, 8, 2, 12, 16, 53, 152, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Licenses",
                keyColumn: "LicenseId",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2020, 8, 2, 12, 16, 53, 152, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Licenses",
                keyColumn: "LicenseId",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2020, 8, 2, 12, 16, 53, 152, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Licenses",
                keyColumn: "LicenseId",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2020, 8, 2, 12, 16, 53, 152, DateTimeKind.Local));

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[] { "e7bc0a61-a4ea-4813-91ca-824557ee5afb", "1" });
        }
    }
}
