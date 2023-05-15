using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OneToManyDemoCodeFirst.Migrations
{
    /// <inheritdoc />
    public partial class AddStudentBranchAgain : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "StudentBranch",
                table: "Student",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "StudentBranch",
                table: "Student");
        }
    }
}
