using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFCoreEnigmaCamp.Migrations
{
    /// <inheritdoc />
    public partial class RevisedRelation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Teacher_Courses_CoursesCourseId",
                schema: "dbo",
                table: "Teacher");

            migrationBuilder.DropIndex(
                name: "IX_Teacher_CoursesCourseId",
                schema: "dbo",
                table: "Teacher");

            migrationBuilder.DropColumn(
                name: "CoursesCourseId",
                schema: "dbo",
                table: "Teacher");

            migrationBuilder.CreateIndex(
                name: "IX_Courses_TeacherId",
                schema: "dbo",
                table: "Courses",
                column: "TeacherId");

            migrationBuilder.AddForeignKey(
                name: "FK_Courses_Teacher_TeacherId",
                schema: "dbo",
                table: "Courses",
                column: "TeacherId",
                principalSchema: "dbo",
                principalTable: "Teacher",
                principalColumn: "TeacherId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Courses_Teacher_TeacherId",
                schema: "dbo",
                table: "Courses");

            migrationBuilder.DropIndex(
                name: "IX_Courses_TeacherId",
                schema: "dbo",
                table: "Courses");

            migrationBuilder.AddColumn<int>(
                name: "CoursesCourseId",
                schema: "dbo",
                table: "Teacher",
                type: "int",
                nullable: false,
                defaultValue: 0);

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
    }
}
