using Microsoft.EntityFrameworkCore.Migrations;

namespace KalyanamMatrimony.Migrations
{
    public partial class PartnerPreference : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
