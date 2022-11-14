using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFCoreEnigmaCamp.Migrations
{
    /// <inheritdoc />
    public partial class AddDateofBirthAndGender : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "DoB",
                schema: "dbo",
                table: "Students",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "Gender",
                schema: "dbo",
                table: "Students",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DoB",
                schema: "dbo",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "Gender",
                schema: "dbo",
                table: "Students");
        }
    }
}
