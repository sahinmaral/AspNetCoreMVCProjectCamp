using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccess.Migrations
{
    public partial class added_relationship_between_user_and_writer : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "WriterName",
                table: "Writers");

            migrationBuilder.DropColumn(
                name: "WriterPassword",
                table: "Writers");

            migrationBuilder.DropColumn(
                name: "WriterStatus",
                table: "Writers");

            migrationBuilder.DropColumn(
                name: "WriterSurname",
                table: "Writers");

            migrationBuilder.DropColumn(
                name: "WriterUsername",
                table: "Writers");

            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "Writers",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    UserId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Username = table.Column<string>(nullable: true),
                    UserFirstName = table.Column<string>(nullable: true),
                    UserLastName = table.Column<string>(nullable: true),
                    UserPasswordSalt = table.Column<byte[]>(nullable: true),
                    UserPasswordHash = table.Column<byte[]>(nullable: true),
                    Status = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.UserId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Writers_UserId",
                table: "Writers",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Writers_Users_UserId",
                table: "Writers",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Writers_Users_UserId",
                table: "Writers");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Writers_UserId",
                table: "Writers");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Writers");

            migrationBuilder.AddColumn<string>(
                name: "WriterName",
                table: "Writers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "WriterPassword",
                table: "Writers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "WriterStatus",
                table: "Writers",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "WriterSurname",
                table: "Writers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "WriterUsername",
                table: "Writers",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
