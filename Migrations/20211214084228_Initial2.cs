using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplication3.Migrations
{
    public partial class Initial2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Students_Note_id_note",
                table: "Students");

            migrationBuilder.DropIndex(
                name: "IX_Students_id_note",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "id_note",
                table: "Students");

            migrationBuilder.AddColumn<int>(
                name: "Studentid",
                table: "Note",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "id_student",
                table: "Note",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Note_Studentid",
                table: "Note",
                column: "Studentid");

            migrationBuilder.AddForeignKey(
                name: "FK_Note_Students_Studentid",
                table: "Note",
                column: "Studentid",
                principalTable: "Students",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Note_Students_Studentid",
                table: "Note");

            migrationBuilder.DropIndex(
                name: "IX_Note_Studentid",
                table: "Note");

            migrationBuilder.DropColumn(
                name: "Studentid",
                table: "Note");

            migrationBuilder.DropColumn(
                name: "id_student",
                table: "Note");

            migrationBuilder.AddColumn<int>(
                name: "id_note",
                table: "Students",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Students_id_note",
                table: "Students",
                column: "id_note");

            migrationBuilder.AddForeignKey(
                name: "FK_Students_Note_id_note",
                table: "Students",
                column: "id_note",
                principalTable: "Note",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
