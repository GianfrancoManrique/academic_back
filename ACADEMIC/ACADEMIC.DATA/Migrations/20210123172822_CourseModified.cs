using Microsoft.EntityFrameworkCore.Migrations;

namespace ACADEMIC.DATA.Migrations
{
    public partial class CourseModified : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "State",
                table: "Courses",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "State",
                table: "Courses");
        }
    }
}
