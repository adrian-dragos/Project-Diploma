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
                name: "Cars",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Manufacturer = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Model = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Year = table.Column<DateTime>(type: "datetime2", maxLength: 50, nullable: false),
                    Color = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Vin = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RegistrationNumber = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CarGear = table.Column<int>(type: "int", maxLength: 50, nullable: false),
                    CreatedAt = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    LastModifiedAt = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cars", x => x.Id);
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
                table: "Cars",
                columns: new[] { "Id", "CarGear", "Color", "CreatedAt", "CreatedBy", "LastModifiedAt", "LastModifiedBy", "Manufacturer", "Model", "RegistrationNumber", "Vin", "Year" },
                values: new object[,]
                {
                    { 1, 1, "purple", new DateTimeOffset(new DateTime(2023, 5, 1, 11, 50, 43, 880, DateTimeKind.Unspecified).AddTicks(7923), new TimeSpan(0, 0, 0, 0, 0)), "System Seeding", null, null, "Bugatti", "Mustang", "TM 430 YQX", "7TL35X5PDDZY39623", new DateTime(2019, 6, 2, 12, 17, 31, 803, DateTimeKind.Local).AddTicks(306) },
                    { 2, 2, "green", new DateTimeOffset(new DateTime(2023, 5, 1, 11, 50, 43, 880, DateTimeKind.Unspecified).AddTicks(7923), new TimeSpan(0, 0, 0, 0, 0)), "System Seeding", null, null, "Smart", "Civic", "TM 944 UJR", "XKB836IAYXP949127", new DateTime(2018, 6, 30, 7, 12, 9, 577, DateTimeKind.Local).AddTicks(9144) },
                    { 3, 1, "green", new DateTimeOffset(new DateTime(2023, 5, 1, 11, 50, 43, 880, DateTimeKind.Unspecified).AddTicks(7923), new TimeSpan(0, 0, 0, 0, 0)), "System Seeding", null, null, "Cadillac", "A8", "TM 961 VRA", "0U1A92LC6KEL64578", new DateTime(2019, 1, 2, 17, 36, 48, 982, DateTimeKind.Local).AddTicks(3784) },
                    { 4, 1, "purple", new DateTimeOffset(new DateTime(2023, 5, 1, 11, 50, 43, 880, DateTimeKind.Unspecified).AddTicks(7923), new TimeSpan(0, 0, 0, 0, 0)), "System Seeding", null, null, "Bugatti", "Prius", "TM 208 JGC", "7G6E7FZQT4F822237", new DateTime(2018, 5, 26, 3, 10, 32, 124, DateTimeKind.Local).AddTicks(6860) },
                    { 5, 1, "blue", new DateTimeOffset(new DateTime(2023, 5, 1, 11, 50, 43, 880, DateTimeKind.Unspecified).AddTicks(7923), new TimeSpan(0, 0, 0, 0, 0)), "System Seeding", null, null, "Porsche", "911", "TM 117 OKU", "PHDC6CEV81BS91672", new DateTime(2021, 1, 27, 11, 8, 42, 689, DateTimeKind.Local).AddTicks(8703) },
                    { 6, 2, "red", new DateTimeOffset(new DateTime(2023, 5, 1, 11, 50, 43, 880, DateTimeKind.Unspecified).AddTicks(7923), new TimeSpan(0, 0, 0, 0, 0)), "System Seeding", null, null, "Hyundai", "Taurus", "TM 654 SIZ", "M41J0Q8EN9SP14212", new DateTime(2020, 3, 28, 21, 50, 33, 347, DateTimeKind.Local).AddTicks(361) },
                    { 7, 2, "yellow", new DateTimeOffset(new DateTime(2023, 5, 1, 11, 50, 43, 880, DateTimeKind.Unspecified).AddTicks(7923), new TimeSpan(0, 0, 0, 0, 0)), "System Seeding", null, null, "Dodge", "XC90", "TM 885 VRD", "4DBC1C7AFRS137035", new DateTime(2018, 12, 4, 9, 0, 52, 465, DateTimeKind.Local).AddTicks(9878) },
                    { 8, 1, "green", new DateTimeOffset(new DateTime(2023, 5, 1, 11, 50, 43, 880, DateTimeKind.Unspecified).AddTicks(7923), new TimeSpan(0, 0, 0, 0, 0)), "System Seeding", null, null, "Hyundai", "Element", "TM 833 BKH", "UARCFYGD5VKN48345", new DateTime(2021, 2, 25, 19, 1, 3, 592, DateTimeKind.Local).AddTicks(5943) },
                    { 9, 2, "blue", new DateTimeOffset(new DateTime(2023, 5, 1, 11, 50, 43, 880, DateTimeKind.Unspecified).AddTicks(7923), new TimeSpan(0, 0, 0, 0, 0)), "System Seeding", null, null, "Kia", "Cruze", "TM 884 IIX", "HG9H4CPPOEMR62088", new DateTime(2020, 12, 14, 23, 41, 20, 561, DateTimeKind.Local).AddTicks(5842) },
                    { 10, 2, "red", new DateTimeOffset(new DateTime(2023, 5, 1, 11, 50, 43, 880, DateTimeKind.Unspecified).AddTicks(7923), new TimeSpan(0, 0, 0, 0, 0)), "System Seeding", null, null, "Chevrolet", "Explorer", "TM 927 ESZ", "ATK25E0B3WWY71897", new DateTime(2021, 3, 10, 8, 50, 0, 747, DateTimeKind.Local).AddTicks(6122) }
                });

            migrationBuilder.InsertData(
                table: "Policy",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "LastModifiedAt", "LastModifiedBy", "Name" },
                values: new object[,]
                {
                    { 1, new DateTimeOffset(new DateTime(2023, 5, 22, 14, 34, 50, 545, DateTimeKind.Unspecified).AddTicks(8598), new TimeSpan(0, 3, 0, 0, 0)), "System Migration", null, null, "SeeAllUsers" },
                    { 2, new DateTimeOffset(new DateTime(2023, 5, 22, 14, 34, 50, 545, DateTimeKind.Unspecified).AddTicks(8598), new TimeSpan(0, 3, 0, 0, 0)), "System Migration", null, null, "UpdateInstructorProfile" },
                    { 3, new DateTimeOffset(new DateTime(2023, 5, 22, 14, 34, 50, 545, DateTimeKind.Unspecified).AddTicks(8598), new TimeSpan(0, 3, 0, 0, 0)), "System Migration", null, null, "UpdateUserProfile" }
                });

            migrationBuilder.InsertData(
                table: "Role",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "LastModifiedAt", "LastModifiedBy", "Name" },
                values: new object[,]
                {
                    { 1, new DateTimeOffset(new DateTime(2023, 5, 22, 14, 34, 50, 548, DateTimeKind.Unspecified).AddTicks(869), new TimeSpan(0, 3, 0, 0, 0)), "System Migration", null, null, "Administrator" },
                    { 2, new DateTimeOffset(new DateTime(2023, 5, 22, 14, 34, 50, 548, DateTimeKind.Unspecified).AddTicks(869), new TimeSpan(0, 3, 0, 0, 0)), "System Migration", null, null, "Student" },
                    { 3, new DateTimeOffset(new DateTime(2023, 5, 22, 14, 34, 50, 548, DateTimeKind.Unspecified).AddTicks(869), new TimeSpan(0, 3, 0, 0, 0)), "System Migration", null, null, "Instructor" }
                });

            migrationBuilder.InsertData(
                table: "PolicyRole",
                columns: new[] { "PolicyId", "RoleId", "CreatedAt", "CreatedBy", "Id", "LastModifiedAt", "LastModifiedBy" },
                values: new object[,]
                {
                    { 1, 1, new DateTimeOffset(new DateTime(2023, 5, 22, 14, 34, 50, 546, DateTimeKind.Unspecified).AddTicks(4659), new TimeSpan(0, 3, 0, 0, 0)), "System Migration", 1, null, null },
                    { 2, 1, new DateTimeOffset(new DateTime(2023, 5, 22, 14, 34, 50, 546, DateTimeKind.Unspecified).AddTicks(4659), new TimeSpan(0, 3, 0, 0, 0)), "System Migration", 2, null, null },
                    { 2, 2, new DateTimeOffset(new DateTime(2023, 5, 22, 14, 34, 50, 546, DateTimeKind.Unspecified).AddTicks(4659), new TimeSpan(0, 3, 0, 0, 0)), "System Migration", 3, null, null },
                    { 3, 3, new DateTimeOffset(new DateTime(2023, 5, 22, 14, 34, 50, 546, DateTimeKind.Unspecified).AddTicks(4659), new TimeSpan(0, 3, 0, 0, 0)), "System Migration", 4, null, null }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Birthday", "CreatedAt", "CreatedBy", "Email", "FirstName", "LastModifiedAt", "LastModifiedBy", "LastName", "Password", "PhoneNumber", "RoleId" },
                values: new object[,]
                {
                    { 1, new DateTime(1974, 5, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTimeOffset(new DateTime(2023, 5, 1, 11, 50, 43, 880, DateTimeKind.Unspecified).AddTicks(7923), new TimeSpan(0, 0, 0, 0, 0)), "System Seeding", "Celia_Davis@hotmail.com", "Celia", null, null, "Davis", "test", "+40 746 964 446", 3 },
                    { 2, new DateTime(1985, 3, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTimeOffset(new DateTime(2023, 5, 1, 11, 50, 43, 880, DateTimeKind.Unspecified).AddTicks(7923), new TimeSpan(0, 0, 0, 0, 0)), "System Seeding", "Devin83@gmail.com", "Devin", null, null, "Little", "test", "+40 743 381 834", 1 },
                    { 3, new DateTime(1996, 9, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTimeOffset(new DateTime(2023, 5, 1, 11, 50, 43, 880, DateTimeKind.Unspecified).AddTicks(7923), new TimeSpan(0, 0, 0, 0, 0)), "System Seeding", "Clifton_Okuneva@gmail.com", "Clifton", null, null, "Okuneva", "test", "+40 747 565 216", 1 },
                    { 4, new DateTime(1982, 7, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTimeOffset(new DateTime(2023, 5, 1, 11, 50, 43, 880, DateTimeKind.Unspecified).AddTicks(7923), new TimeSpan(0, 0, 0, 0, 0)), "System Seeding", "Pauline_Daugherty@yahoo.com", "Pauline", null, null, "Daugherty", "test", "+40 742 478 065", 2 },
                    { 5, new DateTime(1995, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTimeOffset(new DateTime(2023, 5, 1, 11, 50, 43, 880, DateTimeKind.Unspecified).AddTicks(7923), new TimeSpan(0, 0, 0, 0, 0)), "System Seeding", "Janie32@gmail.com", "Janie", null, null, "Satterfield", "test", "+40 747 590 444", 1 },
                    { 6, new DateTime(1985, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTimeOffset(new DateTime(2023, 5, 1, 11, 50, 43, 880, DateTimeKind.Unspecified).AddTicks(7923), new TimeSpan(0, 0, 0, 0, 0)), "System Seeding", "Colin.Cronin@hotmail.com", "Colin", null, null, "Cronin", "test", "+40 743 983 542", 1 },
                    { 7, new DateTime(1974, 4, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTimeOffset(new DateTime(2023, 5, 1, 11, 50, 43, 880, DateTimeKind.Unspecified).AddTicks(7923), new TimeSpan(0, 0, 0, 0, 0)), "System Seeding", "Freddie.Stiedemann87@gmail.com", "Freddie", null, null, "Stiedemann", "test", "+40 747 730 492", 3 },
                    { 8, new DateTime(1994, 6, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTimeOffset(new DateTime(2023, 5, 1, 11, 50, 43, 880, DateTimeKind.Unspecified).AddTicks(7923), new TimeSpan(0, 0, 0, 0, 0)), "System Seeding", "Nick.Wilderman60@hotmail.com", "Nick", null, null, "Wilderman", "test", "+40 748 485 882", 2 },
                    { 9, new DateTime(1989, 3, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTimeOffset(new DateTime(2023, 5, 1, 11, 50, 43, 880, DateTimeKind.Unspecified).AddTicks(7923), new TimeSpan(0, 0, 0, 0, 0)), "System Seeding", "Tanya.Luettgen@hotmail.com", "Tanya", null, null, "Luettgen", "test", "+40 747 220 837", 1 },
                    { 10, new DateTime(1992, 2, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTimeOffset(new DateTime(2023, 5, 1, 11, 50, 43, 880, DateTimeKind.Unspecified).AddTicks(7923), new TimeSpan(0, 0, 0, 0, 0)), "System Seeding", "Donnie_Borer30@hotmail.com", "Donnie", null, null, "Borer", "test", "+40 742 590 793", 3 }
                });

            migrationBuilder.InsertData(
                table: "Instructors",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "GearType", "IdentityId", "LastModifiedAt", "LastModifiedBy" },
                values: new object[,]
                {
                    { 1, new DateTimeOffset(new DateTime(2023, 5, 22, 11, 34, 50, 543, DateTimeKind.Unspecified).AddTicks(7877), new TimeSpan(0, 0, 0, 0, 0)), "System Seeding", 1, 4, null, null },
                    { 2, new DateTimeOffset(new DateTime(2023, 5, 22, 11, 34, 50, 543, DateTimeKind.Unspecified).AddTicks(7877), new TimeSpan(0, 0, 0, 0, 0)), "System Seeding", 1, 8, null, null }
                });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "GearType", "IdentityId", "LastModifiedAt", "LastModifiedBy" },
                values: new object[,]
                {
                    { 1, new DateTimeOffset(new DateTime(2023, 5, 22, 11, 34, 50, 548, DateTimeKind.Unspecified).AddTicks(1343), new TimeSpan(0, 0, 0, 0, 0)), "System Seeding", 1, 1, null, null },
                    { 2, new DateTimeOffset(new DateTime(2023, 5, 22, 11, 34, 50, 548, DateTimeKind.Unspecified).AddTicks(1343), new TimeSpan(0, 0, 0, 0, 0)), "System Seeding", 1, 7, null, null }
                });

            migrationBuilder.InsertData(
                table: "InstructorCars",
                columns: new[] { "CarId", "InstructorId", "CreatedAt", "CreatedBy", "Id", "LastModifiedAt", "LastModifiedBy" },
                values: new object[,]
                {
                    { 1, 1, new DateTimeOffset(new DateTime(2023, 5, 22, 14, 34, 50, 543, DateTimeKind.Unspecified).AddTicks(7024), new TimeSpan(0, 3, 0, 0, 0)), "System Migration", 1, null, null },
                    { 2, 1, new DateTimeOffset(new DateTime(2023, 5, 22, 14, 34, 50, 543, DateTimeKind.Unspecified).AddTicks(7024), new TimeSpan(0, 3, 0, 0, 0)), "System Migration", 2, null, null },
                    { 1, 2, new DateTimeOffset(new DateTime(2023, 5, 22, 14, 34, 50, 543, DateTimeKind.Unspecified).AddTicks(7024), new TimeSpan(0, 3, 0, 0, 0)), "System Migration", 3, null, null }
                });

            migrationBuilder.InsertData(
                table: "Lessons",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "InstructorId", "LastModifiedAt", "LastModifiedBy", "LessonStatus", "ReviewId", "StartTime", "StudentId" },
                values: new object[,]
                {
                    { 1, new DateTimeOffset(new DateTime(2023, 5, 22, 11, 34, 50, 545, DateTimeKind.Unspecified).AddTicks(6944), new TimeSpan(0, 0, 0, 0, 0)), "System Seeding", 1, null, null, 0, null, new DateTimeOffset(new DateTime(2023, 7, 25, 10, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 1 },
                    { 2, new DateTimeOffset(new DateTime(2023, 5, 22, 11, 34, 50, 545, DateTimeKind.Unspecified).AddTicks(6944), new TimeSpan(0, 0, 0, 0, 0)), "System Seeding", 2, null, null, 0, null, new DateTimeOffset(new DateTime(2023, 7, 25, 10, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 1 },
                    { 3, new DateTimeOffset(new DateTime(2023, 5, 22, 11, 34, 50, 545, DateTimeKind.Unspecified).AddTicks(6944), new TimeSpan(0, 0, 0, 0, 0)), "System Seeding", 1, null, null, 0, null, new DateTimeOffset(new DateTime(2023, 7, 25, 10, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 2 }
                });

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
                name: "Users");

            migrationBuilder.DropTable(
                name: "Role");
        }
    }
}
