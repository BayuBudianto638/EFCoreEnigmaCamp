using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFCoreEnigmaCamp.Migrations
{
    /// <inheritdoc />
    public partial class AddTableCoursesRelationToTeacher : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                schema: "dbo",
                table: "Teacher",
                type: "NVarchar(100)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "NVarchar(100",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CoursesCourseId",
                schema: "dbo",
                table: "Teacher",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Courses",
                schema: "dbo",
                columns: table => new
                {
                    CourseId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CourseName = table.Column<string>(type: "NVarchar(200)", nullable: false),
                    TeacherId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Courses", x => x.CourseId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Teacher_CoursesCourseId",
                schema: "dbo",
                table: "Teacher",
                column: "CoursesCourseId");

            migrationBuilder.AddForeignKey(
                name: "FK_Teacher_Courses_CoursesCourseId",
                schema: "dbo",
                table: "Teacher",
                column: "CoursesCourseId",
                principalSchema: "dbo",
                principalTable: "Courses",
                principalColumn: "CourseId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Teacher_Courses_CoursesCourseId",
                schema: "dbo",
                table: "Teacher");

            migrationBuilder.DropTable(
                name: "Courses",
                schema: "dbo");

            migrationBuilder.DropIndex(
                name: "IX_Teacher_CoursesCourseId",
                schema: "dbo",
                table: "Teacher");

            migrationBuilder.DropColumn(
                name: "CoursesCourseId",
                schema: "dbo",
                table: "Teacher");

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                schema: "dbo",
                table: "Teacher",
                type: "NVarchar(100",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "NVarchar(100)",
                oldNullable: true);
        }
    }
}
