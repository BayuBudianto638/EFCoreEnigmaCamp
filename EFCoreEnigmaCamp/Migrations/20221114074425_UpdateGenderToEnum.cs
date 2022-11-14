using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace EFCoreEnigmaCamp.Migrations
{
    /// <inheritdoc />
    public partial class UpdateGenderToEnum : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AlterColumn<string>(
                name: "Gender",
                schema: "dbo",
                table: "Students",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(byte),
                oldType: "tinyint",
                oldNullable: true);

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "Parents",
                columns: new[] { "ParentId", "Address", "ParentName" },
                values: new object[,]
                {
                    { new Guid("606ac010-f8e3-4b13-afbc-3dbfd1cac403"), "Konoha", "Fugaku" },
                    { new Guid("667db571-c524-4423-ac8e-3b87079d16f8"), "Konoha", "Hiashi" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Parents",
                keyColumn: "ParentId",
                keyValue: new Guid("606ac010-f8e3-4b13-afbc-3dbfd1cac403"));

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Parents",
                keyColumn: "ParentId",
                keyValue: new Guid("667db571-c524-4423-ac8e-3b87079d16f8"));

            migrationBuilder.AlterColumn<byte>(
                name: "Gender",
                schema: "dbo",
                table: "Students",
                type: "tinyint",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

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
    }
}
