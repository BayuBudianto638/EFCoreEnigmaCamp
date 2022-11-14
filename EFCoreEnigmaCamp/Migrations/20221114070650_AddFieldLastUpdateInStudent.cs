using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace EFCoreEnigmaCamp.Migrations
{
    /// <inheritdoc />
    public partial class AddFieldLastUpdateInStudent : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Parents",
                keyColumn: "ParentId",
                keyValue: new Guid("a14420fa-f1e5-4c4f-9a7a-ffb02c83f080"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Parents",
                keyColumn: "ParentId",
                keyValue: new Guid("b8418d6b-073f-4322-b603-2a74eb2b2373"));

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                    { new Guid("a14420fa-f1e5-4c4f-9a7a-ffb02c83f080"), "Konoha", "Hiashi" },
                    { new Guid("b8418d6b-073f-4322-b603-2a74eb2b2373"), "Konoha", "Fugaku" }
                });
        }
    }
}
