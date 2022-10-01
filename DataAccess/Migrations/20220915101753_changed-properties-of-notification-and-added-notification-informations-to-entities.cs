using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccess.Migrations
{
    public partial class changedpropertiesofnotificationandaddednotificationinformationstoentities : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NotificationDetail",
                table: "Notifications");

            migrationBuilder.DropColumn(
                name: "NotificationHeader",
                table: "Notifications");


            migrationBuilder.CreateTable(
                name: "NotificationInformations",
                columns: table => new
                {
                    NotificationInformationsId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NotificationId = table.Column<int>(type: "int", nullable: false),
                    NotificationInformationLanguage = table.Column<int>(type: "int", nullable: false),
                    LanguageId = table.Column<int>(type: "int", nullable: false),
                    NotificationHeader = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NotificationDetail = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NotificationInformations", x => x.NotificationInformationsId);
                    table.ForeignKey(
                        name: "FK_NotificationInformations_Notifications_NotificationId",
                        column: x => x.NotificationId,
                        principalTable: "Notifications",
                        principalColumn: "NotificationId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_NotificationInformations_NotificationId",
                table: "NotificationInformations",
                column: "NotificationId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "NotificationInformations");

            migrationBuilder.AddColumn<string>(
                name: "NotificationDetail",
                table: "Notifications",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NotificationHeader",
                table: "Notifications",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
