using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    public partial class SeedInstructorCar : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
                value: new DateTime(2019, 6, 4, 13, 20, 22, 167, DateTimeKind.Local).AddTicks(9968));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 2,
                column: "Year",
                value: new DateTime(2018, 7, 2, 8, 14, 59, 942, DateTimeKind.Local).AddTicks(8542));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 3,
                column: "Year",
                value: new DateTime(2019, 1, 4, 18, 39, 39, 347, DateTimeKind.Local).AddTicks(3126));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 4,
                column: "Year",
                value: new DateTime(2018, 5, 28, 4, 13, 22, 489, DateTimeKind.Local).AddTicks(6085));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 5,
                column: "Year",
                value: new DateTime(2021, 1, 29, 12, 11, 33, 54, DateTimeKind.Local).AddTicks(7881));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 6,
                column: "Year",
                value: new DateTime(2020, 3, 30, 22, 53, 23, 711, DateTimeKind.Local).AddTicks(9497));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 7,
                column: "Year",
                value: new DateTime(2018, 12, 6, 10, 3, 42, 830, DateTimeKind.Local).AddTicks(8970));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 8,
                column: "Year",
                value: new DateTime(2021, 2, 27, 20, 3, 53, 957, DateTimeKind.Local).AddTicks(4989));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 9,
                column: "Year",
                value: new DateTime(2020, 12, 17, 0, 44, 10, 926, DateTimeKind.Local).AddTicks(4886));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 10,
                column: "Year",
                value: new DateTime(2021, 3, 12, 9, 52, 51, 112, DateTimeKind.Local).AddTicks(5021));

            migrationBuilder.UpdateData(
                table: "InstructorCars",
                keyColumns: new[] { "CarId", "InstructorId" },
                keyValues: new object[] { 1, 1 },
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2023, 5, 24, 15, 37, 40, 918, DateTimeKind.Unspecified).AddTicks(3357), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "InstructorCars",
                keyColumns: new[] { "CarId", "InstructorId" },
                keyValues: new object[] { 2, 1 },
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2023, 5, 24, 15, 37, 40, 918, DateTimeKind.Unspecified).AddTicks(3357), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "InstructorCars",
                keyColumns: new[] { "CarId", "InstructorId" },
                keyValues: new object[] { 1, 2 },
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2023, 5, 24, 15, 37, 40, 918, DateTimeKind.Unspecified).AddTicks(3357), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Instructors",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2023, 5, 24, 12, 37, 40, 918, DateTimeKind.Unspecified).AddTicks(3841), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Instructors",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2023, 5, 24, 12, 37, 40, 918, DateTimeKind.Unspecified).AddTicks(3841), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Instructors",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2023, 5, 24, 12, 37, 40, 918, DateTimeKind.Unspecified).AddTicks(3841), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Instructors",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2023, 5, 24, 12, 37, 40, 918, DateTimeKind.Unspecified).AddTicks(3841), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Instructors",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2023, 5, 24, 12, 37, 40, 918, DateTimeKind.Unspecified).AddTicks(3841), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2023, 5, 24, 12, 37, 40, 919, DateTimeKind.Unspecified).AddTicks(4253), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2023, 5, 24, 12, 37, 40, 919, DateTimeKind.Unspecified).AddTicks(4253), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2023, 5, 24, 12, 37, 40, 919, DateTimeKind.Unspecified).AddTicks(4253), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Policy",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2023, 5, 24, 15, 37, 40, 919, DateTimeKind.Unspecified).AddTicks(5202), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Policy",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2023, 5, 24, 15, 37, 40, 919, DateTimeKind.Unspecified).AddTicks(5202), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Policy",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2023, 5, 24, 15, 37, 40, 919, DateTimeKind.Unspecified).AddTicks(5202), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "PolicyRole",
                keyColumns: new[] { "PolicyId", "RoleId" },
                keyValues: new object[] { 1, 1 },
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2023, 5, 24, 15, 37, 40, 919, DateTimeKind.Unspecified).AddTicks(8652), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "PolicyRole",
                keyColumns: new[] { "PolicyId", "RoleId" },
                keyValues: new object[] { 2, 1 },
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2023, 5, 24, 15, 37, 40, 919, DateTimeKind.Unspecified).AddTicks(8652), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "PolicyRole",
                keyColumns: new[] { "PolicyId", "RoleId" },
                keyValues: new object[] { 2, 2 },
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2023, 5, 24, 15, 37, 40, 919, DateTimeKind.Unspecified).AddTicks(8652), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "PolicyRole",
                keyColumns: new[] { "PolicyId", "RoleId" },
                keyValues: new object[] { 3, 3 },
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2023, 5, 24, 15, 37, 40, 919, DateTimeKind.Unspecified).AddTicks(8652), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Role",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2023, 5, 24, 15, 37, 40, 920, DateTimeKind.Unspecified).AddTicks(7893), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Role",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2023, 5, 24, 15, 37, 40, 920, DateTimeKind.Unspecified).AddTicks(7893), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Role",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2023, 5, 24, 15, 37, 40, 920, DateTimeKind.Unspecified).AddTicks(7893), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2023, 5, 24, 12, 37, 40, 920, DateTimeKind.Unspecified).AddTicks(8081), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2023, 5, 24, 12, 37, 40, 920, DateTimeKind.Unspecified).AddTicks(8081), new TimeSpan(0, 0, 0, 0, 0)));
        }
    }
}
