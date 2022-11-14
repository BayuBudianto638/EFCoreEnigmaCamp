using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace EFCoreEnigmaCamp.Migrations
{
    /// <inheritdoc />
    public partial class DataSeedForTeacher : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                schema: "dbo",
                table: "Teacher",
                columns: new[] { "TeacherId", "FirtName", "LastName" },
                values: new object[,]
                {
                    { 1, "Andik", "Rain" },
                    { 2, "Lana", "Rain" },
                    { 3, "Anton", "Medan" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Teacher",
                keyColumn: "TeacherId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Teacher",
                keyColumn: "TeacherId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Teacher",
                keyColumn: "TeacherId",
                keyValue: 3);
        }
    }
}
