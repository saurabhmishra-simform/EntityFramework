using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OneToManyDemo.Migrations
{
    /// <inheritdoc />
    public partial class addnewfieldupdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "OrderUpdateDate",
                table: "Order",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "OrderUpdateDate",
                table: "Order");
        }
    }
}
