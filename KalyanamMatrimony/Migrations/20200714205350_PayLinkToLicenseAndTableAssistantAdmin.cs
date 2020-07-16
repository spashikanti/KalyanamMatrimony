using Microsoft.EntityFrameworkCore.Migrations;

namespace KalyanamMatrimony.Migrations
{
    public partial class PayLinkToLicenseAndTableAssistantAdmin : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "43b2650e-d67f-440b-97a2-bdedbcfe4880", "1" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "43b2650e-d67f-440b-97a2-bdedbcfe4880", "e7777f79-47db-4972-9075-e7631052ce98" });

            migrationBuilder.AddColumn<string>(
                name: "PayLink",
                table: "Licenses",
                nullable: true);

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
                columns: new[] { "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "3cf2e293-f606-4351-95c7-d1c873d00cf9", "AdminAssistant", "ADMINASSISTANT" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "4", "9916c136-d127-4ff2-bf89-d57f3cd0aefe", "Profile", "PROFILE" });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "4", "9916c136-d127-4ff2-bf89-d57f3cd0aefe" });

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

            migrationBuilder.DropColumn(
                name: "PayLink",
                table: "Licenses");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "0b91f2bf-9bfa-43ca-ae7e-ca77eadba356");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "bfe817a2-9e49-43db-a84f-aaf13a558bd3");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "51330a42-2be1-4845-aa82-502eb5012b4e", "Profile", "PROFILE" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "EndDate", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "OrgId", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "43b2650e-d67f-440b-97a2-bdedbcfe4880", 0, "e7777f79-47db-4972-9075-e7631052ce98", "sunil.pashikanti@gmail.com", true, null, false, null, "SUNIL.PASHIKANTI@GMAIL.COM", "SUNIL.PASHIKANTI@GMAIL.COM", 0, "AQAAAAEAACcQAAAAEKZNAs8etuTUkX5o4QzqIxaYEtXAHOkSI2KQul0WbH9bWWc4WVQir7PvShGwqasirA==", null, false, "TXEFASMBK2TBWRP42UFH6KKKHHLFKAXD", false, "sunil.pashikanti@gmail.com" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[] { "43b2650e-d67f-440b-97a2-bdedbcfe4880", "1" });
        }
    }
}
