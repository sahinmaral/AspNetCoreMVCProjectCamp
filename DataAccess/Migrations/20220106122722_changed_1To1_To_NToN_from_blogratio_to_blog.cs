using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccess.Migrations
{
    public partial class changed_1To1_To_NToN_from_blogratio_to_blog : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_blog_ratios_BlogId",
                table: "blog_ratios");

            migrationBuilder.CreateIndex(
                name: "IX_blog_ratios_BlogId",
                table: "blog_ratios",
                column: "BlogId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_blog_ratios_BlogId",
                table: "blog_ratios");

            migrationBuilder.CreateIndex(
                name: "IX_blog_ratios_BlogId",
                table: "blog_ratios",
                column: "BlogId");
        }
    }
}
