using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OneToManyDemoCodeFirst.Migrations
{
    /// <inheritdoc />
    public partial class DeleteAddedProperties : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "StudentBranch",
                table: "Student");

            migrationBuilder.DropColumn(
                name: "EventAddress",
                table: "Event");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "StudentBranch",
                table: "Student",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "EventAddress",
                table: "Event",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
