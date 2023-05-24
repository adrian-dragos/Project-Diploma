using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    public partial class ChangeSeedingForTestingPurposes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Vin",
                table: "Cars",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

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
                columns: new[] { "CreatedAt", "GearType" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 5, 24, 9, 51, 43, 96, DateTimeKind.Unspecified).AddTicks(2341), new TimeSpan(0, 0, 0, 0, 0)), 2 });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Vin",
                table: "Cars",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 1,
                column: "Year",
                value: new DateTime(2019, 6, 4, 10, 19, 21, 994, DateTimeKind.Local).AddTicks(4686));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 2,
                column: "Year",
                value: new DateTime(2018, 7, 2, 5, 13, 59, 769, DateTimeKind.Local).AddTicks(3115));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 3,
                column: "Year",
                value: new DateTime(2019, 1, 4, 15, 38, 39, 173, DateTimeKind.Local).AddTicks(7900));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 4,
                column: "Year",
                value: new DateTime(2018, 5, 28, 1, 12, 22, 316, DateTimeKind.Local).AddTicks(853));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 5,
                column: "Year",
                value: new DateTime(2021, 1, 29, 9, 10, 32, 881, DateTimeKind.Local).AddTicks(2639));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 6,
                column: "Year",
                value: new DateTime(2020, 3, 30, 19, 52, 23, 538, DateTimeKind.Local).AddTicks(4245));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 7,
                column: "Year",
                value: new DateTime(2018, 12, 6, 7, 2, 42, 657, DateTimeKind.Local).AddTicks(3712));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 8,
                column: "Year",
                value: new DateTime(2021, 2, 27, 17, 2, 53, 783, DateTimeKind.Local).AddTicks(9727));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 9,
                column: "Year",
                value: new DateTime(2020, 12, 16, 21, 43, 10, 752, DateTimeKind.Local).AddTicks(9569));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 10,
                column: "Year",
                value: new DateTime(2021, 3, 12, 6, 51, 50, 938, DateTimeKind.Local).AddTicks(9724));

            migrationBuilder.UpdateData(
                table: "InstructorCars",
                keyColumns: new[] { "CarId", "InstructorId" },
                keyValues: new object[] { 1, 1 },
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2023, 5, 24, 12, 36, 40, 734, DateTimeKind.Unspecified).AddTicks(5427), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "InstructorCars",
                keyColumns: new[] { "CarId", "InstructorId" },
                keyValues: new object[] { 2, 1 },
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2023, 5, 24, 12, 36, 40, 734, DateTimeKind.Unspecified).AddTicks(5427), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "InstructorCars",
                keyColumns: new[] { "CarId", "InstructorId" },
                keyValues: new object[] { 1, 2 },
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2023, 5, 24, 12, 36, 40, 734, DateTimeKind.Unspecified).AddTicks(5427), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Instructors",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2023, 5, 24, 9, 36, 40, 734, DateTimeKind.Unspecified).AddTicks(5821), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Instructors",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "GearType" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 5, 24, 9, 36, 40, 734, DateTimeKind.Unspecified).AddTicks(5821), new TimeSpan(0, 0, 0, 0, 0)), 1 });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2023, 5, 24, 9, 36, 40, 735, DateTimeKind.Unspecified).AddTicks(3725), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2023, 5, 24, 9, 36, 40, 735, DateTimeKind.Unspecified).AddTicks(3725), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2023, 5, 24, 9, 36, 40, 735, DateTimeKind.Unspecified).AddTicks(3725), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Policy",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2023, 5, 24, 12, 36, 40, 735, DateTimeKind.Unspecified).AddTicks(4436), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Policy",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2023, 5, 24, 12, 36, 40, 735, DateTimeKind.Unspecified).AddTicks(4436), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Policy",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2023, 5, 24, 12, 36, 40, 735, DateTimeKind.Unspecified).AddTicks(4436), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "PolicyRole",
                keyColumns: new[] { "PolicyId", "RoleId" },
                keyValues: new object[] { 1, 1 },
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2023, 5, 24, 12, 36, 40, 735, DateTimeKind.Unspecified).AddTicks(6956), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "PolicyRole",
                keyColumns: new[] { "PolicyId", "RoleId" },
                keyValues: new object[] { 2, 1 },
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2023, 5, 24, 12, 36, 40, 735, DateTimeKind.Unspecified).AddTicks(6956), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "PolicyRole",
                keyColumns: new[] { "PolicyId", "RoleId" },
                keyValues: new object[] { 2, 2 },
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2023, 5, 24, 12, 36, 40, 735, DateTimeKind.Unspecified).AddTicks(6956), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "PolicyRole",
                keyColumns: new[] { "PolicyId", "RoleId" },
                keyValues: new object[] { 3, 3 },
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2023, 5, 24, 12, 36, 40, 735, DateTimeKind.Unspecified).AddTicks(6956), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Role",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2023, 5, 24, 12, 36, 40, 736, DateTimeKind.Unspecified).AddTicks(3128), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Role",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2023, 5, 24, 12, 36, 40, 736, DateTimeKind.Unspecified).AddTicks(3128), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Role",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2023, 5, 24, 12, 36, 40, 736, DateTimeKind.Unspecified).AddTicks(3128), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2023, 5, 24, 9, 36, 40, 736, DateTimeKind.Unspecified).AddTicks(3264), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2023, 5, 24, 9, 36, 40, 736, DateTimeKind.Unspecified).AddTicks(3264), new TimeSpan(0, 0, 0, 0, 0)));
        }
    }
}
