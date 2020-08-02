using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace KalyanamMatrimony.Migrations
{
    public partial class AddedModifieddates : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "f928927f-32a8-4c4f-bbca-dc2a2605c900", "1" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "f928927f-32a8-4c4f-bbca-dc2a2605c900", "e7777f79-47db-4972-9075-e7631052ce98" });

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "Profiles",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ModifiedBy",
                table: "Profiles",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedDate",
                table: "Profiles",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "PaymentHistory",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "PaymentHistory",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "ModifiedBy",
                table: "PaymentHistory",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedDate",
                table: "PaymentHistory",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "ModifiedBy",
                table: "Organisations",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedDate",
                table: "Organisations",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "e7bc0a61-a4ea-4813-91ca-824557ee5afb", "1" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "e7bc0a61-a4ea-4813-91ca-824557ee5afb", "e7777f79-47db-4972-9075-e7631052ce98" });

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "Profiles");

            migrationBuilder.DropColumn(
                name: "ModifiedBy",
                table: "Profiles");

            migrationBuilder.DropColumn(
                name: "ModifiedDate",
                table: "Profiles");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "PaymentHistory");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "PaymentHistory");

            migrationBuilder.DropColumn(
                name: "ModifiedBy",
                table: "PaymentHistory");

            migrationBuilder.DropColumn(
                name: "ModifiedDate",
                table: "PaymentHistory");

            migrationBuilder.DropColumn(
                name: "ModifiedBy",
                table: "Organisations");

            migrationBuilder.DropColumn(
                name: "ModifiedDate",
                table: "Organisations");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "80dd6a7f-bcc1-405e-bd38-47691e9da570");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "255b6a9b-049e-4850-8942-54c2bcadc044");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3",
                column: "ConcurrencyStamp",
                value: "77d0bae2-9220-45f5-a0f0-4f9d1e2723c6");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4",
                column: "ConcurrencyStamp",
                value: "96ccf17e-54e6-4493-aea4-fcbcc63d0322");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "EndDate", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "OrgId", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "f928927f-32a8-4c4f-bbca-dc2a2605c900", 0, "e7777f79-47db-4972-9075-e7631052ce98", "sunil.pashikanti@gmail.com", true, null, false, null, "SUNIL.PASHIKANTI@GMAIL.COM", "SUNIL.PASHIKANTI@GMAIL.COM", 0, "AQAAAAEAACcQAAAAEKOxDKoa+XqIA/lRQDkZD1MyGLLEaC1lD0B1VaGEU68HwmV7aEbveLexXGT6qfChQQ==", null, false, "TXEFASMBK2TBWRP42UFH6KKKHHLFKAXD", false, "sunil.pashikanti@gmail.com" });

            migrationBuilder.UpdateData(
                table: "Licenses",
                keyColumn: "LicenseId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2020, 8, 1, 9, 46, 7, 350, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Licenses",
                keyColumn: "LicenseId",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2020, 8, 1, 9, 46, 7, 351, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Licenses",
                keyColumn: "LicenseId",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2020, 8, 1, 9, 46, 7, 351, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Licenses",
                keyColumn: "LicenseId",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2020, 8, 1, 9, 46, 7, 351, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Licenses",
                keyColumn: "LicenseId",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2020, 8, 1, 9, 46, 7, 351, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Licenses",
                keyColumn: "LicenseId",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2020, 8, 1, 9, 46, 7, 351, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Licenses",
                keyColumn: "LicenseId",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2020, 8, 1, 9, 46, 7, 351, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Licenses",
                keyColumn: "LicenseId",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2020, 8, 1, 9, 46, 7, 351, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Licenses",
                keyColumn: "LicenseId",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2020, 8, 1, 9, 46, 7, 351, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Licenses",
                keyColumn: "LicenseId",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2020, 8, 1, 9, 46, 7, 351, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Licenses",
                keyColumn: "LicenseId",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2020, 8, 1, 9, 46, 7, 351, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Licenses",
                keyColumn: "LicenseId",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2020, 8, 1, 9, 46, 7, 351, DateTimeKind.Local));

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[] { "f928927f-32a8-4c4f-bbca-dc2a2605c900", "1" });
        }
    }
}
