using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    public partial class Update_Seeding_1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: 1,
                column: "Year",
                value: new DateTime(2019, 4, 4, 1, 49, 27, 570, DateTimeKind.Local).AddTicks(6654));

            migrationBuilder.UpdateData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: 2,
                column: "Year",
                value: new DateTime(2019, 12, 24, 10, 2, 25, 217, DateTimeKind.Local).AddTicks(9139));

            migrationBuilder.UpdateData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: 3,
                column: "Year",
                value: new DateTime(2020, 12, 27, 3, 42, 36, 467, DateTimeKind.Local).AddTicks(2037));

            migrationBuilder.UpdateData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: 4,
                column: "Year",
                value: new DateTime(2019, 11, 3, 5, 4, 10, 435, DateTimeKind.Local).AddTicks(9158));

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2023, 6, 8, 9, 31, 43, 880, DateTimeKind.Unspecified).AddTicks(7923), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2023, 6, 15, 10, 16, 43, 880, DateTimeKind.Unspecified).AddTicks(7923), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2023, 6, 22, 18, 31, 43, 880, DateTimeKind.Unspecified).AddTicks(7923), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2023, 6, 29, 10, 45, 43, 880, DateTimeKind.Unspecified).AddTicks(7923), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Policy",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2023, 6, 3, 18, 36, 6, 462, DateTimeKind.Unspecified).AddTicks(2371), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Policy",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2023, 6, 3, 18, 36, 6, 462, DateTimeKind.Unspecified).AddTicks(2371), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Policy",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2023, 6, 3, 18, 36, 6, 462, DateTimeKind.Unspecified).AddTicks(2371), new TimeSpan(0, 3, 0, 0, 0)));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: 1,
                column: "Year",
                value: new DateTime(2019, 4, 4, 1, 45, 2, 927, DateTimeKind.Local).AddTicks(4996));

            migrationBuilder.UpdateData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: 2,
                column: "Year",
                value: new DateTime(2019, 12, 24, 9, 58, 0, 574, DateTimeKind.Local).AddTicks(7238));

            migrationBuilder.UpdateData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: 3,
                column: "Year",
                value: new DateTime(2020, 12, 27, 3, 38, 11, 824, DateTimeKind.Local).AddTicks(125));

            migrationBuilder.UpdateData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: 4,
                column: "Year",
                value: new DateTime(2019, 11, 3, 4, 59, 45, 792, DateTimeKind.Local).AddTicks(7238));

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2023, 6, 1, 18, 9, 43, 880, DateTimeKind.Unspecified).AddTicks(7923), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2023, 6, 8, 9, 31, 43, 880, DateTimeKind.Unspecified).AddTicks(7923), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2023, 6, 15, 10, 16, 43, 880, DateTimeKind.Unspecified).AddTicks(7923), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2023, 6, 22, 18, 31, 43, 880, DateTimeKind.Unspecified).AddTicks(7923), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Policy",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2023, 6, 3, 18, 31, 41, 816, DateTimeKind.Unspecified).AddTicks(7872), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Policy",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2023, 6, 3, 18, 31, 41, 816, DateTimeKind.Unspecified).AddTicks(7872), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Policy",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2023, 6, 3, 18, 31, 41, 816, DateTimeKind.Unspecified).AddTicks(7872), new TimeSpan(0, 3, 0, 0, 0)));
        }
    }
}
