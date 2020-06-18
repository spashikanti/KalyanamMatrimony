using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace KalyanamMatrimony.Migrations
{
    public partial class UpdatedProfileTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "AboutFamily",
                table: "Profiles",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AboutYourself",
                table: "Profiles",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Age",
                table: "Profiles",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "AnnualIncome",
                table: "Profiles",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AstroProfile",
                table: "Profiles",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "BloodGroup",
                table: "Profiles",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "BodyType",
                table: "Profiles",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Brothers",
                table: "Profiles",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Caste",
                table: "Profiles",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Complexion",
                table: "Profiles",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CurrentLocation",
                table: "Profiles",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DateOfBirth",
                table: "Profiles",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Diet",
                table: "Profiles",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Drink",
                table: "Profiles",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Education",
                table: "Profiles",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FamilyValues",
                table: "Profiles",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FatherName",
                table: "Profiles",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FatherOccupation",
                table: "Profiles",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FavoriteCuisine",
                table: "Profiles",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FavoriteMovies",
                table: "Profiles",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FavoriteMusic",
                table: "Profiles",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Gender",
                table: "Profiles",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Gothram",
                table: "Profiles",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "HaveChildren",
                table: "Profiles",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<float>(
                name: "Height",
                table: "Profiles",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<string>(
                name: "Hobbies",
                table: "Profiles",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Manglik",
                table: "Profiles",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MaritalStatus",
                table: "Profiles",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "MarriedBrothers",
                table: "Profiles",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "MarriedSisters",
                table: "Profiles",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "MotherName",
                table: "Profiles",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MotherOccupation",
                table: "Profiles",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MotherTongue",
                table: "Profiles",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Nakshatram",
                table: "Profiles",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Photo1",
                table: "Profiles",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Photo2",
                table: "Profiles",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Photo3",
                table: "Profiles",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PreferredDress",
                table: "Profiles",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Profession",
                table: "Profiles",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Rasi",
                table: "Profiles",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Religion",
                table: "Profiles",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Sisters",
                table: "Profiles",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Smoke",
                table: "Profiles",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SpokenLanguages",
                table: "Profiles",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Sports",
                table: "Profiles",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SubCaste",
                table: "Profiles",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "University",
                table: "Profiles",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "WorkingAt",
                table: "Profiles",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "EndDate", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "403d4394-9212-4b39-86bc-4d0334afee33", 0, "230dfacc-cf07-4aad-b026-4f70cfd72887", "sunil.pashikanti@gmail.com", false, null, false, null, null, null, "AQAAAAEAACcQAAAAEPZ/6w4+04Y/iWjqC9AyZANRUSyhavIYUxDFn4N/VFrWD0a0I4DLkzR64GWgJ8/tXA==", null, false, null, false, "sunil.pashikanti@gmail.com" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "403d4394-9212-4b39-86bc-4d0334afee33", "230dfacc-cf07-4aad-b026-4f70cfd72887" });

            migrationBuilder.DropColumn(
                name: "AboutFamily",
                table: "Profiles");

            migrationBuilder.DropColumn(
                name: "AboutYourself",
                table: "Profiles");

            migrationBuilder.DropColumn(
                name: "Age",
                table: "Profiles");

            migrationBuilder.DropColumn(
                name: "AnnualIncome",
                table: "Profiles");

            migrationBuilder.DropColumn(
                name: "AstroProfile",
                table: "Profiles");

            migrationBuilder.DropColumn(
                name: "BloodGroup",
                table: "Profiles");

            migrationBuilder.DropColumn(
                name: "BodyType",
                table: "Profiles");

            migrationBuilder.DropColumn(
                name: "Brothers",
                table: "Profiles");

            migrationBuilder.DropColumn(
                name: "Caste",
                table: "Profiles");

            migrationBuilder.DropColumn(
                name: "Complexion",
                table: "Profiles");

            migrationBuilder.DropColumn(
                name: "CurrentLocation",
                table: "Profiles");

            migrationBuilder.DropColumn(
                name: "DateOfBirth",
                table: "Profiles");

            migrationBuilder.DropColumn(
                name: "Diet",
                table: "Profiles");

            migrationBuilder.DropColumn(
                name: "Drink",
                table: "Profiles");

            migrationBuilder.DropColumn(
                name: "Education",
                table: "Profiles");

            migrationBuilder.DropColumn(
                name: "FamilyValues",
                table: "Profiles");

            migrationBuilder.DropColumn(
                name: "FatherName",
                table: "Profiles");

            migrationBuilder.DropColumn(
                name: "FatherOccupation",
                table: "Profiles");

            migrationBuilder.DropColumn(
                name: "FavoriteCuisine",
                table: "Profiles");

            migrationBuilder.DropColumn(
                name: "FavoriteMovies",
                table: "Profiles");

            migrationBuilder.DropColumn(
                name: "FavoriteMusic",
                table: "Profiles");

            migrationBuilder.DropColumn(
                name: "Gender",
                table: "Profiles");

            migrationBuilder.DropColumn(
                name: "Gothram",
                table: "Profiles");

            migrationBuilder.DropColumn(
                name: "HaveChildren",
                table: "Profiles");

            migrationBuilder.DropColumn(
                name: "Height",
                table: "Profiles");

            migrationBuilder.DropColumn(
                name: "Hobbies",
                table: "Profiles");

            migrationBuilder.DropColumn(
                name: "Manglik",
                table: "Profiles");

            migrationBuilder.DropColumn(
                name: "MaritalStatus",
                table: "Profiles");

            migrationBuilder.DropColumn(
                name: "MarriedBrothers",
                table: "Profiles");

            migrationBuilder.DropColumn(
                name: "MarriedSisters",
                table: "Profiles");

            migrationBuilder.DropColumn(
                name: "MotherName",
                table: "Profiles");

            migrationBuilder.DropColumn(
                name: "MotherOccupation",
                table: "Profiles");

            migrationBuilder.DropColumn(
                name: "MotherTongue",
                table: "Profiles");

            migrationBuilder.DropColumn(
                name: "Nakshatram",
                table: "Profiles");

            migrationBuilder.DropColumn(
                name: "Photo1",
                table: "Profiles");

            migrationBuilder.DropColumn(
                name: "Photo2",
                table: "Profiles");

            migrationBuilder.DropColumn(
                name: "Photo3",
                table: "Profiles");

            migrationBuilder.DropColumn(
                name: "PreferredDress",
                table: "Profiles");

            migrationBuilder.DropColumn(
                name: "Profession",
                table: "Profiles");

            migrationBuilder.DropColumn(
                name: "Rasi",
                table: "Profiles");

            migrationBuilder.DropColumn(
                name: "Religion",
                table: "Profiles");

            migrationBuilder.DropColumn(
                name: "Sisters",
                table: "Profiles");

            migrationBuilder.DropColumn(
                name: "Smoke",
                table: "Profiles");

            migrationBuilder.DropColumn(
                name: "SpokenLanguages",
                table: "Profiles");

            migrationBuilder.DropColumn(
                name: "Sports",
                table: "Profiles");

            migrationBuilder.DropColumn(
                name: "SubCaste",
                table: "Profiles");

            migrationBuilder.DropColumn(
                name: "University",
                table: "Profiles");

            migrationBuilder.DropColumn(
                name: "WorkingAt",
                table: "Profiles");
        }
    }
}
