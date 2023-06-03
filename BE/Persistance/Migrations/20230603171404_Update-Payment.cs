using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    public partial class UpdatePayment : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: 1,
                column: "Year",
                value: new DateTime(2019, 4, 4, 3, 27, 21, 825, DateTimeKind.Local).AddTicks(7546));

            migrationBuilder.UpdateData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: 2,
                column: "Year",
                value: new DateTime(2019, 12, 24, 11, 40, 19, 472, DateTimeKind.Local).AddTicks(9892));

            migrationBuilder.UpdateData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: 3,
                column: "Year",
                value: new DateTime(2020, 12, 27, 5, 20, 30, 722, DateTimeKind.Local).AddTicks(2780));

            migrationBuilder.UpdateData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: 4,
                column: "Year",
                value: new DateTime(2019, 11, 3, 6, 42, 4, 690, DateTimeKind.Local).AddTicks(9891));

            migrationBuilder.UpdateData(
                table: "Policy",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2023, 6, 3, 20, 14, 0, 717, DateTimeKind.Unspecified).AddTicks(6433), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Policy",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2023, 6, 3, 20, 14, 0, 717, DateTimeKind.Unspecified).AddTicks(6433), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Policy",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2023, 6, 3, 20, 14, 0, 717, DateTimeKind.Unspecified).AddTicks(6433), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10,
                column: "Birthday",
                value: new DateTime(1986, 11, 5, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 13,
                column: "Birthday",
                value: new DateTime(1974, 1, 7, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 30,
                column: "Birthday",
                value: new DateTime(1995, 7, 9, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 31,
                column: "Birthday",
                value: new DateTime(1973, 6, 5, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 43,
                column: "Birthday",
                value: new DateTime(1977, 1, 28, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10,
                column: "Birthday",
                value: new DateTime(1986, 11, 4, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 13,
                column: "Birthday",
                value: new DateTime(1974, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 30,
                column: "Birthday",
                value: new DateTime(1995, 7, 8, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 31,
                column: "Birthday",
                value: new DateTime(1973, 6, 4, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 43,
                column: "Birthday",
                value: new DateTime(1977, 1, 27, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }
    }
}
