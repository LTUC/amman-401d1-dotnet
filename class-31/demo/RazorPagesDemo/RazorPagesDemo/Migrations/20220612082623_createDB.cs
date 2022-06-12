using Microsoft.EntityFrameworkCore.Migrations;

namespace RazorPagesDemo.Migrations
{
    public partial class createDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "people",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Age = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_people", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "people",
                columns: new[] { "Id", "Age", "Name" },
                values: new object[,]
                {
                    { 1, 25, "Hanan" },
                    { 2, 29, "Yahia" },
                    { 3, 31, "Ola" },
                    { 4, 35, "Bashar" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "people");
        }
    }
}
