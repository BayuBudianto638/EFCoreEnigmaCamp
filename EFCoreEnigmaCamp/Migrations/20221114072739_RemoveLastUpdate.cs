using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace EFCoreEnigmaCamp.Migrations
{
    /// <inheritdoc />
    public partial class RemoveLastUpdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Parents",
                keyColumn: "ParentId",
                keyValue: new Guid("84e7e914-519f-4aff-8975-0775bb1e83f8"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Parents",
                keyColumn: "ParentId",
                keyValue: new Guid("a85fd955-bd04-48d7-af54-d66c0a160288"));

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "Parents",
                columns: new[] { "ParentId", "Address", "ParentName" },
                values: new object[,]
                {
                    { new Guid("84e7e914-519f-4aff-8975-0775bb1e83f8"), "Konoha", "Fugaku" },
                    { new Guid("a85fd955-bd04-48d7-af54-d66c0a160288"), "Konoha", "Hiashi" }
                });
        }
    }
}
