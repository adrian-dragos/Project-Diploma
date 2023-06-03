using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    public partial class Make_StudetId_Nullablle_Payments : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "StudentId",
                table: "Payments",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: 1,
                column: "Year",
                value: new DateTime(2019, 4, 4, 5, 40, 43, 76, DateTimeKind.Local).AddTicks(7993));

            migrationBuilder.UpdateData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: 2,
                column: "Year",
                value: new DateTime(2019, 12, 24, 13, 53, 40, 724, DateTimeKind.Local).AddTicks(330));

            migrationBuilder.UpdateData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: 3,
                column: "Year",
                value: new DateTime(2020, 12, 27, 7, 33, 51, 973, DateTimeKind.Local).AddTicks(3223));

            migrationBuilder.UpdateData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: 4,
                column: "Year",
                value: new DateTime(2019, 11, 3, 8, 55, 25, 942, DateTimeKind.Local).AddTicks(349));

            migrationBuilder.UpdateData(
                table: "Policy",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2023, 6, 3, 22, 27, 21, 968, DateTimeKind.Unspecified).AddTicks(987), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Policy",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2023, 6, 3, 22, 27, 21, 968, DateTimeKind.Unspecified).AddTicks(987), new TimeSpan(0, 3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Policy",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2023, 6, 3, 22, 27, 21, 968, DateTimeKind.Unspecified).AddTicks(987), new TimeSpan(0, 3, 0, 0, 0)));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "StudentId",
                table: "Payments",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

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
    }
}
