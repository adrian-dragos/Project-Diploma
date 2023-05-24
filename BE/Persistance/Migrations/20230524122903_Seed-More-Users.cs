using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    public partial class SeedMoreUsers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 1,
                column: "Year",
                value: new DateTime(2019, 6, 4, 13, 11, 43, 533, DateTimeKind.Local).AddTicks(2521));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 2,
                column: "Year",
                value: new DateTime(2018, 7, 2, 8, 6, 21, 308, DateTimeKind.Local).AddTicks(1361));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 3,
                column: "Year",
                value: new DateTime(2019, 1, 4, 18, 31, 0, 712, DateTimeKind.Local).AddTicks(6002));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 4,
                column: "Year",
                value: new DateTime(2018, 5, 28, 4, 4, 43, 854, DateTimeKind.Local).AddTicks(9083));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 5,
                column: "Year",
                value: new DateTime(2021, 1, 29, 12, 2, 54, 420, DateTimeKind.Local).AddTicks(923));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 6,
                column: "Year",
                value: new DateTime(2020, 3, 30, 22, 44, 45, 77, DateTimeKind.Local).AddTicks(2580));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 7,
                column: "Year",
                value: new DateTime(2018, 12, 6, 9, 55, 4, 196, DateTimeKind.Local).AddTicks(2093));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 8,
                column: "Year",
                value: new DateTime(2021, 2, 27, 19, 55, 15, 322, DateTimeKind.Local).AddTicks(8150));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 9,
                column: "Year",
                value: new DateTime(2020, 12, 17, 0, 35, 32, 291, DateTimeKind.Local).AddTicks(8042));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 10,
                column: "Year",
                value: new DateTime(2021, 3, 12, 9, 44, 12, 477, DateTimeKind.Local).AddTicks(8218));

            migrationBuilder.UpdateData(
                table: "InstructorCars",
                keyColumns: new[] { "CarId", "InstructorId" },
                keyValues: new object[] { 1, 1 },
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2023, 5, 24, 15, 29, 2, 291, DateTimeKind.Unspecified).AddTicks(4000), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "InstructorCars",
                keyColumns: new[] { "CarId", "InstructorId" },
                keyValues: new object[] { 2, 1 },
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2023, 5, 24, 15, 29, 2, 291, DateTimeKind.Unspecified).AddTicks(4000), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "InstructorCars",
                keyColumns: new[] { "CarId", "InstructorId" },
                keyValues: new object[] { 1, 2 },
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2023, 5, 24, 15, 29, 2, 291, DateTimeKind.Unspecified).AddTicks(4000), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Instructors",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2023, 5, 24, 12, 29, 2, 291, DateTimeKind.Unspecified).AddTicks(4688), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Instructors",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2023, 5, 24, 12, 29, 2, 291, DateTimeKind.Unspecified).AddTicks(4688), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2023, 5, 24, 12, 29, 2, 292, DateTimeKind.Unspecified).AddTicks(7775), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2023, 5, 24, 12, 29, 2, 292, DateTimeKind.Unspecified).AddTicks(7775), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2023, 5, 24, 12, 29, 2, 292, DateTimeKind.Unspecified).AddTicks(7775), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Policy",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2023, 5, 24, 15, 29, 2, 292, DateTimeKind.Unspecified).AddTicks(9574), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Policy",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2023, 5, 24, 15, 29, 2, 292, DateTimeKind.Unspecified).AddTicks(9574), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Policy",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2023, 5, 24, 15, 29, 2, 292, DateTimeKind.Unspecified).AddTicks(9574), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "PolicyRole",
                keyColumns: new[] { "PolicyId", "RoleId" },
                keyValues: new object[] { 1, 1 },
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2023, 5, 24, 15, 29, 2, 293, DateTimeKind.Unspecified).AddTicks(4327), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "PolicyRole",
                keyColumns: new[] { "PolicyId", "RoleId" },
                keyValues: new object[] { 2, 1 },
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2023, 5, 24, 15, 29, 2, 293, DateTimeKind.Unspecified).AddTicks(4327), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "PolicyRole",
                keyColumns: new[] { "PolicyId", "RoleId" },
                keyValues: new object[] { 2, 2 },
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2023, 5, 24, 15, 29, 2, 293, DateTimeKind.Unspecified).AddTicks(4327), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "PolicyRole",
                keyColumns: new[] { "PolicyId", "RoleId" },
                keyValues: new object[] { 3, 3 },
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2023, 5, 24, 15, 29, 2, 293, DateTimeKind.Unspecified).AddTicks(4327), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Role",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2023, 5, 24, 15, 29, 2, 295, DateTimeKind.Unspecified).AddTicks(2229), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Role",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2023, 5, 24, 15, 29, 2, 295, DateTimeKind.Unspecified).AddTicks(2229), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Role",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2023, 5, 24, 15, 29, 2, 295, DateTimeKind.Unspecified).AddTicks(2229), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2023, 5, 24, 12, 29, 2, 295, DateTimeKind.Unspecified).AddTicks(3326), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2023, 5, 24, 12, 29, 2, 295, DateTimeKind.Unspecified).AddTicks(3326), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Birthday", "CreatedAt", "CreatedBy", "Email", "FirstName", "LastModifiedAt", "LastModifiedBy", "LastName", "Password", "PhoneNumber", "RoleId" },
                values: new object[,]
                {
                    { 11, new DateTime(1996, 6, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTimeOffset(new DateTime(2023, 5, 1, 11, 50, 43, 880, DateTimeKind.Unspecified).AddTicks(7923), new TimeSpan(0, 0, 0, 0, 0)), "System Seeding", "Vickie14@yahoo.com", "Vickie", null, null, "Borer", "test", "+40 749 852 232", 1 },
                    { 12, new DateTime(1998, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTimeOffset(new DateTime(2023, 5, 1, 11, 50, 43, 880, DateTimeKind.Unspecified).AddTicks(7923), new TimeSpan(0, 0, 0, 0, 0)), "System Seeding", "Hannah.Welch43@gmail.com", "Hannah", null, null, "Welch", "test", "+40 748 975 984", 1 },
                    { 13, new DateTime(1973, 12, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTimeOffset(new DateTime(2023, 5, 1, 11, 50, 43, 880, DateTimeKind.Unspecified).AddTicks(7923), new TimeSpan(0, 0, 0, 0, 0)), "System Seeding", "Willie_Kertzmann47@yahoo.com", "Willie", null, null, "Kertzmann", "test", "+40 744 836 590", 2 },
                    { 14, new DateTime(1989, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTimeOffset(new DateTime(2023, 5, 1, 11, 50, 43, 880, DateTimeKind.Unspecified).AddTicks(7923), new TimeSpan(0, 0, 0, 0, 0)), "System Seeding", "Ronnie_Boyle27@gmail.com", "Ronnie", null, null, "Boyle", "test", "+40 740 773 284", 1 },
                    { 15, new DateTime(1992, 9, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTimeOffset(new DateTime(2023, 5, 1, 11, 50, 43, 880, DateTimeKind.Unspecified).AddTicks(7923), new TimeSpan(0, 0, 0, 0, 0)), "System Seeding", "Russell_Corkery@yahoo.com", "Russell", null, null, "Corkery", "test", "+40 741 645 125", 2 },
                    { 16, new DateTime(1980, 4, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTimeOffset(new DateTime(2023, 5, 1, 11, 50, 43, 880, DateTimeKind.Unspecified).AddTicks(7923), new TimeSpan(0, 0, 0, 0, 0)), "System Seeding", "Allen31@gmail.com", "Allen", null, null, "Barton", "test", "+40 741 666 019", 1 },
                    { 17, new DateTime(1996, 9, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTimeOffset(new DateTime(2023, 5, 1, 11, 50, 43, 880, DateTimeKind.Unspecified).AddTicks(7923), new TimeSpan(0, 0, 0, 0, 0)), "System Seeding", "Gregg26@yahoo.com", "Gregg", null, null, "Harber", "test", "+40 749 413 264", 2 },
                    { 18, new DateTime(1995, 11, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTimeOffset(new DateTime(2023, 5, 1, 11, 50, 43, 880, DateTimeKind.Unspecified).AddTicks(7923), new TimeSpan(0, 0, 0, 0, 0)), "System Seeding", "Barbara.Predovic67@gmail.com", "Barbara", null, null, "Predovic", "test", "+40 742 591 086", 1 },
                    { 19, new DateTime(1985, 10, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTimeOffset(new DateTime(2023, 5, 1, 11, 50, 43, 880, DateTimeKind.Unspecified).AddTicks(7923), new TimeSpan(0, 0, 0, 0, 0)), "System Seeding", "Casey42@hotmail.com", "Casey", null, null, "Hagenes", "test", "+40 744 700 580", 3 },
                    { 20, new DateTime(1994, 12, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTimeOffset(new DateTime(2023, 5, 1, 11, 50, 43, 880, DateTimeKind.Unspecified).AddTicks(7923), new TimeSpan(0, 0, 0, 0, 0)), "System Seeding", "Carrie47@yahoo.com", "Carrie", null, null, "Johnson", "test", "+40 747 645 343", 2 },
                    { 21, new DateTime(1983, 8, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTimeOffset(new DateTime(2023, 5, 1, 11, 50, 43, 880, DateTimeKind.Unspecified).AddTicks(7923), new TimeSpan(0, 0, 0, 0, 0)), "System Seeding", "Elvira51@gmail.com", "Elvira", null, null, "Conroy", "test", "+40 741 130 401", 2 },
                    { 22, new DateTime(1979, 12, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTimeOffset(new DateTime(2023, 5, 1, 11, 50, 43, 880, DateTimeKind.Unspecified).AddTicks(7923), new TimeSpan(0, 0, 0, 0, 0)), "System Seeding", "Justin98@yahoo.com", "Justin", null, null, "Crist", "test", "+40 748 305 797", 1 }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Birthday", "CreatedAt", "CreatedBy", "Email", "FirstName", "LastModifiedAt", "LastModifiedBy", "LastName", "Password", "PhoneNumber", "RoleId" },
                values: new object[,]
                {
                    { 23, new DateTime(1996, 4, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTimeOffset(new DateTime(2023, 5, 1, 11, 50, 43, 880, DateTimeKind.Unspecified).AddTicks(7923), new TimeSpan(0, 0, 0, 0, 0)), "System Seeding", "Shannon24@gmail.com", "Shannon", null, null, "Spencer", "test", "+40 740 885 568", 1 },
                    { 24, new DateTime(1988, 12, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTimeOffset(new DateTime(2023, 5, 1, 11, 50, 43, 880, DateTimeKind.Unspecified).AddTicks(7923), new TimeSpan(0, 0, 0, 0, 0)), "System Seeding", "Paul32@hotmail.com", "Paul", null, null, "Hamill", "test", "+40 748 860 452", 3 },
                    { 25, new DateTime(1973, 9, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTimeOffset(new DateTime(2023, 5, 1, 11, 50, 43, 880, DateTimeKind.Unspecified).AddTicks(7923), new TimeSpan(0, 0, 0, 0, 0)), "System Seeding", "Sylvia.Von58@yahoo.com", "Sylvia", null, null, "Von", "test", "+40 742 814 763", 3 },
                    { 26, new DateTime(1977, 6, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTimeOffset(new DateTime(2023, 5, 1, 11, 50, 43, 880, DateTimeKind.Unspecified).AddTicks(7923), new TimeSpan(0, 0, 0, 0, 0)), "System Seeding", "Ollie.Grady@hotmail.com", "Ollie", null, null, "Grady", "test", "+40 741 660 734", 2 },
                    { 27, new DateTime(1988, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTimeOffset(new DateTime(2023, 5, 1, 11, 50, 43, 880, DateTimeKind.Unspecified).AddTicks(7923), new TimeSpan(0, 0, 0, 0, 0)), "System Seeding", "Courtney.Weissnat@yahoo.com", "Courtney", null, null, "Weissnat", "test", "+40 743 488 529", 1 },
                    { 28, new DateTime(1987, 7, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTimeOffset(new DateTime(2023, 5, 1, 11, 50, 43, 880, DateTimeKind.Unspecified).AddTicks(7923), new TimeSpan(0, 0, 0, 0, 0)), "System Seeding", "Billy.Schmeler29@gmail.com", "Billy", null, null, "Schmeler", "test", "+40 745 788 434", 3 },
                    { 29, new DateTime(1983, 5, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTimeOffset(new DateTime(2023, 5, 1, 11, 50, 43, 880, DateTimeKind.Unspecified).AddTicks(7923), new TimeSpan(0, 0, 0, 0, 0)), "System Seeding", "Ellis.Rath@gmail.com", "Ellis", null, null, "Rath", "test", "+40 745 539 503", 1 },
                    { 30, new DateTime(1995, 6, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTimeOffset(new DateTime(2023, 5, 1, 11, 50, 43, 880, DateTimeKind.Unspecified).AddTicks(7923), new TimeSpan(0, 0, 0, 0, 0)), "System Seeding", "Eunice_Hartmann84@hotmail.com", "Eunice", null, null, "Hartmann", "test", "+40 746 038 497", 3 },
                    { 31, new DateTime(1973, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTimeOffset(new DateTime(2023, 5, 1, 11, 50, 43, 880, DateTimeKind.Unspecified).AddTicks(7923), new TimeSpan(0, 0, 0, 0, 0)), "System Seeding", "Leon8@gmail.com", "Leon", null, null, "Bahringer", "test", "+40 741 467 367", 3 },
                    { 32, new DateTime(1977, 9, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTimeOffset(new DateTime(2023, 5, 1, 11, 50, 43, 880, DateTimeKind.Unspecified).AddTicks(7923), new TimeSpan(0, 0, 0, 0, 0)), "System Seeding", "Rex_Crist92@hotmail.com", "Rex", null, null, "Crist", "test", "+40 743 797 312", 2 },
                    { 33, new DateTime(1975, 12, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTimeOffset(new DateTime(2023, 5, 1, 11, 50, 43, 880, DateTimeKind.Unspecified).AddTicks(7923), new TimeSpan(0, 0, 0, 0, 0)), "System Seeding", "Larry_Feil@yahoo.com", "Larry", null, null, "Feil", "test", "+40 746 837 518", 1 },
                    { 34, new DateTime(1975, 3, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTimeOffset(new DateTime(2023, 5, 1, 11, 50, 43, 880, DateTimeKind.Unspecified).AddTicks(7923), new TimeSpan(0, 0, 0, 0, 0)), "System Seeding", "Roberto64@hotmail.com", "Roberto", null, null, "Johnson", "test", "+40 744 554 287", 1 },
                    { 35, new DateTime(1989, 6, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTimeOffset(new DateTime(2023, 5, 1, 11, 50, 43, 880, DateTimeKind.Unspecified).AddTicks(7923), new TimeSpan(0, 0, 0, 0, 0)), "System Seeding", "Ollie_Rau@gmail.com", "Ollie", null, null, "Rau", "test", "+40 749 185 137", 1 },
                    { 36, new DateTime(1975, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTimeOffset(new DateTime(2023, 5, 1, 11, 50, 43, 880, DateTimeKind.Unspecified).AddTicks(7923), new TimeSpan(0, 0, 0, 0, 0)), "System Seeding", "Joshua_Gislason79@yahoo.com", "Joshua", null, null, "Gislason", "test", "+40 747 875 516", 2 },
                    { 37, new DateTime(1997, 10, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTimeOffset(new DateTime(2023, 5, 1, 11, 50, 43, 880, DateTimeKind.Unspecified).AddTicks(7923), new TimeSpan(0, 0, 0, 0, 0)), "System Seeding", "Jacquelyn93@gmail.com", "Jacquelyn", null, null, "Abbott", "test", "+40 745 897 819", 3 },
                    { 38, new DateTime(1986, 4, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTimeOffset(new DateTime(2023, 5, 1, 11, 50, 43, 880, DateTimeKind.Unspecified).AddTicks(7923), new TimeSpan(0, 0, 0, 0, 0)), "System Seeding", "Courtney46@hotmail.com", "Courtney", null, null, "Konopelski", "test", "+40 745 367 305", 1 },
                    { 39, new DateTime(1988, 6, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTimeOffset(new DateTime(2023, 5, 1, 11, 50, 43, 880, DateTimeKind.Unspecified).AddTicks(7923), new TimeSpan(0, 0, 0, 0, 0)), "System Seeding", "Don_VonRueden49@hotmail.com", "Don", null, null, "VonRueden", "test", "+40 748 036 666", 2 },
                    { 40, new DateTime(1975, 3, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTimeOffset(new DateTime(2023, 5, 1, 11, 50, 43, 880, DateTimeKind.Unspecified).AddTicks(7923), new TimeSpan(0, 0, 0, 0, 0)), "System Seeding", "Isabel_Barrows@hotmail.com", "Isabel", null, null, "Barrows", "test", "+40 748 872 640", 3 },
                    { 41, new DateTime(1998, 3, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTimeOffset(new DateTime(2023, 5, 1, 11, 50, 43, 880, DateTimeKind.Unspecified).AddTicks(7923), new TimeSpan(0, 0, 0, 0, 0)), "System Seeding", "Duane_Murphy76@yahoo.com", "Duane", null, null, "Murphy", "test", "+40 744 593 423", 3 },
                    { 42, new DateTime(1991, 6, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTimeOffset(new DateTime(2023, 5, 1, 11, 50, 43, 880, DateTimeKind.Unspecified).AddTicks(7923), new TimeSpan(0, 0, 0, 0, 0)), "System Seeding", "Homer.Purdy@gmail.com", "Homer", null, null, "Purdy", "test", "+40 746 482 790", 2 },
                    { 43, new DateTime(1977, 1, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTimeOffset(new DateTime(2023, 5, 1, 11, 50, 43, 880, DateTimeKind.Unspecified).AddTicks(7923), new TimeSpan(0, 0, 0, 0, 0)), "System Seeding", "Carolyn14@yahoo.com", "Carolyn", null, null, "Deckow", "test", "+40 747 021 182", 1 },
                    { 44, new DateTime(1989, 11, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTimeOffset(new DateTime(2023, 5, 1, 11, 50, 43, 880, DateTimeKind.Unspecified).AddTicks(7923), new TimeSpan(0, 0, 0, 0, 0)), "System Seeding", "Vivian.Maggio22@hotmail.com", "Vivian", null, null, "Maggio", "test", "+40 742 063 443", 1 },
                    { 45, new DateTime(1991, 10, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTimeOffset(new DateTime(2023, 5, 1, 11, 50, 43, 880, DateTimeKind.Unspecified).AddTicks(7923), new TimeSpan(0, 0, 0, 0, 0)), "System Seeding", "Ramon73@gmail.com", "Ramon", null, null, "O'Conner", "test", "+40 749 795 409", 1 },
                    { 46, new DateTime(1979, 12, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTimeOffset(new DateTime(2023, 5, 1, 11, 50, 43, 880, DateTimeKind.Unspecified).AddTicks(7923), new TimeSpan(0, 0, 0, 0, 0)), "System Seeding", "Roger_Brekke44@hotmail.com", "Roger", null, null, "Brekke", "test", "+40 740 449 287", 3 },
                    { 47, new DateTime(1995, 1, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTimeOffset(new DateTime(2023, 5, 1, 11, 50, 43, 880, DateTimeKind.Unspecified).AddTicks(7923), new TimeSpan(0, 0, 0, 0, 0)), "System Seeding", "Ralph66@gmail.com", "Ralph", null, null, "Ankunding", "test", "+40 749 396 483", 2 },
                    { 48, new DateTime(1993, 7, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTimeOffset(new DateTime(2023, 5, 1, 11, 50, 43, 880, DateTimeKind.Unspecified).AddTicks(7923), new TimeSpan(0, 0, 0, 0, 0)), "System Seeding", "Garrett14@gmail.com", "Garrett", null, null, "Connelly", "test", "+40 740 621 804", 1 },
                    { 49, new DateTime(1991, 3, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTimeOffset(new DateTime(2023, 5, 1, 11, 50, 43, 880, DateTimeKind.Unspecified).AddTicks(7923), new TimeSpan(0, 0, 0, 0, 0)), "System Seeding", "Ginger.Armstrong@gmail.com", "Ginger", null, null, "Armstrong", "test", "+40 743 272 815", 1 },
                    { 50, new DateTime(1979, 12, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTimeOffset(new DateTime(2023, 5, 1, 11, 50, 43, 880, DateTimeKind.Unspecified).AddTicks(7923), new TimeSpan(0, 0, 0, 0, 0)), "System Seeding", "Kelly_Pouros@yahoo.com", "Kelly", null, null, "Pouros", "test", "+40 746 068 948", 3 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 1,
                column: "Year",
                value: new DateTime(2019, 6, 4, 10, 34, 24, 348, DateTimeKind.Local).AddTicks(1028));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 2,
                column: "Year",
                value: new DateTime(2018, 7, 2, 5, 29, 2, 122, DateTimeKind.Local).AddTicks(9899));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 3,
                column: "Year",
                value: new DateTime(2019, 1, 4, 15, 53, 41, 527, DateTimeKind.Local).AddTicks(4535));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 4,
                column: "Year",
                value: new DateTime(2018, 5, 28, 1, 27, 24, 669, DateTimeKind.Local).AddTicks(7531));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 5,
                column: "Year",
                value: new DateTime(2021, 1, 29, 9, 25, 35, 234, DateTimeKind.Local).AddTicks(9366));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 6,
                column: "Year",
                value: new DateTime(2020, 3, 30, 20, 7, 25, 892, DateTimeKind.Local).AddTicks(1087));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 7,
                column: "Year",
                value: new DateTime(2018, 12, 6, 7, 17, 45, 11, DateTimeKind.Local).AddTicks(599));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 8,
                column: "Year",
                value: new DateTime(2021, 2, 27, 17, 17, 56, 137, DateTimeKind.Local).AddTicks(6658));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 9,
                column: "Year",
                value: new DateTime(2020, 12, 16, 21, 58, 13, 106, DateTimeKind.Local).AddTicks(6556));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 10,
                column: "Year",
                value: new DateTime(2021, 3, 12, 7, 6, 53, 292, DateTimeKind.Local).AddTicks(6731));

            migrationBuilder.UpdateData(
                table: "InstructorCars",
                keyColumns: new[] { "CarId", "InstructorId" },
                keyValues: new object[] { 1, 1 },
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2023, 5, 24, 12, 51, 43, 96, DateTimeKind.Unspecified).AddTicks(1700), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "InstructorCars",
                keyColumns: new[] { "CarId", "InstructorId" },
                keyValues: new object[] { 2, 1 },
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2023, 5, 24, 12, 51, 43, 96, DateTimeKind.Unspecified).AddTicks(1700), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "InstructorCars",
                keyColumns: new[] { "CarId", "InstructorId" },
                keyValues: new object[] { 1, 2 },
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2023, 5, 24, 12, 51, 43, 96, DateTimeKind.Unspecified).AddTicks(1700), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Instructors",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2023, 5, 24, 9, 51, 43, 96, DateTimeKind.Unspecified).AddTicks(2341), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Instructors",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2023, 5, 24, 9, 51, 43, 96, DateTimeKind.Unspecified).AddTicks(2341), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2023, 5, 24, 9, 51, 43, 97, DateTimeKind.Unspecified).AddTicks(6478), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2023, 5, 24, 9, 51, 43, 97, DateTimeKind.Unspecified).AddTicks(6478), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2023, 5, 24, 9, 51, 43, 97, DateTimeKind.Unspecified).AddTicks(6478), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Policy",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2023, 5, 24, 12, 51, 43, 97, DateTimeKind.Unspecified).AddTicks(7746), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Policy",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2023, 5, 24, 12, 51, 43, 97, DateTimeKind.Unspecified).AddTicks(7746), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Policy",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2023, 5, 24, 12, 51, 43, 97, DateTimeKind.Unspecified).AddTicks(7746), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "PolicyRole",
                keyColumns: new[] { "PolicyId", "RoleId" },
                keyValues: new object[] { 1, 1 },
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2023, 5, 24, 12, 51, 43, 98, DateTimeKind.Unspecified).AddTicks(2565), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "PolicyRole",
                keyColumns: new[] { "PolicyId", "RoleId" },
                keyValues: new object[] { 2, 1 },
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2023, 5, 24, 12, 51, 43, 98, DateTimeKind.Unspecified).AddTicks(2565), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "PolicyRole",
                keyColumns: new[] { "PolicyId", "RoleId" },
                keyValues: new object[] { 2, 2 },
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2023, 5, 24, 12, 51, 43, 98, DateTimeKind.Unspecified).AddTicks(2565), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "PolicyRole",
                keyColumns: new[] { "PolicyId", "RoleId" },
                keyValues: new object[] { 3, 3 },
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2023, 5, 24, 12, 51, 43, 98, DateTimeKind.Unspecified).AddTicks(2565), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Role",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2023, 5, 24, 12, 51, 43, 99, DateTimeKind.Unspecified).AddTicks(7371), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Role",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2023, 5, 24, 12, 51, 43, 99, DateTimeKind.Unspecified).AddTicks(7371), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Role",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2023, 5, 24, 12, 51, 43, 99, DateTimeKind.Unspecified).AddTicks(7371), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2023, 5, 24, 9, 51, 43, 99, DateTimeKind.Unspecified).AddTicks(7625), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2023, 5, 24, 9, 51, 43, 99, DateTimeKind.Unspecified).AddTicks(7625), new TimeSpan(0, 0, 0, 0, 0)));
        }
    }
}
