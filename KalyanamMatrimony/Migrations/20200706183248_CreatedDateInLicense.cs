using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace KalyanamMatrimony.Migrations
{
    public partial class CreatedDateInLicense : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "d4d5261e-07fb-4001-80b0-b2f09fe985a9", "1" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "d4d5261e-07fb-4001-80b0-b2f09fe985a9", "e7777f79-47db-4972-9075-e7631052ce98" });

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "Licenses",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "c406d409-008a-4484-bab9-b6d3f2cb4add");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "b1eaae48-ab8d-4810-af5f-49487896c4f6");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3",
                column: "ConcurrencyStamp",
                value: "e45c88be-b84f-43eb-880a-bd49767e4f8b");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "EndDate", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "OrgId", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "137c8783-2272-4fd1-aa12-27dc27d5fdc9", 0, "e7777f79-47db-4972-9075-e7631052ce98", "sunil.pashikanti@gmail.com", true, null, false, null, "SUNIL.PASHIKANTI@GMAIL.COM", "SUNIL.PASHIKANTI@GMAIL.COM", 0, "AQAAAAEAACcQAAAAEI7TUC6Wt/BhylP5eS8NXtUVCAYPjbRvO4LOdRZKBrei9TVj0f4JEsKzh4WrnB+7UQ==", null, false, "TXEFASMBK2TBWRP42UFH6KKKHHLFKAXD", false, "sunil.pashikanti@gmail.com" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[] { "137c8783-2272-4fd1-aa12-27dc27d5fdc9", "1" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "137c8783-2272-4fd1-aa12-27dc27d5fdc9", "1" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "137c8783-2272-4fd1-aa12-27dc27d5fdc9", "e7777f79-47db-4972-9075-e7631052ce98" });

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "Licenses");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "eb5fde35-bad6-420b-8e3e-1a2878d288a5");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "6b3ff374-5bc2-4b02-8a2b-4ea6ecbad098");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3",
                column: "ConcurrencyStamp",
                value: "b86e2eb3-8fbc-4db6-ab96-e225e6623649");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "EndDate", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "OrgId", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "d4d5261e-07fb-4001-80b0-b2f09fe985a9", 0, "e7777f79-47db-4972-9075-e7631052ce98", "sunil.pashikanti@gmail.com", true, null, false, null, "SUNIL.PASHIKANTI@GMAIL.COM", "SUNIL.PASHIKANTI@GMAIL.COM", 0, "AQAAAAEAACcQAAAAEFoPKogLe5EUPIYeULho29Vo4ndia2EIZWxaU0x8etxiIuGaWHfeNrRzGml5t/KXZQ==", null, false, "TXEFASMBK2TBWRP42UFH6KKKHHLFKAXD", false, "sunil.pashikanti@gmail.com" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[] { "d4d5261e-07fb-4001-80b0-b2f09fe985a9", "1" });
        }
    }
}
