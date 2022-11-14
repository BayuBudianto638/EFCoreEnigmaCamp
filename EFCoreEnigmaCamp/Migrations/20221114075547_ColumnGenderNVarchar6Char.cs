using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace EFCoreEnigmaCamp.Migrations
{
    /// <inheritdoc />
    public partial class ColumnGenderNVarchar6Char : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
          migrationBuilder.AlterColumn<string>(
              name: "Gender",
              schema: "dbo",
              table: "Students",
              type: "Nvarchar(6)",
              nullable: false,
              oldClrType: typeof(string),
              oldType: "nvarchar(max)");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {           
            migrationBuilder.AlterColumn<string>(
                name: "Gender",
                schema: "dbo",
                table: "Students",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "Nvarchar(6)");
        }
    }
}
