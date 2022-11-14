using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace EFCoreEnigmaCamp.Migrations
{
    /// <inheritdoc />
    public partial class GuidInEFCore : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Parents",
                schema: "dbo",
                columns: table => new
                {
                    ParentId = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "NEWID()"),
                    ParentName = table.Column<string>(type: "NVarchar(200)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Parents", x => x.ParentId);
                });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Parents",
                schema: "dbo");
        }
    }
}
