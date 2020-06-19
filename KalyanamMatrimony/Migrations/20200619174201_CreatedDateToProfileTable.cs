using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace KalyanamMatrimony.Migrations
{
    public partial class CreatedDateToProfileTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "403d4394-9212-4b39-86bc-4d0334afee33", "230dfacc-cf07-4aad-b026-4f70cfd72887" });

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "Profiles",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<int>(
                name: "Sisters",
                table: "Profiles",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "MarriedSisters",
                table: "Profiles",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "MarriedBrothers",
                table: "Profiles",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<float>(
                name: "Height",
                table: "Profiles",
                nullable: true,
                oldClrType: typeof(float));

            migrationBuilder.AlterColumn<int>(
                name: "Gender",
                table: "Profiles",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateOfBirth",
                table: "Profiles",
                nullable: true,
                oldClrType: typeof(DateTime));

            migrationBuilder.AlterColumn<int>(
                name: "Brothers",
                table: "Profiles",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "Age",
                table: "Profiles",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "Profiles",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "EndDate", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "cd97120c-9fcf-4b33-aa08-56395ba58017", 0, "f112d3bd-7007-494f-a099-c0fa1d435f89", "sunil.pashikanti@gmail.com", false, null, false, null, null, null, "AQAAAAEAACcQAAAAEPZ/6w4+04Y/iWjqC9AyZANRUSyhavIYUxDFn4N/VFrWD0a0I4DLkzR64GWgJ8/tXA==", null, false, null, false, "sunil.pashikanti@gmail.com" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "cd97120c-9fcf-4b33-aa08-56395ba58017", "f112d3bd-7007-494f-a099-c0fa1d435f89" });

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "Profiles");

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "Profiles",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Sisters",
                table: "Profiles",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "MarriedSisters",
                table: "Profiles",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "MarriedBrothers",
                table: "Profiles",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<float>(
                name: "Height",
                table: "Profiles",
                nullable: false,
                oldClrType: typeof(float),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Gender",
                table: "Profiles",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateOfBirth",
                table: "Profiles",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Brothers",
                table: "Profiles",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Age",
                table: "Profiles",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "EndDate", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "403d4394-9212-4b39-86bc-4d0334afee33", 0, "230dfacc-cf07-4aad-b026-4f70cfd72887", "sunil.pashikanti@gmail.com", false, null, false, null, null, null, "AQAAAAEAACcQAAAAEPZ/6w4+04Y/iWjqC9AyZANRUSyhavIYUxDFn4N/VFrWD0a0I4DLkzR64GWgJ8/tXA==", null, false, null, false, "sunil.pashikanti@gmail.com" });
        }
    }
}
