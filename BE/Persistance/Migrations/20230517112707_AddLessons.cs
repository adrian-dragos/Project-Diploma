using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistance.Migrations
{
    public partial class AddLessons : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Instructors",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2023, 5, 17, 11, 27, 6, 994, DateTimeKind.Unspecified).AddTicks(9725), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Instructors",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2023, 5, 17, 11, 27, 6, 994, DateTimeKind.Unspecified).AddTicks(9725), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2023, 5, 17, 11, 27, 6, 995, DateTimeKind.Unspecified).AddTicks(1407), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.InsertData(
                table: "Lessons",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "InstructorId", "LastModifiedAt", "LastModifiedBy", "LessonStatus", "StartTime", "StudentId" },
                values: new object[,]
                {
                    { 2, new DateTimeOffset(new DateTime(2023, 5, 17, 11, 27, 6, 995, DateTimeKind.Unspecified).AddTicks(1407), new TimeSpan(0, 0, 0, 0, 0)), "System Seeding", 2, null, null, 0, new DateTimeOffset(new DateTime(2023, 7, 25, 10, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 1 },
                    { 3, new DateTimeOffset(new DateTime(2023, 5, 17, 11, 27, 6, 995, DateTimeKind.Unspecified).AddTicks(1407), new TimeSpan(0, 0, 0, 0, 0)), "System Seeding", 1, null, null, 0, new DateTimeOffset(new DateTime(2023, 7, 25, 10, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 2 }
                });

            migrationBuilder.UpdateData(
                table: "Policy",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2023, 5, 17, 14, 27, 6, 995, DateTimeKind.Unspecified).AddTicks(1939), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Policy",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2023, 5, 17, 14, 27, 6, 995, DateTimeKind.Unspecified).AddTicks(1939), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Policy",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2023, 5, 17, 14, 27, 6, 995, DateTimeKind.Unspecified).AddTicks(1939), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "PolicyRole",
                keyColumns: new[] { "PolicyId", "RoleId" },
                keyValues: new object[] { 1, 1 },
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2023, 5, 17, 14, 27, 6, 995, DateTimeKind.Unspecified).AddTicks(4495), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "PolicyRole",
                keyColumns: new[] { "PolicyId", "RoleId" },
                keyValues: new object[] { 2, 1 },
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2023, 5, 17, 14, 27, 6, 995, DateTimeKind.Unspecified).AddTicks(4495), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "PolicyRole",
                keyColumns: new[] { "PolicyId", "RoleId" },
                keyValues: new object[] { 2, 2 },
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2023, 5, 17, 14, 27, 6, 995, DateTimeKind.Unspecified).AddTicks(4495), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "PolicyRole",
                keyColumns: new[] { "PolicyId", "RoleId" },
                keyValues: new object[] { 3, 3 },
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2023, 5, 17, 14, 27, 6, 995, DateTimeKind.Unspecified).AddTicks(4495), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Role",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2023, 5, 17, 14, 27, 6, 995, DateTimeKind.Unspecified).AddTicks(4982), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Role",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2023, 5, 17, 14, 27, 6, 995, DateTimeKind.Unspecified).AddTicks(4982), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Role",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2023, 5, 17, 14, 27, 6, 995, DateTimeKind.Unspecified).AddTicks(4982), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2023, 5, 17, 11, 27, 6, 995, DateTimeKind.Unspecified).AddTicks(5101), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2023, 5, 17, 11, 27, 6, 995, DateTimeKind.Unspecified).AddTicks(5101), new TimeSpan(0, 0, 0, 0, 0)));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.UpdateData(
                table: "Instructors",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2023, 5, 9, 16, 13, 16, 197, DateTimeKind.Unspecified).AddTicks(7957), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Instructors",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2023, 5, 9, 16, 13, 16, 197, DateTimeKind.Unspecified).AddTicks(7957), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2023, 5, 9, 16, 13, 16, 197, DateTimeKind.Unspecified).AddTicks(9740), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Policy",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2023, 5, 9, 19, 13, 16, 198, DateTimeKind.Unspecified).AddTicks(383), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Policy",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2023, 5, 9, 19, 13, 16, 198, DateTimeKind.Unspecified).AddTicks(383), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Policy",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2023, 5, 9, 19, 13, 16, 198, DateTimeKind.Unspecified).AddTicks(383), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "PolicyRole",
                keyColumns: new[] { "PolicyId", "RoleId" },
                keyValues: new object[] { 1, 1 },
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2023, 5, 9, 19, 13, 16, 198, DateTimeKind.Unspecified).AddTicks(3455), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "PolicyRole",
                keyColumns: new[] { "PolicyId", "RoleId" },
                keyValues: new object[] { 2, 1 },
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2023, 5, 9, 19, 13, 16, 198, DateTimeKind.Unspecified).AddTicks(3455), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "PolicyRole",
                keyColumns: new[] { "PolicyId", "RoleId" },
                keyValues: new object[] { 2, 2 },
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2023, 5, 9, 19, 13, 16, 198, DateTimeKind.Unspecified).AddTicks(3455), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "PolicyRole",
                keyColumns: new[] { "PolicyId", "RoleId" },
                keyValues: new object[] { 3, 3 },
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2023, 5, 9, 19, 13, 16, 198, DateTimeKind.Unspecified).AddTicks(3455), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Role",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2023, 5, 9, 19, 13, 16, 198, DateTimeKind.Unspecified).AddTicks(4073), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Role",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2023, 5, 9, 19, 13, 16, 198, DateTimeKind.Unspecified).AddTicks(4073), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Role",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2023, 5, 9, 19, 13, 16, 198, DateTimeKind.Unspecified).AddTicks(4073), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2023, 5, 9, 16, 13, 16, 198, DateTimeKind.Unspecified).AddTicks(4299), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2023, 5, 9, 16, 13, 16, 198, DateTimeKind.Unspecified).AddTicks(4299), new TimeSpan(0, 0, 0, 0, 0)));
        }
    }
}
