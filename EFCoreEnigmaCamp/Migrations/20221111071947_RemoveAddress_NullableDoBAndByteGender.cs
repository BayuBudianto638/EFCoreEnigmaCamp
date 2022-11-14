using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFCoreEnigmaCamp.Migrations
{
    /// <inheritdoc />
    public partial class RemoveAddressNullableDoBAndByteGender : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Address",
                schema: "dbo",
                table: "Students");

            migrationBuilder.AlterColumn<byte>(
                name: "Gender",
                schema: "dbo",
                table: "Students",
                type: "tinyint",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DoB",
                schema: "dbo",
                table: "Students",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Gender",
                schema: "dbo",
                table: "Students",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(byte),
                oldType: "tinyint",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DoB",
                schema: "dbo",
                table: "Students",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Address",
                schema: "dbo",
                table: "Students",
                type: "Nvarchar(200)",
                nullable: true);
        }
    }
}
