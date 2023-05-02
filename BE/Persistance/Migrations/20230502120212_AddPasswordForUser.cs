using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistance.Migrations
{
    /// <inheritdoc />
    public partial class AddPasswordForUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Password",
                table: "Users",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "Password",
                value: "4B9dLkIPOn");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Email", "FirstName", "LastName", "Password" },
                values: new object[] { "John.Bergnaum37@hotmail.com", "John", "Bergnaum", "nou6wpS215" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Email", "FirstName", "LastName", "Password" },
                values: new object[] { "Ora55@gmail.com", "Ora", "Sauer", "zyLtW4OclA" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Email", "FirstName", "LastName", "Password" },
                values: new object[] { "Antoinette93@yahoo.com", "Antoinette", "Dooley", "YY_pAWA1y1" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Email", "FirstName", "LastName", "Password" },
                values: new object[] { "Robin.Nitzsche@yahoo.com", "Robin", "Nitzsche", "uwVCC6wnnE" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Email", "FirstName", "LastName", "Password" },
                values: new object[] { "Rose65@gmail.com", "Rose", "Schiller", "cMZRsxs6Fn" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Email", "FirstName", "LastName", "Password" },
                values: new object[] { "Cynthia.Shields87@hotmail.com", "Cynthia", "Shields", "MQ0N054eBt" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Email", "FirstName", "LastName", "Password" },
                values: new object[] { "Ron_Batz86@yahoo.com", "Ron", "Batz", "GdNM3GB0bc" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Email", "FirstName", "LastName", "Password" },
                values: new object[] { "Herman25@gmail.com", "Herman", "Fahey", "CRHulvzm7K" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Email", "FirstName", "LastName", "Password" },
                values: new object[] { "Jerry.Schowalter82@hotmail.com", "Jerry", "Schowalter", "jPrB4_d_Zb" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Password",
                table: "Users");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "Tiffany.Ankunding46@gmail.com", "Tiffany", "Ankunding" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "Manuel.Gleason@yahoo.com", "Manuel", "Gleason" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "Eduardo.Jacobs33@hotmail.com", "Eduardo", "Jacobs" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "Adrian.Runolfsdottir18@yahoo.com", "Adrian", "Runolfsdottir" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "Angie.Stoltenberg@yahoo.com", "Angie", "Stoltenberg" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "Miriam0@yahoo.com", "Miriam", "Cremin" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "Lela19@gmail.com", "Lela", "Bartell" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "Carroll_Willms@gmail.com", "Carroll", "Willms" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Email", "FirstName", "LastName" },
                values: new object[] { "Dennis.Corwin@yahoo.com", "Dennis", "Corwin" });
        }
    }
}
