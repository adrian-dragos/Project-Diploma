using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    public partial class Add_Timestamp_To_Payment : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "Timestamp",
                table: "Payments",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: 1,
                column: "Year",
                value: new DateTime(2019, 4, 4, 5, 13, 8, 283, DateTimeKind.Local).AddTicks(9201));

            migrationBuilder.UpdateData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: 2,
                column: "Year",
                value: new DateTime(2019, 12, 24, 13, 26, 5, 931, DateTimeKind.Local).AddTicks(1517));

            migrationBuilder.UpdateData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: 3,
                column: "Year",
                value: new DateTime(2020, 12, 27, 7, 6, 17, 180, DateTimeKind.Local).AddTicks(4407));

            migrationBuilder.UpdateData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: 4,
                column: "Year",
                value: new DateTime(2019, 11, 3, 8, 27, 51, 149, DateTimeKind.Local).AddTicks(1521));

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 1,
                column: "Timestamp",
                value: new DateTimeOffset(new DateTime(2023, 6, 1, 18, 9, 43, 880, DateTimeKind.Unspecified).AddTicks(7923), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 2,
                column: "Timestamp",
                value: new DateTimeOffset(new DateTime(2023, 6, 1, 18, 9, 43, 880, DateTimeKind.Unspecified).AddTicks(7923), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 3,
                column: "Timestamp",
                value: new DateTimeOffset(new DateTime(2023, 6, 1, 18, 9, 43, 880, DateTimeKind.Unspecified).AddTicks(7923), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 4,
                column: "Timestamp",
                value: new DateTimeOffset(new DateTime(2023, 6, 1, 18, 9, 43, 880, DateTimeKind.Unspecified).AddTicks(7923), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 5,
                column: "Timestamp",
                value: new DateTimeOffset(new DateTime(2023, 6, 1, 18, 9, 43, 880, DateTimeKind.Unspecified).AddTicks(7923), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 6,
                column: "Timestamp",
                value: new DateTimeOffset(new DateTime(2023, 6, 1, 18, 9, 43, 880, DateTimeKind.Unspecified).AddTicks(7923), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 7,
                column: "Timestamp",
                value: new DateTimeOffset(new DateTime(2023, 6, 8, 9, 31, 43, 880, DateTimeKind.Unspecified).AddTicks(7923), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 8,
                column: "Timestamp",
                value: new DateTimeOffset(new DateTime(2023, 6, 8, 9, 31, 43, 880, DateTimeKind.Unspecified).AddTicks(7923), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 9,
                column: "Timestamp",
                value: new DateTimeOffset(new DateTime(2023, 6, 8, 9, 31, 43, 880, DateTimeKind.Unspecified).AddTicks(7923), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 10,
                column: "Timestamp",
                value: new DateTimeOffset(new DateTime(2023, 6, 8, 9, 31, 43, 880, DateTimeKind.Unspecified).AddTicks(7923), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 11,
                column: "Timestamp",
                value: new DateTimeOffset(new DateTime(2023, 6, 8, 9, 31, 43, 880, DateTimeKind.Unspecified).AddTicks(7923), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 12,
                column: "Timestamp",
                value: new DateTimeOffset(new DateTime(2023, 6, 8, 9, 31, 43, 880, DateTimeKind.Unspecified).AddTicks(7923), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 13,
                column: "Timestamp",
                value: new DateTimeOffset(new DateTime(2023, 6, 8, 9, 31, 43, 880, DateTimeKind.Unspecified).AddTicks(7923), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 14,
                column: "Timestamp",
                value: new DateTimeOffset(new DateTime(2023, 6, 15, 10, 16, 43, 880, DateTimeKind.Unspecified).AddTicks(7923), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 15,
                column: "Timestamp",
                value: new DateTimeOffset(new DateTime(2023, 6, 15, 10, 16, 43, 880, DateTimeKind.Unspecified).AddTicks(7923), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 16,
                column: "Timestamp",
                value: new DateTimeOffset(new DateTime(2023, 6, 15, 10, 16, 43, 880, DateTimeKind.Unspecified).AddTicks(7923), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 17,
                column: "Timestamp",
                value: new DateTimeOffset(new DateTime(2023, 6, 15, 10, 16, 43, 880, DateTimeKind.Unspecified).AddTicks(7923), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 18,
                column: "Timestamp",
                value: new DateTimeOffset(new DateTime(2023, 6, 15, 10, 16, 43, 880, DateTimeKind.Unspecified).AddTicks(7923), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 19,
                column: "Timestamp",
                value: new DateTimeOffset(new DateTime(2023, 6, 15, 10, 16, 43, 880, DateTimeKind.Unspecified).AddTicks(7923), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 20,
                column: "Timestamp",
                value: new DateTimeOffset(new DateTime(2023, 6, 15, 10, 16, 43, 880, DateTimeKind.Unspecified).AddTicks(7923), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 21,
                column: "Timestamp",
                value: new DateTimeOffset(new DateTime(2023, 6, 22, 18, 31, 43, 880, DateTimeKind.Unspecified).AddTicks(7923), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 22,
                column: "Timestamp",
                value: new DateTimeOffset(new DateTime(2023, 6, 22, 18, 31, 43, 880, DateTimeKind.Unspecified).AddTicks(7923), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 23,
                column: "Timestamp",
                value: new DateTimeOffset(new DateTime(2023, 6, 22, 18, 31, 43, 880, DateTimeKind.Unspecified).AddTicks(7923), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 24,
                column: "Timestamp",
                value: new DateTimeOffset(new DateTime(2023, 6, 22, 18, 31, 43, 880, DateTimeKind.Unspecified).AddTicks(7923), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 25,
                column: "Timestamp",
                value: new DateTimeOffset(new DateTime(2023, 6, 22, 18, 31, 43, 880, DateTimeKind.Unspecified).AddTicks(7923), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 26,
                column: "Timestamp",
                value: new DateTimeOffset(new DateTime(2023, 6, 22, 18, 31, 43, 880, DateTimeKind.Unspecified).AddTicks(7923), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 27,
                column: "Timestamp",
                value: new DateTimeOffset(new DateTime(2023, 6, 22, 18, 31, 43, 880, DateTimeKind.Unspecified).AddTicks(7923), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 28,
                column: "Timestamp",
                value: new DateTimeOffset(new DateTime(2023, 6, 29, 10, 45, 43, 880, DateTimeKind.Unspecified).AddTicks(7923), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 29,
                column: "Timestamp",
                value: new DateTimeOffset(new DateTime(2023, 6, 29, 10, 45, 43, 880, DateTimeKind.Unspecified).AddTicks(7923), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 30,
                column: "Timestamp",
                value: new DateTimeOffset(new DateTime(2023, 6, 29, 10, 45, 43, 880, DateTimeKind.Unspecified).AddTicks(7923), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 31,
                column: "Timestamp",
                value: new DateTimeOffset(new DateTime(2023, 6, 29, 10, 45, 43, 880, DateTimeKind.Unspecified).AddTicks(7923), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 32,
                column: "Timestamp",
                value: new DateTimeOffset(new DateTime(2023, 6, 29, 10, 45, 43, 880, DateTimeKind.Unspecified).AddTicks(7923), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 33,
                column: "Timestamp",
                value: new DateTimeOffset(new DateTime(2023, 6, 29, 10, 45, 43, 880, DateTimeKind.Unspecified).AddTicks(7923), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 34,
                column: "Timestamp",
                value: new DateTimeOffset(new DateTime(2023, 6, 29, 10, 45, 43, 880, DateTimeKind.Unspecified).AddTicks(7923), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 35,
                column: "Timestamp",
                value: new DateTimeOffset(new DateTime(2023, 6, 29, 10, 45, 43, 880, DateTimeKind.Unspecified).AddTicks(7923), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 36,
                column: "Timestamp",
                value: new DateTimeOffset(new DateTime(2023, 6, 29, 10, 45, 43, 880, DateTimeKind.Unspecified).AddTicks(7923), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 37,
                column: "Timestamp",
                value: new DateTimeOffset(new DateTime(2023, 6, 29, 10, 45, 43, 880, DateTimeKind.Unspecified).AddTicks(7923), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 38,
                column: "Timestamp",
                value: new DateTimeOffset(new DateTime(2023, 6, 29, 10, 45, 43, 880, DateTimeKind.Unspecified).AddTicks(7923), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 39,
                column: "Timestamp",
                value: new DateTimeOffset(new DateTime(2023, 6, 29, 10, 45, 43, 880, DateTimeKind.Unspecified).AddTicks(7923), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 40,
                column: "Timestamp",
                value: new DateTimeOffset(new DateTime(2023, 6, 29, 10, 45, 43, 880, DateTimeKind.Unspecified).AddTicks(7923), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 41,
                column: "Timestamp",
                value: new DateTimeOffset(new DateTime(2023, 6, 29, 10, 45, 43, 880, DateTimeKind.Unspecified).AddTicks(7923), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 42,
                column: "Timestamp",
                value: new DateTimeOffset(new DateTime(2023, 6, 29, 10, 45, 43, 880, DateTimeKind.Unspecified).AddTicks(7923), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 43,
                column: "Timestamp",
                value: new DateTimeOffset(new DateTime(2023, 6, 29, 10, 45, 43, 880, DateTimeKind.Unspecified).AddTicks(7923), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 44,
                column: "Timestamp",
                value: new DateTimeOffset(new DateTime(2023, 6, 29, 10, 45, 43, 880, DateTimeKind.Unspecified).AddTicks(7923), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 45,
                column: "Timestamp",
                value: new DateTimeOffset(new DateTime(2023, 6, 29, 10, 45, 43, 880, DateTimeKind.Unspecified).AddTicks(7923), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 46,
                column: "Timestamp",
                value: new DateTimeOffset(new DateTime(2023, 6, 29, 10, 45, 43, 880, DateTimeKind.Unspecified).AddTicks(7923), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 47,
                column: "Timestamp",
                value: new DateTimeOffset(new DateTime(2023, 6, 29, 10, 45, 43, 880, DateTimeKind.Unspecified).AddTicks(7923), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 48,
                column: "Timestamp",
                value: new DateTimeOffset(new DateTime(2023, 6, 29, 10, 45, 43, 880, DateTimeKind.Unspecified).AddTicks(7923), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 49,
                column: "Timestamp",
                value: new DateTimeOffset(new DateTime(2023, 6, 29, 10, 45, 43, 880, DateTimeKind.Unspecified).AddTicks(7923), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 50,
                column: "Timestamp",
                value: new DateTimeOffset(new DateTime(2023, 6, 29, 10, 45, 43, 880, DateTimeKind.Unspecified).AddTicks(7923), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Policy",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2023, 6, 3, 21, 59, 47, 176, DateTimeKind.Unspecified).AddTicks(2749), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Policy",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2023, 6, 3, 21, 59, 47, 176, DateTimeKind.Unspecified).AddTicks(2749), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Policy",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2023, 6, 3, 21, 59, 47, 176, DateTimeKind.Unspecified).AddTicks(2749), new TimeSpan(0, 3, 0, 0, 0)));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Timestamp",
                table: "Payments");

            migrationBuilder.UpdateData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: 1,
                column: "Year",
                value: new DateTime(2019, 4, 4, 4, 50, 24, 574, DateTimeKind.Local).AddTicks(8091));

            migrationBuilder.UpdateData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: 2,
                column: "Year",
                value: new DateTime(2019, 12, 24, 13, 3, 22, 222, DateTimeKind.Local).AddTicks(563));

            migrationBuilder.UpdateData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: 3,
                column: "Year",
                value: new DateTime(2020, 12, 27, 6, 43, 33, 471, DateTimeKind.Local).AddTicks(3467));

            migrationBuilder.UpdateData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: 4,
                column: "Year",
                value: new DateTime(2019, 11, 3, 8, 5, 7, 440, DateTimeKind.Local).AddTicks(595));

            migrationBuilder.UpdateData(
                table: "Policy",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2023, 6, 3, 21, 37, 3, 466, DateTimeKind.Unspecified).AddTicks(7245), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Policy",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2023, 6, 3, 21, 37, 3, 466, DateTimeKind.Unspecified).AddTicks(7245), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Policy",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2023, 6, 3, 21, 37, 3, 466, DateTimeKind.Unspecified).AddTicks(7245), new TimeSpan(0, 3, 0, 0, 0)));
        }
    }
}
