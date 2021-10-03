using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccess.Migrations
{
    public partial class added_one_to_many_relation_between_comment_and_writer : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CommentUsername",
                table: "Comments");

            migrationBuilder.AddColumn<string>(
                name: "WriterUsername",
                table: "Writers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "WriterId",
                table: "Comments",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Comments_WriterId",
                table: "Comments",
                column: "WriterId");

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_Writers_WriterId",
                table: "Comments",
                column: "WriterId",
                principalTable: "Writers",
                principalColumn: "WriterId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Comments_Writers_WriterId",
                table: "Comments");

            migrationBuilder.DropIndex(
                name: "IX_Comments_WriterId",
                table: "Comments");

            migrationBuilder.DropColumn(
                name: "WriterUsername",
                table: "Writers");

            migrationBuilder.DropColumn(
                name: "WriterId",
                table: "Comments");

            migrationBuilder.AddColumn<string>(
                name: "CommentUsername",
                table: "Comments",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
