using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccess.Migrations
{
    public partial class changed_contact_name_and_surname_to_contactnamesurname_from_contact : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ContactName",
                table: "Contacts");

            migrationBuilder.RenameColumn(
                name: "ContactSurname",
                table: "Contacts",
                newName: "ContactNameSurname");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ContactNameSurname",
                table: "Contacts",
                newName: "ContactSurname");

            migrationBuilder.AddColumn<string>(
                name: "ContactName",
                table: "Contacts",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
