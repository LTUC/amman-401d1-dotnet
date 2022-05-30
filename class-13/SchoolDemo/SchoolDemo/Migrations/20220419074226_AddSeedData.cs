using Microsoft.EntityFrameworkCore.Migrations;

namespace SchoolDemo.Migrations
{
    public partial class AddSeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "id", "Firstname", "LastName" },
                values: new object[,]
                {
                    { 1, "Ahmad", "Almohammad" },
                    { 2, "Sultan", "Kanaan" }
                });

            migrationBuilder.InsertData(
                table: "Technologies",
                columns: new[] { "id", "Name" },
                values: new object[,]
                {
                    { 1, ".NET " },
                    { 2, "Node.js" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Technologies",
                keyColumn: "id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Technologies",
                keyColumn: "id",
                keyValue: 2);
        }
    }
}
