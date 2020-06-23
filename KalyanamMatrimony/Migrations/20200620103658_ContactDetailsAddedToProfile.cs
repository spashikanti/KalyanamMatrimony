using Microsoft.EntityFrameworkCore.Migrations;

namespace KalyanamMatrimony.Migrations
{
    public partial class ContactDetailsAddedToProfile : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "cd97120c-9fcf-4b33-aa08-56395ba58017", "f112d3bd-7007-494f-a099-c0fa1d435f89" });

            migrationBuilder.AddColumn<string>(
                name: "ContactPersonName",
                table: "Profiles",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ContactPersonRelationShip",
                table: "Profiles",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PhoneNumber",
                table: "Profiles",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "EndDate", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "2e303b74-60b2-4f11-9dec-9d59cc56438c", 0, "e6c61180-62fb-4a9b-8dfd-45292cfb0bfc", "sunil.pashikanti@gmail.com", false, null, false, null, null, null, "AQAAAAEAACcQAAAAEPZ/6w4+04Y/iWjqC9AyZANRUSyhavIYUxDFn4N/VFrWD0a0I4DLkzR64GWgJ8/tXA==", null, false, null, false, "sunil.pashikanti@gmail.com" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "2e303b74-60b2-4f11-9dec-9d59cc56438c", "e6c61180-62fb-4a9b-8dfd-45292cfb0bfc" });

            migrationBuilder.DropColumn(
                name: "ContactPersonName",
                table: "Profiles");

            migrationBuilder.DropColumn(
                name: "ContactPersonRelationShip",
                table: "Profiles");

            migrationBuilder.DropColumn(
                name: "PhoneNumber",
                table: "Profiles");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "EndDate", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "cd97120c-9fcf-4b33-aa08-56395ba58017", 0, "f112d3bd-7007-494f-a099-c0fa1d435f89", "sunil.pashikanti@gmail.com", false, null, false, null, null, null, "AQAAAAEAACcQAAAAEPZ/6w4+04Y/iWjqC9AyZANRUSyhavIYUxDFn4N/VFrWD0a0I4DLkzR64GWgJ8/tXA==", null, false, null, false, "sunil.pashikanti@gmail.com" });
        }
    }
}
