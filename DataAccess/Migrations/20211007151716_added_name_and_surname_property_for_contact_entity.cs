using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccess.Migrations
{
    public partial class added_name_and_surname_property_for_contact_entity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ContactUsername",
                table: "Contacts",
                newName: "ContactSurname");

            migrationBuilder.AddColumn<string>(
                name: "ContactName",
                table: "Contacts",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ContactName",
                table: "Contacts");

            migrationBuilder.RenameColumn(
                name: "ContactSurname",
                table: "Contacts",
                newName: "ContactUsername");
        }
    }
}
