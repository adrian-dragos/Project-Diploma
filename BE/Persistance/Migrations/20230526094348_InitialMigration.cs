using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CarModels",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Manufacturer = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Model = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Year = table.Column<DateTime>(type: "datetime2", maxLength: 50, nullable: false),
                    Color = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CarGear = table.Column<int>(type: "int", maxLength: 50, nullable: false),
                    CreatedAt = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    LastModifiedAt = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CarModels", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Policy",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    CreatedAt = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    LastModifiedAt = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Policy", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Reviews",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LessonId = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    CreatedAt = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    LastModifiedAt = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reviews", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Role",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedAt = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    LastModifiedAt = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Role", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Cars",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CarModelId = table.Column<int>(type: "int", nullable: false),
                    Vin = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    RegistrationNumber = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedAt = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    LastModifiedAt = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cars", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Cars_CarModels_CarModelId",
                        column: x => x.CarModelId,
                        principalTable: "CarModels",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PolicyRole",
                columns: table => new
                {
                    RoleId = table.Column<int>(type: "int", nullable: false),
                    PolicyId = table.Column<int>(type: "int", nullable: false),
                    Id = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    LastModifiedAt = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PolicyRole", x => new { x.RoleId, x.PolicyId });
                    table.ForeignKey(
                        name: "FK_PolicyRole_Policy_PolicyId",
                        column: x => x.PolicyId,
                        principalTable: "Policy",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PolicyRole_Role_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Role",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Password = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Birthday = table.Column<DateTime>(type: "date", maxLength: 50, nullable: true),
                    RoleId = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    LastModifiedAt = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Users_Role_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Role",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Instructors",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdentityId = table.Column<int>(type: "int", nullable: false),
                    GearType = table.Column<int>(type: "int", nullable: false),
                    Location = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    CreatedAt = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    LastModifiedAt = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Instructors", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Instructors_Users_IdentityId",
                        column: x => x.IdentityId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdentityId = table.Column<int>(type: "int", nullable: false),
                    GearType = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    LastModifiedAt = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Students_Users_IdentityId",
                        column: x => x.IdentityId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "InstructorCars",
                columns: table => new
                {
                    CarId = table.Column<int>(type: "int", nullable: false),
                    InstructorId = table.Column<int>(type: "int", nullable: false),
                    Id = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    LastModifiedAt = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InstructorCars", x => new { x.InstructorId, x.CarId });
                    table.ForeignKey(
                        name: "FK_InstructorCars_Cars_CarId",
                        column: x => x.CarId,
                        principalTable: "Cars",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_InstructorCars_Instructors_InstructorId",
                        column: x => x.InstructorId,
                        principalTable: "Instructors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Lessons",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    InstructorId = table.Column<int>(type: "int", nullable: false),
                    StudentId = table.Column<int>(type: "int", nullable: true),
                    StartTime = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    LessonStatus = table.Column<int>(type: "int", nullable: false),
                    ReviewId = table.Column<int>(type: "int", nullable: true),
                    CreatedAt = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    LastModifiedAt = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lessons", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Lessons_Instructors_InstructorId",
                        column: x => x.InstructorId,
                        principalTable: "Instructors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Lessons_Reviews_ReviewId",
                        column: x => x.ReviewId,
                        principalTable: "Reviews",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Lessons_Students_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Students",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "CarModels",
                columns: new[] { "Id", "CarGear", "Color", "CreatedAt", "CreatedBy", "LastModifiedAt", "LastModifiedBy", "Manufacturer", "Model", "Year" },
                values: new object[,]
                {
                    { 1, 1, "purple", new DateTimeOffset(new DateTime(2023, 5, 1, 11, 50, 43, 880, DateTimeKind.Unspecified).AddTicks(7923), new TimeSpan(0, 0, 0, 0, 0)), "System Seeding", null, null, "Dacia", "Sandero", new DateTime(2019, 3, 26, 19, 57, 9, 292, DateTimeKind.Local).AddTicks(7509) },
                    { 2, 1, "red", new DateTimeOffset(new DateTime(2023, 5, 1, 11, 50, 43, 880, DateTimeKind.Unspecified).AddTicks(7923), new TimeSpan(0, 0, 0, 0, 0)), "System Seeding", null, null, "Skoda", "Fabia", new DateTime(2019, 12, 16, 4, 10, 6, 939, DateTimeKind.Local).AddTicks(9898) },
                    { 3, 2, "blue", new DateTimeOffset(new DateTime(2023, 5, 1, 11, 50, 43, 880, DateTimeKind.Unspecified).AddTicks(7923), new TimeSpan(0, 0, 0, 0, 0)), "System Seeding", null, null, "Renault", "Zoe", new DateTime(2020, 12, 18, 21, 50, 18, 189, DateTimeKind.Local).AddTicks(2838) },
                    { 4, 2, "green", new DateTimeOffset(new DateTime(2023, 5, 1, 11, 50, 43, 880, DateTimeKind.Unspecified).AddTicks(7923), new TimeSpan(0, 0, 0, 0, 0)), "System Seeding", null, null, "Skoda", "Fabia", new DateTime(2019, 10, 25, 23, 11, 52, 157, DateTimeKind.Local).AddTicks(9957) }
                });

            migrationBuilder.InsertData(
                table: "Policy",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "LastModifiedAt", "LastModifiedBy", "Name" },
                values: new object[,]
                {
                    { 1, new DateTimeOffset(new DateTime(2023, 5, 26, 12, 43, 48, 180, DateTimeKind.Unspecified).AddTicks(37), new TimeSpan(0, 3, 0, 0, 0)), "System Migration", null, null, "SeeAllUsers" },
                    { 2, new DateTimeOffset(new DateTime(2023, 5, 26, 12, 43, 48, 180, DateTimeKind.Unspecified).AddTicks(37), new TimeSpan(0, 3, 0, 0, 0)), "System Migration", null, null, "UpdateInstructorProfile" },
                    { 3, new DateTimeOffset(new DateTime(2023, 5, 26, 12, 43, 48, 180, DateTimeKind.Unspecified).AddTicks(37), new TimeSpan(0, 3, 0, 0, 0)), "System Migration", null, null, "UpdateUserProfile" }
                });

            migrationBuilder.InsertData(
                table: "Role",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "LastModifiedAt", "LastModifiedBy", "Name" },
                values: new object[,]
                {
                    { 1, new DateTimeOffset(new DateTime(2023, 5, 26, 12, 43, 48, 181, DateTimeKind.Unspecified).AddTicks(9399), new TimeSpan(0, 3, 0, 0, 0)), "System Migration", null, null, "Administrator" },
                    { 2, new DateTimeOffset(new DateTime(2023, 5, 26, 12, 43, 48, 181, DateTimeKind.Unspecified).AddTicks(9399), new TimeSpan(0, 3, 0, 0, 0)), "System Migration", null, null, "Student" },
                    { 3, new DateTimeOffset(new DateTime(2023, 5, 26, 12, 43, 48, 181, DateTimeKind.Unspecified).AddTicks(9399), new TimeSpan(0, 3, 0, 0, 0)), "System Migration", null, null, "Instructor" }
                });

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "Id", "CarModelId", "CreatedAt", "CreatedBy", "LastModifiedAt", "LastModifiedBy", "RegistrationNumber", "Vin" },
                values: new object[,]
                {
                    { 1, 3, new DateTimeOffset(new DateTime(2023, 5, 1, 11, 50, 43, 880, DateTimeKind.Unspecified).AddTicks(7923), new TimeSpan(0, 0, 0, 0, 0)), "System Seeding", null, null, "TM 993 KKB", "51C7TL35X5SD42589" },
                    { 2, 1, new DateTimeOffset(new DateTime(2023, 5, 1, 11, 50, 43, 880, DateTimeKind.Unspecified).AddTicks(7923), new TimeSpan(0, 0, 0, 0, 0)), "System Seeding", null, null, "TM 152 ZYP", "XMWZRVN1XKI817577" },
                    { 3, 1, new DateTimeOffset(new DateTime(2023, 5, 1, 11, 50, 43, 880, DateTimeKind.Unspecified).AddTicks(7923), new TimeSpan(0, 0, 0, 0, 0)), "System Seeding", null, null, "TM 080 HGC", "9FXEFSCN81EQ28486" },
                    { 4, 3, new DateTimeOffset(new DateTime(2023, 5, 1, 11, 50, 43, 880, DateTimeKind.Unspecified).AddTicks(7923), new TimeSpan(0, 0, 0, 0, 0)), "System Seeding", null, null, "TM 381 PAF", "LC6K6LLWM6VO10486" },
                    { 5, 1, new DateTimeOffset(new DateTime(2023, 5, 1, 11, 50, 43, 880, DateTimeKind.Unspecified).AddTicks(7923), new TimeSpan(0, 0, 0, 0, 0)), "System Seeding", null, null, "TM 083 GCW", "G6E7FZQT48F430415" },
                    { 6, 2, new DateTimeOffset(new DateTime(2023, 5, 1, 11, 50, 43, 880, DateTimeKind.Unspecified).AddTicks(7923), new TimeSpan(0, 0, 0, 0, 0)), "System Seeding", null, null, "TM 007 XED", "RTTWPHDC6CKV32139" },
                    { 7, 3, new DateTimeOffset(new DateTime(2023, 5, 1, 11, 50, 43, 880, DateTimeKind.Unspecified).AddTicks(7923), new TimeSpan(0, 0, 0, 0, 0)), "System Seeding", null, null, "TM 072 KRH", "QKFRHOE1MMD158061" },
                    { 8, 3, new DateTimeOffset(new DateTime(2023, 5, 1, 11, 50, 43, 880, DateTimeKind.Unspecified).AddTicks(7923), new TimeSpan(0, 0, 0, 0, 0)), "System Seeding", null, null, "TM 113 IJB", "PP1NKHQCZ3E998050" },
                    { 9, 1, new DateTimeOffset(new DateTime(2023, 5, 1, 11, 50, 43, 880, DateTimeKind.Unspecified).AddTicks(7923), new TimeSpan(0, 0, 0, 0, 0)), "System Seeding", null, null, "TM 164 LRX", "C7AFRP1AVVNT69301" },
                    { 10, 4, new DateTimeOffset(new DateTime(2023, 5, 1, 11, 50, 43, 880, DateTimeKind.Unspecified).AddTicks(7923), new TimeSpan(0, 0, 0, 0, 0)), "System Seeding", null, null, "TM 833 BKH", "UARCFYGD5VKN48345" }
                });

            migrationBuilder.InsertData(
                table: "PolicyRole",
                columns: new[] { "PolicyId", "RoleId", "CreatedAt", "CreatedBy", "Id", "LastModifiedAt", "LastModifiedBy" },
                values: new object[,]
                {
                    { 1, 1, new DateTimeOffset(new DateTime(2023, 5, 26, 12, 43, 48, 180, DateTimeKind.Unspecified).AddTicks(5318), new TimeSpan(0, 3, 0, 0, 0)), "System Migration", 1, null, null },
                    { 2, 1, new DateTimeOffset(new DateTime(2023, 5, 26, 12, 43, 48, 180, DateTimeKind.Unspecified).AddTicks(5318), new TimeSpan(0, 3, 0, 0, 0)), "System Migration", 2, null, null },
                    { 2, 2, new DateTimeOffset(new DateTime(2023, 5, 26, 12, 43, 48, 180, DateTimeKind.Unspecified).AddTicks(5318), new TimeSpan(0, 3, 0, 0, 0)), "System Migration", 3, null, null },
                    { 3, 3, new DateTimeOffset(new DateTime(2023, 5, 26, 12, 43, 48, 180, DateTimeKind.Unspecified).AddTicks(5318), new TimeSpan(0, 3, 0, 0, 0)), "System Migration", 4, null, null }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Birthday", "CreatedAt", "CreatedBy", "Email", "FirstName", "LastModifiedAt", "LastModifiedBy", "LastName", "Password", "PhoneNumber", "RoleId" },
                values: new object[,]
                {
                    { 1, new DateTime(1976, 5, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTimeOffset(new DateTime(2023, 5, 1, 11, 50, 43, 880, DateTimeKind.Unspecified).AddTicks(7923), new TimeSpan(0, 0, 0, 0, 0)), "System Seeding", "Lawrence_Heidenreich@yahoo.com", "Lawrence", null, null, "Heidenreich", "test", "+40 746 609 730", 3 },
                    { 2, new DateTime(1978, 8, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTimeOffset(new DateTime(2023, 5, 1, 11, 50, 43, 880, DateTimeKind.Unspecified).AddTicks(7923), new TimeSpan(0, 0, 0, 0, 0)), "System Seeding", "Dominic39@yahoo.com", "Dominic", null, null, "Feeney", "test", "+40 749 288 525", 2 },
                    { 3, new DateTime(1989, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTimeOffset(new DateTime(2023, 5, 1, 11, 50, 43, 880, DateTimeKind.Unspecified).AddTicks(7923), new TimeSpan(0, 0, 0, 0, 0)), "System Seeding", "Hattie_Kling89@hotmail.com", "Hattie", null, null, "Kling", "test", "+40 746 525 816", 2 },
                    { 4, new DateTime(1993, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTimeOffset(new DateTime(2023, 5, 1, 11, 50, 43, 880, DateTimeKind.Unspecified).AddTicks(7923), new TimeSpan(0, 0, 0, 0, 0)), "System Seeding", "Tasha_Jakubowski11@gmail.com", "Tasha", null, null, "Jakubowski", "test", "+40 747 184 426", 3 },
                    { 5, new DateTime(1974, 1, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTimeOffset(new DateTime(2023, 5, 1, 11, 50, 43, 880, DateTimeKind.Unspecified).AddTicks(7923), new TimeSpan(0, 0, 0, 0, 0)), "System Seeding", "Caroline88@hotmail.com", "Caroline", null, null, "Muller", "test", "+40 746 599 748", 2 },
                    { 6, new DateTime(1997, 9, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTimeOffset(new DateTime(2023, 5, 1, 11, 50, 43, 880, DateTimeKind.Unspecified).AddTicks(7923), new TimeSpan(0, 0, 0, 0, 0)), "System Seeding", "Ricardo97@yahoo.com", "Ricardo", null, null, "Gleason", "test", "+40 745 241 418", 2 },
                    { 7, new DateTime(1978, 7, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTimeOffset(new DateTime(2023, 5, 1, 11, 50, 43, 880, DateTimeKind.Unspecified).AddTicks(7923), new TimeSpan(0, 0, 0, 0, 0)), "System Seeding", "Levi21@yahoo.com", "Levi", null, null, "Beahan", "test", "+40 741 302 517", 3 },
                    { 8, new DateTime(1995, 7, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTimeOffset(new DateTime(2023, 5, 1, 11, 50, 43, 880, DateTimeKind.Unspecified).AddTicks(7923), new TimeSpan(0, 0, 0, 0, 0)), "System Seeding", "Tabitha.Russel3@yahoo.com", "Tabitha", null, null, "Russel", "test", "+40 745 808 485", 3 },
                    { 9, new DateTime(1981, 8, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTimeOffset(new DateTime(2023, 5, 1, 11, 50, 43, 880, DateTimeKind.Unspecified).AddTicks(7923), new TimeSpan(0, 0, 0, 0, 0)), "System Seeding", "Florence_Spinka@gmail.com", "Florence", null, null, "Spinka", "test", "+40 742 972 208", 2 },
                    { 10, new DateTime(1986, 10, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTimeOffset(new DateTime(2023, 5, 1, 11, 50, 43, 880, DateTimeKind.Unspecified).AddTicks(7923), new TimeSpan(0, 0, 0, 0, 0)), "System Seeding", "Molly71@gmail.com", "Molly", null, null, "Deckow", "test", "+40 743 678 572", 3 },
                    { 11, new DateTime(1980, 11, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTimeOffset(new DateTime(2023, 5, 1, 11, 50, 43, 880, DateTimeKind.Unspecified).AddTicks(7923), new TimeSpan(0, 0, 0, 0, 0)), "System Seeding", "Marie.Rolfson@hotmail.com", "Marie", null, null, "Rolfson", "test", "+40 748 985 223", 2 },
                    { 12, new DateTime(1998, 3, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTimeOffset(new DateTime(2023, 5, 1, 11, 50, 43, 880, DateTimeKind.Unspecified).AddTicks(7923), new TimeSpan(0, 0, 0, 0, 0)), "System Seeding", "Kate.Reynolds43@gmail.com", "Kate", null, null, "Reynolds", "test", "+40 748 975 984", 2 },
                    { 13, new DateTime(1973, 12, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTimeOffset(new DateTime(2023, 5, 1, 11, 50, 43, 880, DateTimeKind.Unspecified).AddTicks(7923), new TimeSpan(0, 0, 0, 0, 0)), "System Seeding", "Willie_Kertzmann47@yahoo.com", "Willie", null, null, "Kertzmann", "test", "+40 744 836 590", 3 },
                    { 14, new DateTime(1990, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTimeOffset(new DateTime(2023, 5, 1, 11, 50, 43, 880, DateTimeKind.Unspecified).AddTicks(7923), new TimeSpan(0, 0, 0, 0, 0)), "System Seeding", "Ronnie_Boyle27@gmail.com", "Ronnie", null, null, "Boyle", "test", "+40 740 773 284", 2 },
                    { 15, new DateTime(1992, 9, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTimeOffset(new DateTime(2023, 5, 1, 11, 50, 43, 880, DateTimeKind.Unspecified).AddTicks(7923), new TimeSpan(0, 0, 0, 0, 0)), "System Seeding", "Russell_Corkery@yahoo.com", "Russell", null, null, "Corkery", "test", "+40 741 645 125", 2 },
                    { 16, new DateTime(1980, 4, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTimeOffset(new DateTime(2023, 5, 1, 11, 50, 43, 880, DateTimeKind.Unspecified).AddTicks(7923), new TimeSpan(0, 0, 0, 0, 0)), "System Seeding", "Allen31@gmail.com", "Allen", null, null, "Barton", "test", "+40 741 666 019", 2 },
                    { 17, new DateTime(1996, 9, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTimeOffset(new DateTime(2023, 5, 1, 11, 50, 43, 880, DateTimeKind.Unspecified).AddTicks(7923), new TimeSpan(0, 0, 0, 0, 0)), "System Seeding", "Gregg26@yahoo.com", "Gregg", null, null, "Harber", "test", "+40 749 413 264", 3 },
                    { 18, new DateTime(1995, 11, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTimeOffset(new DateTime(2023, 5, 1, 11, 50, 43, 880, DateTimeKind.Unspecified).AddTicks(7923), new TimeSpan(0, 0, 0, 0, 0)), "System Seeding", "Barbara.Predovic67@gmail.com", "Barbara", null, null, "Predovic", "test", "+40 742 591 086", 2 },
                    { 19, new DateTime(1985, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTimeOffset(new DateTime(2023, 5, 1, 11, 50, 43, 880, DateTimeKind.Unspecified).AddTicks(7923), new TimeSpan(0, 0, 0, 0, 0)), "System Seeding", "Casey42@hotmail.com", "Casey", null, null, "Hagenes", "test", "+40 744 700 580", 3 },
                    { 20, new DateTime(1994, 12, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTimeOffset(new DateTime(2023, 5, 1, 11, 50, 43, 880, DateTimeKind.Unspecified).AddTicks(7923), new TimeSpan(0, 0, 0, 0, 0)), "System Seeding", "Carrie47@yahoo.com", "Carrie", null, null, "Johnson", "test", "+40 747 645 343", 3 },
                    { 21, new DateTime(1983, 8, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTimeOffset(new DateTime(2023, 5, 1, 11, 50, 43, 880, DateTimeKind.Unspecified).AddTicks(7923), new TimeSpan(0, 0, 0, 0, 0)), "System Seeding", "Elvira51@gmail.com", "Elvira", null, null, "Conroy", "test", "+40 741 130 401", 2 },
                    { 22, new DateTime(1979, 12, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTimeOffset(new DateTime(2023, 5, 1, 11, 50, 43, 880, DateTimeKind.Unspecified).AddTicks(7923), new TimeSpan(0, 0, 0, 0, 0)), "System Seeding", "Justin98@yahoo.com", "Justin", null, null, "Crist", "test", "+40 748 305 797", 2 },
                    { 23, new DateTime(1996, 4, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTimeOffset(new DateTime(2023, 5, 1, 11, 50, 43, 880, DateTimeKind.Unspecified).AddTicks(7923), new TimeSpan(0, 0, 0, 0, 0)), "System Seeding", "Shannon24@gmail.com", "Shannon", null, null, "Spencer", "test", "+40 740 885 568", 2 },
                    { 24, new DateTime(1988, 12, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTimeOffset(new DateTime(2023, 5, 1, 11, 50, 43, 880, DateTimeKind.Unspecified).AddTicks(7923), new TimeSpan(0, 0, 0, 0, 0)), "System Seeding", "Paul32@hotmail.com", "Paul", null, null, "Hamill", "test", "+40 748 860 452", 3 },
                    { 25, new DateTime(1973, 9, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTimeOffset(new DateTime(2023, 5, 1, 11, 50, 43, 880, DateTimeKind.Unspecified).AddTicks(7923), new TimeSpan(0, 0, 0, 0, 0)), "System Seeding", "Sylvia.Von58@yahoo.com", "Sylvia", null, null, "Von", "test", "+40 742 814 763", 3 },
                    { 26, new DateTime(1977, 6, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTimeOffset(new DateTime(2023, 5, 1, 11, 50, 43, 880, DateTimeKind.Unspecified).AddTicks(7923), new TimeSpan(0, 0, 0, 0, 0)), "System Seeding", "Ollie.Grady@hotmail.com", "Ollie", null, null, "Grady", "test", "+40 741 660 734", 3 },
                    { 27, new DateTime(1988, 1, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTimeOffset(new DateTime(2023, 5, 1, 11, 50, 43, 880, DateTimeKind.Unspecified).AddTicks(7923), new TimeSpan(0, 0, 0, 0, 0)), "System Seeding", "Courtney.Weissnat@yahoo.com", "Courtney", null, null, "Weissnat", "test", "+40 743 488 529", 2 },
                    { 28, new DateTime(1987, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTimeOffset(new DateTime(2023, 5, 1, 11, 50, 43, 880, DateTimeKind.Unspecified).AddTicks(7923), new TimeSpan(0, 0, 0, 0, 0)), "System Seeding", "Billy.Schmeler29@gmail.com", "Billy", null, null, "Schmeler", "test", "+40 745 788 434", 3 }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Birthday", "CreatedAt", "CreatedBy", "Email", "FirstName", "LastModifiedAt", "LastModifiedBy", "LastName", "Password", "PhoneNumber", "RoleId" },
                values: new object[,]
                {
                    { 29, new DateTime(1983, 5, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTimeOffset(new DateTime(2023, 5, 1, 11, 50, 43, 880, DateTimeKind.Unspecified).AddTicks(7923), new TimeSpan(0, 0, 0, 0, 0)), "System Seeding", "Ellis.Rath@gmail.com", "Ellis", null, null, "Rath", "test", "+40 745 539 503", 2 },
                    { 30, new DateTime(1995, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTimeOffset(new DateTime(2023, 5, 1, 11, 50, 43, 880, DateTimeKind.Unspecified).AddTicks(7923), new TimeSpan(0, 0, 0, 0, 0)), "System Seeding", "Eunice_Hartmann84@hotmail.com", "Eunice", null, null, "Hartmann", "test", "+40 746 038 497", 3 },
                    { 31, new DateTime(1973, 5, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTimeOffset(new DateTime(2023, 5, 1, 11, 50, 43, 880, DateTimeKind.Unspecified).AddTicks(7923), new TimeSpan(0, 0, 0, 0, 0)), "System Seeding", "Leon8@gmail.com", "Leon", null, null, "Bahringer", "test", "+40 741 467 367", 3 },
                    { 32, new DateTime(1977, 9, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTimeOffset(new DateTime(2023, 5, 1, 11, 50, 43, 880, DateTimeKind.Unspecified).AddTicks(7923), new TimeSpan(0, 0, 0, 0, 0)), "System Seeding", "Rex_Crist92@hotmail.com", "Rex", null, null, "Crist", "test", "+40 743 797 312", 3 },
                    { 33, new DateTime(1975, 12, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTimeOffset(new DateTime(2023, 5, 1, 11, 50, 43, 880, DateTimeKind.Unspecified).AddTicks(7923), new TimeSpan(0, 0, 0, 0, 0)), "System Seeding", "Larry_Feil@yahoo.com", "Larry", null, null, "Feil", "test", "+40 746 837 518", 2 },
                    { 34, new DateTime(1975, 3, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTimeOffset(new DateTime(2023, 5, 1, 11, 50, 43, 880, DateTimeKind.Unspecified).AddTicks(7923), new TimeSpan(0, 0, 0, 0, 0)), "System Seeding", "Roberto64@hotmail.com", "Roberto", null, null, "Johnson", "test", "+40 744 554 287", 2 },
                    { 35, new DateTime(1989, 6, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTimeOffset(new DateTime(2023, 5, 1, 11, 50, 43, 880, DateTimeKind.Unspecified).AddTicks(7923), new TimeSpan(0, 0, 0, 0, 0)), "System Seeding", "Ollie_Rau@gmail.com", "Ollie", null, null, "Rau", "test", "+40 749 185 137", 2 },
                    { 36, new DateTime(1975, 10, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTimeOffset(new DateTime(2023, 5, 1, 11, 50, 43, 880, DateTimeKind.Unspecified).AddTicks(7923), new TimeSpan(0, 0, 0, 0, 0)), "System Seeding", "Joshua_Gislason79@yahoo.com", "Joshua", null, null, "Gislason", "test", "+40 747 875 516", 3 },
                    { 37, new DateTime(1997, 10, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTimeOffset(new DateTime(2023, 5, 1, 11, 50, 43, 880, DateTimeKind.Unspecified).AddTicks(7923), new TimeSpan(0, 0, 0, 0, 0)), "System Seeding", "Jacquelyn93@gmail.com", "Jacquelyn", null, null, "Abbott", "test", "+40 745 897 819", 3 },
                    { 38, new DateTime(1986, 4, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTimeOffset(new DateTime(2023, 5, 1, 11, 50, 43, 880, DateTimeKind.Unspecified).AddTicks(7923), new TimeSpan(0, 0, 0, 0, 0)), "System Seeding", "Courtney46@hotmail.com", "Courtney", null, null, "Konopelski", "test", "+40 745 367 305", 2 },
                    { 39, new DateTime(1988, 6, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTimeOffset(new DateTime(2023, 5, 1, 11, 50, 43, 880, DateTimeKind.Unspecified).AddTicks(7923), new TimeSpan(0, 0, 0, 0, 0)), "System Seeding", "Don_VonRueden49@hotmail.com", "Don", null, null, "VonRueden", "test", "+40 748 036 666", 3 },
                    { 40, new DateTime(1975, 3, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTimeOffset(new DateTime(2023, 5, 1, 11, 50, 43, 880, DateTimeKind.Unspecified).AddTicks(7923), new TimeSpan(0, 0, 0, 0, 0)), "System Seeding", "Isabel_Barrows@hotmail.com", "Isabel", null, null, "Barrows", "test", "+40 748 872 640", 3 },
                    { 41, new DateTime(1998, 3, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTimeOffset(new DateTime(2023, 5, 1, 11, 50, 43, 880, DateTimeKind.Unspecified).AddTicks(7923), new TimeSpan(0, 0, 0, 0, 0)), "System Seeding", "Duane_Murphy76@yahoo.com", "Duane", null, null, "Murphy", "test", "+40 744 593 423", 3 },
                    { 42, new DateTime(1991, 6, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTimeOffset(new DateTime(2023, 5, 1, 11, 50, 43, 880, DateTimeKind.Unspecified).AddTicks(7923), new TimeSpan(0, 0, 0, 0, 0)), "System Seeding", "Homer.Purdy@gmail.com", "Homer", null, null, "Purdy", "test", "+40 746 482 790", 2 },
                    { 43, new DateTime(1977, 1, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTimeOffset(new DateTime(2023, 5, 1, 11, 50, 43, 880, DateTimeKind.Unspecified).AddTicks(7923), new TimeSpan(0, 0, 0, 0, 0)), "System Seeding", "Carolyn14@yahoo.com", "Carolyn", null, null, "Deckow", "test", "+40 747 021 182", 2 },
                    { 44, new DateTime(1989, 11, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTimeOffset(new DateTime(2023, 5, 1, 11, 50, 43, 880, DateTimeKind.Unspecified).AddTicks(7923), new TimeSpan(0, 0, 0, 0, 0)), "System Seeding", "Vivian.Maggio22@hotmail.com", "Vivian", null, null, "Maggio", "test", "+40 742 063 443", 2 },
                    { 45, new DateTime(1991, 11, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTimeOffset(new DateTime(2023, 5, 1, 11, 50, 43, 880, DateTimeKind.Unspecified).AddTicks(7923), new TimeSpan(0, 0, 0, 0, 0)), "System Seeding", "Ramon73@gmail.com", "Ramon", null, null, "O'Conner", "test", "+40 749 795 409", 2 },
                    { 46, new DateTime(1979, 12, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTimeOffset(new DateTime(2023, 5, 1, 11, 50, 43, 880, DateTimeKind.Unspecified).AddTicks(7923), new TimeSpan(0, 0, 0, 0, 0)), "System Seeding", "Roger_Brekke44@hotmail.com", "Roger", null, null, "Brekke", "test", "+40 740 449 287", 3 },
                    { 47, new DateTime(1995, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTimeOffset(new DateTime(2023, 5, 1, 11, 50, 43, 880, DateTimeKind.Unspecified).AddTicks(7923), new TimeSpan(0, 0, 0, 0, 0)), "System Seeding", "Ralph66@gmail.com", "Ralph", null, null, "Ankunding", "test", "+40 749 396 483", 3 },
                    { 48, new DateTime(1993, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTimeOffset(new DateTime(2023, 5, 1, 11, 50, 43, 880, DateTimeKind.Unspecified).AddTicks(7923), new TimeSpan(0, 0, 0, 0, 0)), "System Seeding", "Garrett14@gmail.com", "Garrett", null, null, "Connelly", "test", "+40 740 621 804", 2 },
                    { 49, new DateTime(1991, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTimeOffset(new DateTime(2023, 5, 1, 11, 50, 43, 880, DateTimeKind.Unspecified).AddTicks(7923), new TimeSpan(0, 0, 0, 0, 0)), "System Seeding", "Ginger.Armstrong@gmail.com", "Ginger", null, null, "Armstrong", "test", "+40 743 272 815", 2 },
                    { 50, new DateTime(1979, 12, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTimeOffset(new DateTime(2023, 5, 1, 11, 50, 43, 880, DateTimeKind.Unspecified).AddTicks(7923), new TimeSpan(0, 0, 0, 0, 0)), "System Seeding", "Kelly_Pouros@yahoo.com", "Kelly", null, null, "Pouros", "test", "+40 746 068 948", 3 }
                });

            migrationBuilder.InsertData(
                table: "Instructors",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "GearType", "IdentityId", "LastModifiedAt", "LastModifiedBy", "Location" },
                values: new object[,]
                {
                    { 1, new DateTimeOffset(new DateTime(2023, 5, 26, 9, 43, 48, 178, DateTimeKind.Unspecified).AddTicks(7458), new TimeSpan(0, 0, 0, 0, 0)), "System Seeding", 1, 1, null, null, "Strada Crișul 7" },
                    { 2, new DateTimeOffset(new DateTime(2023, 5, 26, 9, 43, 48, 178, DateTimeKind.Unspecified).AddTicks(7458), new TimeSpan(0, 0, 0, 0, 0)), "System Seeding", 1, 4, null, null, "Strada Crișul 7" },
                    { 3, new DateTimeOffset(new DateTime(2023, 5, 26, 9, 43, 48, 178, DateTimeKind.Unspecified).AddTicks(7458), new TimeSpan(0, 0, 0, 0, 0)), "System Seeding", 1, 7, null, null, "Strada Crișul 7" },
                    { 4, new DateTimeOffset(new DateTime(2023, 5, 26, 9, 43, 48, 178, DateTimeKind.Unspecified).AddTicks(7458), new TimeSpan(0, 0, 0, 0, 0)), "System Seeding", 1, 8, null, null, "Strada Crișul 7" },
                    { 5, new DateTimeOffset(new DateTime(2023, 5, 26, 9, 43, 48, 178, DateTimeKind.Unspecified).AddTicks(7458), new TimeSpan(0, 0, 0, 0, 0)), "System Seeding", 1, 10, null, null, "Strada Crișul 7" },
                    { 6, new DateTimeOffset(new DateTime(2023, 5, 26, 9, 43, 48, 178, DateTimeKind.Unspecified).AddTicks(7458), new TimeSpan(0, 0, 0, 0, 0)), "System Seeding", 2, 13, null, null, "Strada Crișul 7" },
                    { 7, new DateTimeOffset(new DateTime(2023, 5, 26, 9, 43, 48, 178, DateTimeKind.Unspecified).AddTicks(7458), new TimeSpan(0, 0, 0, 0, 0)), "System Seeding", 2, 24, null, null, "Strada Crișul 7" },
                    { 8, new DateTimeOffset(new DateTime(2023, 5, 26, 9, 43, 48, 178, DateTimeKind.Unspecified).AddTicks(7458), new TimeSpan(0, 0, 0, 0, 0)), "System Seeding", 2, 25, null, null, "Strada Crișul 7" },
                    { 9, new DateTimeOffset(new DateTime(2023, 5, 26, 9, 43, 48, 178, DateTimeKind.Unspecified).AddTicks(7458), new TimeSpan(0, 0, 0, 0, 0)), "System Seeding", 2, 26, null, null, "Strada Crișul 7" },
                    { 10, new DateTimeOffset(new DateTime(2023, 5, 26, 9, 43, 48, 178, DateTimeKind.Unspecified).AddTicks(7458), new TimeSpan(0, 0, 0, 0, 0)), "System Seeding", 2, 28, null, null, "Strada Crișul 7" }
                });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "GearType", "IdentityId", "LastModifiedAt", "LastModifiedBy" },
                values: new object[,]
                {
                    { 1, new DateTimeOffset(new DateTime(2023, 5, 26, 9, 43, 48, 181, DateTimeKind.Unspecified).AddTicks(9696), new TimeSpan(0, 0, 0, 0, 0)), "System Seeding", 1, 1, null, null },
                    { 2, new DateTimeOffset(new DateTime(2023, 5, 26, 9, 43, 48, 181, DateTimeKind.Unspecified).AddTicks(9696), new TimeSpan(0, 0, 0, 0, 0)), "System Seeding", 1, 7, null, null }
                });

            migrationBuilder.InsertData(
                table: "InstructorCars",
                columns: new[] { "CarId", "InstructorId", "CreatedAt", "CreatedBy", "Id", "LastModifiedAt", "LastModifiedBy" },
                values: new object[,]
                {
                    { 2, 1, new DateTimeOffset(new DateTime(2023, 5, 26, 12, 43, 48, 178, DateTimeKind.Unspecified).AddTicks(6937), new TimeSpan(0, 3, 0, 0, 0)), "System Migration", 1, null, null },
                    { 6, 1, new DateTimeOffset(new DateTime(2023, 5, 26, 12, 43, 48, 178, DateTimeKind.Unspecified).AddTicks(6937), new TimeSpan(0, 3, 0, 0, 0)), "System Migration", 2, null, null },
                    { 3, 2, new DateTimeOffset(new DateTime(2023, 5, 26, 12, 43, 48, 178, DateTimeKind.Unspecified).AddTicks(6937), new TimeSpan(0, 3, 0, 0, 0)), "System Migration", 3, null, null },
                    { 5, 3, new DateTimeOffset(new DateTime(2023, 5, 26, 12, 43, 48, 178, DateTimeKind.Unspecified).AddTicks(6937), new TimeSpan(0, 3, 0, 0, 0)), "System Migration", 4, null, null },
                    { 6, 4, new DateTimeOffset(new DateTime(2023, 5, 26, 12, 43, 48, 178, DateTimeKind.Unspecified).AddTicks(6937), new TimeSpan(0, 3, 0, 0, 0)), "System Migration", 5, null, null },
                    { 9, 5, new DateTimeOffset(new DateTime(2023, 5, 26, 12, 43, 48, 178, DateTimeKind.Unspecified).AddTicks(6937), new TimeSpan(0, 3, 0, 0, 0)), "System Migration", 6, null, null },
                    { 1, 6, new DateTimeOffset(new DateTime(2023, 5, 26, 12, 43, 48, 178, DateTimeKind.Unspecified).AddTicks(6937), new TimeSpan(0, 3, 0, 0, 0)), "System Migration", 7, null, null },
                    { 4, 7, new DateTimeOffset(new DateTime(2023, 5, 26, 12, 43, 48, 178, DateTimeKind.Unspecified).AddTicks(6937), new TimeSpan(0, 3, 0, 0, 0)), "System Migration", 8, null, null },
                    { 7, 8, new DateTimeOffset(new DateTime(2023, 5, 26, 12, 43, 48, 178, DateTimeKind.Unspecified).AddTicks(6937), new TimeSpan(0, 3, 0, 0, 0)), "System Migration", 9, null, null },
                    { 8, 9, new DateTimeOffset(new DateTime(2023, 5, 26, 12, 43, 48, 178, DateTimeKind.Unspecified).AddTicks(6937), new TimeSpan(0, 3, 0, 0, 0)), "System Migration", 10, null, null },
                    { 10, 10, new DateTimeOffset(new DateTime(2023, 5, 26, 12, 43, 48, 178, DateTimeKind.Unspecified).AddTicks(6937), new TimeSpan(0, 3, 0, 0, 0)), "System Migration", 10, null, null }
                });

            migrationBuilder.InsertData(
                table: "Lessons",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "InstructorId", "LastModifiedAt", "LastModifiedBy", "LessonStatus", "ReviewId", "StartTime", "StudentId" },
                values: new object[,]
                {
                    { 1, new DateTimeOffset(new DateTime(2023, 5, 26, 9, 43, 48, 179, DateTimeKind.Unspecified).AddTicks(8598), new TimeSpan(0, 0, 0, 0, 0)), "System Seeding", 1, null, null, 0, null, new DateTimeOffset(new DateTime(2023, 7, 25, 10, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 1 },
                    { 2, new DateTimeOffset(new DateTime(2023, 5, 26, 9, 43, 48, 179, DateTimeKind.Unspecified).AddTicks(8598), new TimeSpan(0, 0, 0, 0, 0)), "System Seeding", 2, null, null, 0, null, new DateTimeOffset(new DateTime(2023, 7, 25, 10, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 1 },
                    { 3, new DateTimeOffset(new DateTime(2023, 5, 26, 9, 43, 48, 179, DateTimeKind.Unspecified).AddTicks(8598), new TimeSpan(0, 0, 0, 0, 0)), "System Seeding", 1, null, null, 0, null, new DateTimeOffset(new DateTime(2023, 7, 25, 10, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 2 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Cars_CarModelId",
                table: "Cars",
                column: "CarModelId");

            migrationBuilder.CreateIndex(
                name: "IX_InstructorCars_CarId",
                table: "InstructorCars",
                column: "CarId");

            migrationBuilder.CreateIndex(
                name: "IX_Instructors_IdentityId",
                table: "Instructors",
                column: "IdentityId");

            migrationBuilder.CreateIndex(
                name: "IX_Lessons_InstructorId",
                table: "Lessons",
                column: "InstructorId");

            migrationBuilder.CreateIndex(
                name: "IX_Lessons_ReviewId",
                table: "Lessons",
                column: "ReviewId",
                unique: true,
                filter: "[ReviewId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Lessons_StudentId",
                table: "Lessons",
                column: "StudentId");

            migrationBuilder.CreateIndex(
                name: "IX_Policy_Name",
                table: "Policy",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_PolicyRole_PolicyId",
                table: "PolicyRole",
                column: "PolicyId");

            migrationBuilder.CreateIndex(
                name: "IX_Role_Name",
                table: "Role",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Students_IdentityId",
                table: "Students",
                column: "IdentityId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_Email",
                table: "Users",
                column: "Email",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Users_RoleId",
                table: "Users",
                column: "RoleId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "InstructorCars");

            migrationBuilder.DropTable(
                name: "Lessons");

            migrationBuilder.DropTable(
                name: "PolicyRole");

            migrationBuilder.DropTable(
                name: "Cars");

            migrationBuilder.DropTable(
                name: "Instructors");

            migrationBuilder.DropTable(
                name: "Reviews");

            migrationBuilder.DropTable(
                name: "Students");

            migrationBuilder.DropTable(
                name: "Policy");

            migrationBuilder.DropTable(
                name: "CarModels");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Role");
        }
    }
}
