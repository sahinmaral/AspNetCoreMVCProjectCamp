using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccess.Migrations
{
    public partial class addedlanguagetoentities : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NotificationInformationLanguage",
                table: "NotificationInformations");

            migrationBuilder.CreateTable(
                name: "Languages",
                columns: table => new
                {
                    LanguageId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LanguageName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LanguageShortName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Languages", x => x.LanguageId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_NotificationInformations_LanguageId",
                table: "NotificationInformations",
                column: "LanguageId");

            migrationBuilder.AddForeignKey(
                name: "FK_NotificationInformations_Languages_LanguageId",
                table: "NotificationInformations",
                column: "LanguageId",
                principalTable: "Languages",
                principalColumn: "LanguageId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_NotificationInformations_Languages_LanguageId",
                table: "NotificationInformations");

            migrationBuilder.DropTable(
                name: "Languages");

            migrationBuilder.DropIndex(
                name: "IX_NotificationInformations_LanguageId",
                table: "NotificationInformations");

            migrationBuilder.AddColumn<int>(
                name: "NotificationInformationLanguage",
                table: "NotificationInformations",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
