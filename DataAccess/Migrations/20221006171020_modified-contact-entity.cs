using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccess.Migrations
{
    public partial class modifiedcontactentity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ContactStatus",
                table: "Contacts",
                newName: "ContactOpened");

            migrationBuilder.AddColumn<bool>(
                name: "ContactAnswered",
                table: "Contacts",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ContactAnswered",
                table: "Contacts");

            migrationBuilder.RenameColumn(
                name: "ContactOpened",
                table: "Contacts",
                newName: "ContactStatus");
        }
    }
}
