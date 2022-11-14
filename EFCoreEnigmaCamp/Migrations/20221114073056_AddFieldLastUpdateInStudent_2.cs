using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace EFCoreEnigmaCamp.Migrations
{
    /// <inheritdoc />
    public partial class AddFieldLastUpdateInStudent2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Parents",
                keyColumn: "ParentId",
                keyValue: new Guid("3c7448f2-e8d9-4116-bf13-fe4c2f549e3e"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Parents",
                keyColumn: "ParentId",
                keyValue: new Guid("5cebf5af-6c5c-4dc8-9ede-0d673b98cca2"));

            migrationBuilder.AddColumn<DateTime>(
                name: "LastUpdate",
                schema: "dbo",
                table: "Students",
                type: "datetime2",
                nullable: false,
                defaultValueSql: "GetDate()");

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "Parents",
                columns: new[] { "ParentId", "Address", "ParentName" },
                values: new object[,]
                {
                    { new Guid("5629edd5-719a-49cb-b43a-032479ceb3c9"), "Konoha", "Fugaku" },
                    { new Guid("836c90ff-da8f-46a5-abd9-e96b7b2fd329"), "Konoha", "Hiashi" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Parents",
                keyColumn: "ParentId",
                keyValue: new Guid("5629edd5-719a-49cb-b43a-032479ceb3c9"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Parents",
                keyColumn: "ParentId",
                keyValue: new Guid("836c90ff-da8f-46a5-abd9-e96b7b2fd329"));

            migrationBuilder.DropColumn(
                name: "LastUpdate",
                schema: "dbo",
                table: "Students");

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "Parents",
                columns: new[] { "ParentId", "Address", "ParentName" },
                values: new object[,]
                {
                    { new Guid("3c7448f2-e8d9-4116-bf13-fe4c2f549e3e"), "Konoha", "Hiashi" },
                    { new Guid("5cebf5af-6c5c-4dc8-9ede-0d673b98cca2"), "Konoha", "Fugaku" }
                });
        }
    }
}
