using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    public partial class SeedInstructorCar2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "InstructorCars",
                keyColumns: new[] { "CarId", "InstructorId" },
                keyValues: new object[] { 3, 2 });

            migrationBuilder.DeleteData(
                table: "InstructorCars",
                keyColumns: new[] { "CarId", "InstructorId" },
                keyValues: new object[] { 4, 2 });

            migrationBuilder.DeleteData(
                table: "InstructorCars",
                keyColumns: new[] { "CarId", "InstructorId" },
                keyValues: new object[] { 5, 2 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 1,
                column: "Year",
                value: new DateTime(2019, 6, 4, 14, 0, 14, 313, DateTimeKind.Local).AddTicks(2398));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 2,
                column: "Year",
                value: new DateTime(2018, 7, 2, 8, 54, 52, 88, DateTimeKind.Local).AddTicks(1079));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 3,
                column: "Year",
                value: new DateTime(2019, 1, 4, 19, 19, 31, 492, DateTimeKind.Local).AddTicks(5672));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 4,
                column: "Year",
                value: new DateTime(2018, 5, 28, 4, 53, 14, 634, DateTimeKind.Local).AddTicks(8635));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 5,
                column: "Year",
                value: new DateTime(2021, 1, 29, 12, 51, 25, 200, DateTimeKind.Local).AddTicks(435));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 6,
                column: "Year",
                value: new DateTime(2020, 3, 30, 23, 33, 15, 857, DateTimeKind.Local).AddTicks(2056));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 7,
                column: "Year",
                value: new DateTime(2018, 12, 6, 10, 43, 34, 976, DateTimeKind.Local).AddTicks(1587));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 8,
                column: "Year",
                value: new DateTime(2021, 2, 27, 20, 43, 46, 102, DateTimeKind.Local).AddTicks(7617));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 9,
                column: "Year",
                value: new DateTime(2020, 12, 17, 1, 24, 3, 71, DateTimeKind.Local).AddTicks(7474));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 10,
                column: "Year",
                value: new DateTime(2021, 3, 12, 10, 32, 43, 257, DateTimeKind.Local).AddTicks(7612));

            migrationBuilder.UpdateData(
                table: "InstructorCars",
                keyColumns: new[] { "CarId", "InstructorId" },
                keyValues: new object[] { 1, 1 },
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2023, 5, 24, 16, 17, 33, 68, DateTimeKind.Unspecified).AddTicks(7787), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "InstructorCars",
                keyColumns: new[] { "CarId", "InstructorId" },
                keyValues: new object[] { 2, 1 },
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2023, 5, 24, 16, 17, 33, 68, DateTimeKind.Unspecified).AddTicks(7787), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "InstructorCars",
                keyColumns: new[] { "CarId", "InstructorId" },
                keyValues: new object[] { 1, 2 },
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2023, 5, 24, 16, 17, 33, 68, DateTimeKind.Unspecified).AddTicks(7787), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.InsertData(
                table: "InstructorCars",
                columns: new[] { "CarId", "InstructorId", "CreatedAt", "CreatedBy", "Id", "LastModifiedAt", "LastModifiedBy" },
                values: new object[,]
                {
                    { 3, 3, new DateTimeOffset(new DateTime(2023, 5, 24, 16, 17, 33, 68, DateTimeKind.Unspecified).AddTicks(7787), new TimeSpan(0, 3, 0, 0, 0)), "System Migration", 4, null, null },
                    { 4, 4, new DateTimeOffset(new DateTime(2023, 5, 24, 16, 17, 33, 68, DateTimeKind.Unspecified).AddTicks(7787), new TimeSpan(0, 3, 0, 0, 0)), "System Migration", 5, null, null },
                    { 5, 5, new DateTimeOffset(new DateTime(2023, 5, 24, 16, 17, 33, 68, DateTimeKind.Unspecified).AddTicks(7787), new TimeSpan(0, 3, 0, 0, 0)), "System Migration", 6, null, null }
                });

            migrationBuilder.UpdateData(
                table: "Instructors",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2023, 5, 24, 13, 17, 33, 68, DateTimeKind.Unspecified).AddTicks(8686), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Instructors",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2023, 5, 24, 13, 17, 33, 68, DateTimeKind.Unspecified).AddTicks(8686), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Instructors",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2023, 5, 24, 13, 17, 33, 68, DateTimeKind.Unspecified).AddTicks(8686), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Instructors",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2023, 5, 24, 13, 17, 33, 68, DateTimeKind.Unspecified).AddTicks(8686), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Instructors",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2023, 5, 24, 13, 17, 33, 68, DateTimeKind.Unspecified).AddTicks(8686), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2023, 5, 24, 13, 17, 33, 70, DateTimeKind.Unspecified).AddTicks(6562), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2023, 5, 24, 13, 17, 33, 70, DateTimeKind.Unspecified).AddTicks(6562), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2023, 5, 24, 13, 17, 33, 70, DateTimeKind.Unspecified).AddTicks(6562), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Policy",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2023, 5, 24, 16, 17, 33, 70, DateTimeKind.Unspecified).AddTicks(8358), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Policy",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2023, 5, 24, 16, 17, 33, 70, DateTimeKind.Unspecified).AddTicks(8358), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Policy",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2023, 5, 24, 16, 17, 33, 70, DateTimeKind.Unspecified).AddTicks(8358), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "PolicyRole",
                keyColumns: new[] { "PolicyId", "RoleId" },
                keyValues: new object[] { 1, 1 },
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2023, 5, 24, 16, 17, 33, 71, DateTimeKind.Unspecified).AddTicks(5548), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "PolicyRole",
                keyColumns: new[] { "PolicyId", "RoleId" },
                keyValues: new object[] { 2, 1 },
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2023, 5, 24, 16, 17, 33, 71, DateTimeKind.Unspecified).AddTicks(5548), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "PolicyRole",
                keyColumns: new[] { "PolicyId", "RoleId" },
                keyValues: new object[] { 2, 2 },
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2023, 5, 24, 16, 17, 33, 71, DateTimeKind.Unspecified).AddTicks(5548), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "PolicyRole",
                keyColumns: new[] { "PolicyId", "RoleId" },
                keyValues: new object[] { 3, 3 },
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2023, 5, 24, 16, 17, 33, 71, DateTimeKind.Unspecified).AddTicks(5548), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Role",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2023, 5, 24, 16, 17, 33, 73, DateTimeKind.Unspecified).AddTicks(7216), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Role",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2023, 5, 24, 16, 17, 33, 73, DateTimeKind.Unspecified).AddTicks(7216), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Role",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2023, 5, 24, 16, 17, 33, 73, DateTimeKind.Unspecified).AddTicks(7216), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2023, 5, 24, 13, 17, 33, 73, DateTimeKind.Unspecified).AddTicks(7667), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2023, 5, 24, 13, 17, 33, 73, DateTimeKind.Unspecified).AddTicks(7667), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 16,
                column: "Birthday",
                value: new DateTime(1980, 4, 18, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 29,
                column: "Birthday",
                value: new DateTime(1983, 5, 23, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "InstructorCars",
                keyColumns: new[] { "CarId", "InstructorId" },
                keyValues: new object[] { 3, 3 });

            migrationBuilder.DeleteData(
                table: "InstructorCars",
                keyColumns: new[] { "CarId", "InstructorId" },
                keyValues: new object[] { 4, 4 });

            migrationBuilder.DeleteData(
                table: "InstructorCars",
                keyColumns: new[] { "CarId", "InstructorId" },
                keyValues: new object[] { 5, 5 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 1,
                column: "Year",
                value: new DateTime(2019, 6, 4, 13, 40, 10, 585, DateTimeKind.Local).AddTicks(3280));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 2,
                column: "Year",
                value: new DateTime(2018, 7, 2, 8, 34, 48, 360, DateTimeKind.Local).AddTicks(1766));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 3,
                column: "Year",
                value: new DateTime(2019, 1, 4, 18, 59, 27, 764, DateTimeKind.Local).AddTicks(6342));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 4,
                column: "Year",
                value: new DateTime(2018, 5, 28, 4, 33, 10, 906, DateTimeKind.Local).AddTicks(9295));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 5,
                column: "Year",
                value: new DateTime(2021, 1, 29, 12, 31, 21, 472, DateTimeKind.Local).AddTicks(1086));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 6,
                column: "Year",
                value: new DateTime(2020, 3, 30, 23, 13, 12, 129, DateTimeKind.Local).AddTicks(2695));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 7,
                column: "Year",
                value: new DateTime(2018, 12, 6, 10, 23, 31, 248, DateTimeKind.Local).AddTicks(2166));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 8,
                column: "Year",
                value: new DateTime(2021, 2, 27, 20, 23, 42, 374, DateTimeKind.Local).AddTicks(8181));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 9,
                column: "Year",
                value: new DateTime(2020, 12, 17, 1, 3, 59, 343, DateTimeKind.Local).AddTicks(8068));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 10,
                column: "Year",
                value: new DateTime(2021, 3, 12, 10, 12, 39, 529, DateTimeKind.Local).AddTicks(8195));

            migrationBuilder.UpdateData(
                table: "InstructorCars",
                keyColumns: new[] { "CarId", "InstructorId" },
                keyValues: new object[] { 1, 1 },
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2023, 5, 24, 15, 57, 29, 337, DateTimeKind.Unspecified).AddTicks(224), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "InstructorCars",
                keyColumns: new[] { "CarId", "InstructorId" },
                keyValues: new object[] { 2, 1 },
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2023, 5, 24, 15, 57, 29, 337, DateTimeKind.Unspecified).AddTicks(224), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "InstructorCars",
                keyColumns: new[] { "CarId", "InstructorId" },
                keyValues: new object[] { 1, 2 },
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2023, 5, 24, 15, 57, 29, 337, DateTimeKind.Unspecified).AddTicks(224), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.InsertData(
                table: "InstructorCars",
                columns: new[] { "CarId", "InstructorId", "CreatedAt", "CreatedBy", "Id", "LastModifiedAt", "LastModifiedBy" },
                values: new object[,]
                {
                    { 3, 2, new DateTimeOffset(new DateTime(2023, 5, 24, 15, 57, 29, 337, DateTimeKind.Unspecified).AddTicks(224), new TimeSpan(0, 3, 0, 0, 0)), "System Migration", 4, null, null },
                    { 4, 2, new DateTimeOffset(new DateTime(2023, 5, 24, 15, 57, 29, 337, DateTimeKind.Unspecified).AddTicks(224), new TimeSpan(0, 3, 0, 0, 0)), "System Migration", 5, null, null },
                    { 5, 2, new DateTimeOffset(new DateTime(2023, 5, 24, 15, 57, 29, 337, DateTimeKind.Unspecified).AddTicks(224), new TimeSpan(0, 3, 0, 0, 0)), "System Migration", 6, null, null }
                });

            migrationBuilder.UpdateData(
                table: "Instructors",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2023, 5, 24, 12, 57, 29, 337, DateTimeKind.Unspecified).AddTicks(953), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Instructors",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2023, 5, 24, 12, 57, 29, 337, DateTimeKind.Unspecified).AddTicks(953), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Instructors",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2023, 5, 24, 12, 57, 29, 337, DateTimeKind.Unspecified).AddTicks(953), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Instructors",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2023, 5, 24, 12, 57, 29, 337, DateTimeKind.Unspecified).AddTicks(953), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Instructors",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2023, 5, 24, 12, 57, 29, 337, DateTimeKind.Unspecified).AddTicks(953), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2023, 5, 24, 12, 57, 29, 338, DateTimeKind.Unspecified).AddTicks(7214), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2023, 5, 24, 12, 57, 29, 338, DateTimeKind.Unspecified).AddTicks(7214), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2023, 5, 24, 12, 57, 29, 338, DateTimeKind.Unspecified).AddTicks(7214), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Policy",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2023, 5, 24, 15, 57, 29, 338, DateTimeKind.Unspecified).AddTicks(8704), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Policy",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2023, 5, 24, 15, 57, 29, 338, DateTimeKind.Unspecified).AddTicks(8704), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Policy",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2023, 5, 24, 15, 57, 29, 338, DateTimeKind.Unspecified).AddTicks(8704), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "PolicyRole",
                keyColumns: new[] { "PolicyId", "RoleId" },
                keyValues: new object[] { 1, 1 },
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2023, 5, 24, 15, 57, 29, 339, DateTimeKind.Unspecified).AddTicks(3394), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "PolicyRole",
                keyColumns: new[] { "PolicyId", "RoleId" },
                keyValues: new object[] { 2, 1 },
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2023, 5, 24, 15, 57, 29, 339, DateTimeKind.Unspecified).AddTicks(3394), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "PolicyRole",
                keyColumns: new[] { "PolicyId", "RoleId" },
                keyValues: new object[] { 2, 2 },
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2023, 5, 24, 15, 57, 29, 339, DateTimeKind.Unspecified).AddTicks(3394), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "PolicyRole",
                keyColumns: new[] { "PolicyId", "RoleId" },
                keyValues: new object[] { 3, 3 },
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2023, 5, 24, 15, 57, 29, 339, DateTimeKind.Unspecified).AddTicks(3394), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Role",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2023, 5, 24, 15, 57, 29, 340, DateTimeKind.Unspecified).AddTicks(6254), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Role",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2023, 5, 24, 15, 57, 29, 340, DateTimeKind.Unspecified).AddTicks(6254), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Role",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2023, 5, 24, 15, 57, 29, 340, DateTimeKind.Unspecified).AddTicks(6254), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2023, 5, 24, 12, 57, 29, 340, DateTimeKind.Unspecified).AddTicks(6509), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2023, 5, 24, 12, 57, 29, 340, DateTimeKind.Unspecified).AddTicks(6509), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 16,
                column: "Birthday",
                value: new DateTime(1980, 4, 17, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 29,
                column: "Birthday",
                value: new DateTime(1983, 5, 22, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }
    }
}
