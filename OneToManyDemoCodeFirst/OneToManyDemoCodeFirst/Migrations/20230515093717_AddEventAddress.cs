using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OneToManyDemoCodeFirst.Migrations
{
    /// <inheritdoc />
    public partial class AddEventAddress : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "EventAddress",
                table: "Event",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EventAddress",
                table: "Event");
        }
    }
}
