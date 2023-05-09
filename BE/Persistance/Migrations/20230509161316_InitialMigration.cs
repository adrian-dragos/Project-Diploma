using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Persistance.Migrations
{
    /// <inheritdoc />
    public partial class InitialMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                name: "Lessons",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    InstructorId = table.Column<int>(type: "int", nullable: false),
                    StudentId = table.Column<int>(type: "int", nullable: true),
                    StartTime = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    LessonStatus = table.Column<int>(type: "int", nullable: false),
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
                        name: "FK_Lessons_Students_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Students",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "Policy",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "LastModifiedAt", "LastModifiedBy", "Name" },
                values: new object[,]
                {
                    { 1, new DateTimeOffset(new DateTime(2023, 5, 9, 19, 13, 16, 198, DateTimeKind.Unspecified).AddTicks(383), new TimeSpan(0, 3, 0, 0, 0)), "System Migration", null, null, "SeeAllUsers" },
                    { 2, new DateTimeOffset(new DateTime(2023, 5, 9, 19, 13, 16, 198, DateTimeKind.Unspecified).AddTicks(383), new TimeSpan(0, 3, 0, 0, 0)), "System Migration", null, null, "UpdateInstructorProfile" },
                    { 3, new DateTimeOffset(new DateTime(2023, 5, 9, 19, 13, 16, 198, DateTimeKind.Unspecified).AddTicks(383), new TimeSpan(0, 3, 0, 0, 0)), "System Migration", null, null, "UpdateUserProfile" }
                });

            migrationBuilder.InsertData(
                table: "Role",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "LastModifiedAt", "LastModifiedBy", "Name" },
                values: new object[,]
                {
                    { 1, new DateTimeOffset(new DateTime(2023, 5, 9, 19, 13, 16, 198, DateTimeKind.Unspecified).AddTicks(4073), new TimeSpan(0, 3, 0, 0, 0)), "System Migration", null, null, "Administrator" },
                    { 2, new DateTimeOffset(new DateTime(2023, 5, 9, 19, 13, 16, 198, DateTimeKind.Unspecified).AddTicks(4073), new TimeSpan(0, 3, 0, 0, 0)), "System Migration", null, null, "Student" },
                    { 3, new DateTimeOffset(new DateTime(2023, 5, 9, 19, 13, 16, 198, DateTimeKind.Unspecified).AddTicks(4073), new TimeSpan(0, 3, 0, 0, 0)), "System Migration", null, null, "Instructor" }
                });

            migrationBuilder.InsertData(
                table: "PolicyRole",
                columns: new[] { "PolicyId", "RoleId", "CreatedAt", "CreatedBy", "Id", "LastModifiedAt", "LastModifiedBy" },
                values: new object[,]
                {
                    { 1, 1, new DateTimeOffset(new DateTime(2023, 5, 9, 19, 13, 16, 198, DateTimeKind.Unspecified).AddTicks(3455), new TimeSpan(0, 3, 0, 0, 0)), "System Migration", 1, null, null },
                    { 2, 1, new DateTimeOffset(new DateTime(2023, 5, 9, 19, 13, 16, 198, DateTimeKind.Unspecified).AddTicks(3455), new TimeSpan(0, 3, 0, 0, 0)), "System Migration", 2, null, null },
                    { 2, 2, new DateTimeOffset(new DateTime(2023, 5, 9, 19, 13, 16, 198, DateTimeKind.Unspecified).AddTicks(3455), new TimeSpan(0, 3, 0, 0, 0)), "System Migration", 2, null, null },
                    { 3, 3, new DateTimeOffset(new DateTime(2023, 5, 9, 19, 13, 16, 198, DateTimeKind.Unspecified).AddTicks(3455), new TimeSpan(0, 3, 0, 0, 0)), "System Migration", 3, null, null }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "Email", "FirstName", "LastModifiedAt", "LastModifiedBy", "LastName", "Password", "RoleId" },
                values: new object[,]
                {
                    { 1, new DateTimeOffset(new DateTime(2023, 5, 1, 11, 50, 43, 880, DateTimeKind.Unspecified).AddTicks(7923), new TimeSpan(0, 3, 0, 0, 0)), "System Seeding", "Kathy_Cassin17@gmail.com", "Kathy", null, null, "Cassin", "test", 3 },
                    { 2, new DateTimeOffset(new DateTime(2023, 5, 1, 11, 50, 43, 880, DateTimeKind.Unspecified).AddTicks(7923), new TimeSpan(0, 3, 0, 0, 0)), "System Seeding", "Tiffany.Ankunding46@gmail.com", "Tiffany", null, null, "Ankunding", "test", 1 },
                    { 3, new DateTimeOffset(new DateTime(2023, 5, 1, 11, 50, 43, 880, DateTimeKind.Unspecified).AddTicks(7923), new TimeSpan(0, 3, 0, 0, 0)), "System Seeding", "Manuel.Gleason@yahoo.com", "Manuel", null, null, "Gleason", "test", 1 },
                    { 4, new DateTimeOffset(new DateTime(2023, 5, 1, 11, 50, 43, 880, DateTimeKind.Unspecified).AddTicks(7923), new TimeSpan(0, 3, 0, 0, 0)), "System Seeding", "Eduardo.Jacobs33@hotmail.com", "Eduardo", null, null, "Jacobs", "test", 2 },
                    { 5, new DateTimeOffset(new DateTime(2023, 5, 1, 11, 50, 43, 880, DateTimeKind.Unspecified).AddTicks(7923), new TimeSpan(0, 3, 0, 0, 0)), "System Seeding", "Adrian.Runolfsdottir18@yahoo.com", "Adrian", null, null, "Runolfsdottir", "test", 1 },
                    { 6, new DateTimeOffset(new DateTime(2023, 5, 1, 11, 50, 43, 880, DateTimeKind.Unspecified).AddTicks(7923), new TimeSpan(0, 3, 0, 0, 0)), "System Seeding", "Angie.Stoltenberg@yahoo.com", "Angie", null, null, "Stoltenberg", "test", 1 },
                    { 7, new DateTimeOffset(new DateTime(2023, 5, 1, 11, 50, 43, 880, DateTimeKind.Unspecified).AddTicks(7923), new TimeSpan(0, 3, 0, 0, 0)), "System Seeding", "Miriam0@yahoo.com", "Miriam", null, null, "Cremin", "test", 3 },
                    { 8, new DateTimeOffset(new DateTime(2023, 5, 1, 11, 50, 43, 880, DateTimeKind.Unspecified).AddTicks(7923), new TimeSpan(0, 3, 0, 0, 0)), "System Seeding", "Lela19@gmail.com", "Lela", null, null, "Bartell", "test", 2 },
                    { 9, new DateTimeOffset(new DateTime(2023, 5, 1, 11, 50, 43, 880, DateTimeKind.Unspecified).AddTicks(7923), new TimeSpan(0, 3, 0, 0, 0)), "System Seeding", "Carroll_Willms@gmail.com", "Carroll", null, null, "Willms", "test", 1 },
                    { 10, new DateTimeOffset(new DateTime(2023, 5, 1, 11, 50, 43, 880, DateTimeKind.Unspecified).AddTicks(7923), new TimeSpan(0, 3, 0, 0, 0)), "System Seeding", "Dennis.Corwin@yahoo.com", "Dennis", null, null, "Corwin", "test", 3 }
                });

            migrationBuilder.InsertData(
                table: "Instructors",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "IdentityId", "LastModifiedAt", "LastModifiedBy" },
                values: new object[,]
                {
                    { 1, new DateTimeOffset(new DateTime(2023, 5, 9, 16, 13, 16, 197, DateTimeKind.Unspecified).AddTicks(7957), new TimeSpan(0, 0, 0, 0, 0)), "System Seeding", 4, null, null },
                    { 2, new DateTimeOffset(new DateTime(2023, 5, 9, 16, 13, 16, 197, DateTimeKind.Unspecified).AddTicks(7957), new TimeSpan(0, 0, 0, 0, 0)), "System Seeding", 8, null, null }
                });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "IdentityId", "LastModifiedAt", "LastModifiedBy" },
                values: new object[,]
                {
                    { 1, new DateTimeOffset(new DateTime(2023, 5, 9, 16, 13, 16, 198, DateTimeKind.Unspecified).AddTicks(4299), new TimeSpan(0, 0, 0, 0, 0)), "System Seeding", 1, null, null },
                    { 2, new DateTimeOffset(new DateTime(2023, 5, 9, 16, 13, 16, 198, DateTimeKind.Unspecified).AddTicks(4299), new TimeSpan(0, 0, 0, 0, 0)), "System Seeding", 7, null, null }
                });

            migrationBuilder.InsertData(
                table: "Lessons",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "InstructorId", "LastModifiedAt", "LastModifiedBy", "LessonStatus", "StartTime", "StudentId" },
                values: new object[] { 1, new DateTimeOffset(new DateTime(2023, 5, 9, 16, 13, 16, 197, DateTimeKind.Unspecified).AddTicks(9740), new TimeSpan(0, 0, 0, 0, 0)), "System Seeding", 1, null, null, 0, new DateTimeOffset(new DateTime(2023, 7, 25, 10, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 1 });

            migrationBuilder.CreateIndex(
                name: "IX_Instructors_IdentityId",
                table: "Instructors",
                column: "IdentityId");

            migrationBuilder.CreateIndex(
                name: "IX_Lessons_InstructorId",
                table: "Lessons",
                column: "InstructorId");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Lessons");

            migrationBuilder.DropTable(
                name: "PolicyRole");

            migrationBuilder.DropTable(
                name: "Instructors");

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
