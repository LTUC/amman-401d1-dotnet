using Microsoft.EntityFrameworkCore.Migrations;

namespace SchoolAPI.Migrations
{
    public partial class FirstMig : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Courses_TechnologyId",
                table: "Courses",
                column: "TechnologyId");

            migrationBuilder.AddForeignKey(
                name: "FK_Courses_Technologies_TechnologyId",
                table: "Courses",
                column: "TechnologyId",
                principalTable: "Technologies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Courses_Technologies_TechnologyId",
                table: "Courses");

            migrationBuilder.DropIndex(
                name: "IX_Courses_TechnologyId",
                table: "Courses");
        }
    }
}
