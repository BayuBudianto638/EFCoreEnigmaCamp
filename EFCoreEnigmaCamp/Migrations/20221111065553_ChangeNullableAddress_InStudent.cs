using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFCoreEnigmaCamp.Migrations
{
    /// <inheritdoc />
    public partial class ChangeNullableAddressInStudent : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Address",
                schema: "dbo",
                table: "Students",
                type: "Nvarchar(200)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "Nvarchar(200)");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Address",
                schema: "dbo",
                table: "Students",
                type: "Nvarchar(200)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "Nvarchar(200)",
                oldNullable: true);
        }
    }
}
