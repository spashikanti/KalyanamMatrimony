using Microsoft.EntityFrameworkCore.Migrations;

namespace KalyanamMatrimony.Migrations
{
    public partial class AssistantCount : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "fcadcc1c-990b-4419-88da-651520f14ada", "1" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "ebef2fec-69dd-4c71-be0e-b8f6bb658df9", "b8613dba-00ba-4458-954b-31a160196789" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "fcadcc1c-990b-4419-88da-651520f14ada", "e7777f79-47db-4972-9075-e7631052ce98" });

            migrationBuilder.AddColumn<int>(
                name: "AssistantCount",
                table: "Licenses",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "65161d91-f034-42dc-8569-2a3412b7fc1b");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "686bd8fe-167a-47e7-a047-eee6027a1d45");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3",
                column: "ConcurrencyStamp",
                value: "fb5e4db0-b778-44d7-a1a1-5344c5a9115e");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4",
                column: "ConcurrencyStamp",
                value: "56062032-1d1b-4488-b37c-801eeca856f2");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "EndDate", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "OrgId", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "a01fe416-3e93-4513-95fa-39174e38f6be", 0, "e7777f79-47db-4972-9075-e7631052ce98", "sunil.pashikanti@gmail.com", true, null, false, null, "SUNIL.PASHIKANTI@GMAIL.COM", "SUNIL.PASHIKANTI@GMAIL.COM", 0, "AQAAAAEAACcQAAAAEFV9QgKrO9NWjuDFX9DSYrSfI4WAFVZj7n+qhh0wTCFCu4Y0r5LLyg4pZOxw2gBXVg==", null, false, "TXEFASMBK2TBWRP42UFH6KKKHHLFKAXD", false, "sunil.pashikanti@gmail.com" },
                    { "04ab2f2f-6fa2-4ed1-9b31-c3c8e707ff5e", 0, "b8613dba-00ba-4458-954b-31a160196789", "", true, null, false, null, "", "", 0, "AQAAAAEAACcQAAAAEMAS9rffYg+wbBS5S4k/NY/Tj1YyVcVWORYTJjz5M+Zdz05F1jwqPhH9qT3rK4yiaw==", null, false, "UE2YZGPQD4ZJIX35FVVKTMKJT43XF3OM", false, "" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[] { "a01fe416-3e93-4513-95fa-39174e38f6be", "1" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "a01fe416-3e93-4513-95fa-39174e38f6be", "1" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "04ab2f2f-6fa2-4ed1-9b31-c3c8e707ff5e", "b8613dba-00ba-4458-954b-31a160196789" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "a01fe416-3e93-4513-95fa-39174e38f6be", "e7777f79-47db-4972-9075-e7631052ce98" });

            migrationBuilder.DropColumn(
                name: "AssistantCount",
                table: "Licenses");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "8028eddf-dace-43d6-a807-c4eceddb0898");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "de60b495-f7ef-4eb8-8034-0821abdb3346");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3",
                column: "ConcurrencyStamp",
                value: "3cf2e293-f606-4351-95c7-d1c873d00cf9");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4",
                column: "ConcurrencyStamp",
                value: "9916c136-d127-4ff2-bf89-d57f3cd0aefe");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "EndDate", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "OrgId", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "fcadcc1c-990b-4419-88da-651520f14ada", 0, "e7777f79-47db-4972-9075-e7631052ce98", "sunil.pashikanti@gmail.com", true, null, false, null, "SUNIL.PASHIKANTI@GMAIL.COM", "SUNIL.PASHIKANTI@GMAIL.COM", 0, "AQAAAAEAACcQAAAAELQf1eXgYmil1ZRHPgBONx8J4c4+uNPPelUPY6hf4HGfT8p4f2FWDNR2cROBZvsJVg==", null, false, "TXEFASMBK2TBWRP42UFH6KKKHHLFKAXD", false, "sunil.pashikanti@gmail.com" },
                    { "ebef2fec-69dd-4c71-be0e-b8f6bb658df9", 0, "b8613dba-00ba-4458-954b-31a160196789", "", true, null, false, null, "", "", 0, "AQAAAAEAACcQAAAAEMFsljM5p0mbOgFdoKMtk6+MjpaxF/1hkQfgDAEmSvoOchgpTB+DYoQvIJjZYDB5ag==", null, false, "UE2YZGPQD4ZJIX35FVVKTMKJT43XF3OM", false, "" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[] { "fcadcc1c-990b-4419-88da-651520f14ada", "1" });
        }
    }
}
