using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace OneToManyDemoCodeFirst.Migrations
{
    /// <inheritdoc />
    public partial class AddStudentSeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Student",
                columns: new[] { "StudentId", "Age", "ConfirmPassword", "Date", "Email", "Gender", "Password", "StudentAddress", "StudentName" },
                values: new object[,]
                {
                    { 8, 25, "ramesh@123", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "ramesh@gmail.com", 0, "ramesh@123", "Anand", "Ramesh" },
                    { 9, 27, "ram@123", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "ram@gmail.com", 0, "ram@123", "Lucknow", "Ram" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Student",
                keyColumn: "StudentId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Student",
                keyColumn: "StudentId",
                keyValue: 9);
        }
    }
}
