using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    public partial class SeedMoreInstructorsInDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                columns: new[] { "CreatedAt", "IdentityId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 5, 24, 12, 37, 40, 918, DateTimeKind.Unspecified).AddTicks(3841), new TimeSpan(0, 0, 0, 0, 0)), 1 });

            migrationBuilder.UpdateData(
                table: "Instructors",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2023, 5, 24, 12, 37, 40, 918, DateTimeKind.Unspecified).AddTicks(3841), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.InsertData(
                table: "Instructors",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "GearType", "IdentityId", "LastModifiedAt", "LastModifiedBy", "Location" },
                values: new object[,]
                {
                    { 3, new DateTimeOffset(new DateTime(2023, 5, 24, 12, 37, 40, 918, DateTimeKind.Unspecified).AddTicks(3841), new TimeSpan(0, 0, 0, 0, 0)), "System Seeding", 2, 19, null, null, "Strada Crișul 7" },
                    { 4, new DateTimeOffset(new DateTime(2023, 5, 24, 12, 37, 40, 918, DateTimeKind.Unspecified).AddTicks(3841), new TimeSpan(0, 0, 0, 0, 0)), "System Seeding", 1, 23, null, null, "Strada Crișul 7" },
                    { 5, new DateTimeOffset(new DateTime(2023, 5, 24, 12, 37, 40, 918, DateTimeKind.Unspecified).AddTicks(3841), new TimeSpan(0, 0, 0, 0, 0)), "System Seeding", 1, 24, null, null, "Strada Crișul 7" }
                });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Instructors",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Instructors",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Instructors",
                keyColumn: "Id",
                keyValue: 5);

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
                columns: new[] { "CreatedAt", "IdentityId" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 5, 24, 12, 29, 2, 291, DateTimeKind.Unspecified).AddTicks(4688), new TimeSpan(0, 0, 0, 0, 0)), 4 });

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
        }
    }
}
