using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace DataAccess.Migrations
{
    public partial class added_database_at_the_postgresql : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "abouts",
                columns: table => new
                {
                    about_id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    about_detail = table.Column<string>(nullable: true),
                    about_image = table.Column<string>(nullable: true),
                    about_map_location = table.Column<string>(nullable: true),
                    about_status = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_abouts", x => x.about_id);
                });

            migrationBuilder.CreateTable(
                name: "categories",
                columns: table => new
                {
                    category_id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    category_name = table.Column<string>(nullable: true),
                    category_description = table.Column<string>(nullable: true),
                    category_status = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_categories", x => x.category_id);
                });

            migrationBuilder.CreateTable(
                name: "contacts",
                columns: table => new
                {
                    contact_id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    contact_name = table.Column<string>(nullable: true),
                    contact_surname = table.Column<string>(nullable: true),
                    contact_mail = table.Column<string>(nullable: true),
                    contact_subject = table.Column<string>(nullable: true),
                    contact_message = table.Column<string>(nullable: true),
                    contact_created_date = table.Column<DateTime>(nullable: false),
                    contact_status = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_contacts", x => x.contact_id);
                });

            migrationBuilder.CreateTable(
                name: "newsletters",
                columns: table => new
                {
                    newsletter_id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    newsletter_mail = table.Column<string>(nullable: true),
                    newsletter_status = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_newsletters", x => x.newsletter_id);
                });

            migrationBuilder.CreateTable(
                name: "writers",
                columns: table => new
                {
                    writer_id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    writer_username = table.Column<string>(nullable: true),
                    writer_name = table.Column<string>(nullable: true),
                    writer_surname = table.Column<string>(nullable: true),
                    writer_about = table.Column<string>(nullable: true),
                    writer_image = table.Column<string>(nullable: true),
                    writer_mail = table.Column<string>(nullable: true),
                    writer_password = table.Column<string>(nullable: true),
                    writer_status = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_writers", x => x.writer_id);
                });

            migrationBuilder.CreateTable(
                name: "blogs",
                columns: table => new
                {
                    blog_id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    blog_title = table.Column<string>(nullable: true),
                    blog_content = table.Column<string>(nullable: true),
                    blog_thumbnail_image = table.Column<string>(nullable: true),
                    blog_main_image = table.Column<string>(nullable: true),
                    blog_created_date = table.Column<DateTime>(nullable: false),
                    blog_status = table.Column<bool>(nullable: false),
                    category_id = table.Column<int>(nullable: false),
                    writer_id = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_blogs", x => x.blog_id);
                    table.ForeignKey(
                        name: "FK_blogs_categories_category_id",
                        column: x => x.category_id,
                        principalTable: "categories",
                        principalColumn: "category_id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_blogs_writers_writer_id",
                        column: x => x.writer_id,
                        principalTable: "writers",
                        principalColumn: "writer_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "comments",
                columns: table => new
                {
                    comment_id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    comment_about = table.Column<string>(nullable: true),
                    comment_created_date = table.Column<DateTime>(nullable: false),
                    comment_status = table.Column<bool>(nullable: false),
                    blog_id = table.Column<int>(nullable: false),
                    writer_id = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_comments", x => x.comment_id);
                    table.ForeignKey(
                        name: "FK_comments_blogs_blog_id",
                        column: x => x.blog_id,
                        principalTable: "blogs",
                        principalColumn: "blog_id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_comments_writers_writer_id",
                        column: x => x.writer_id,
                        principalTable: "writers",
                        principalColumn: "writer_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_blogs_category_id",
                table: "blogs",
                column: "category_id");

            migrationBuilder.CreateIndex(
                name: "IX_blogs_writer_id",
                table: "blogs",
                column: "writer_id");

            migrationBuilder.CreateIndex(
                name: "IX_comments_blog_id",
                table: "comments",
                column: "blog_id");

            migrationBuilder.CreateIndex(
                name: "IX_comments_writer_id",
                table: "comments",
                column: "writer_id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "abouts");

            migrationBuilder.DropTable(
                name: "comments");

            migrationBuilder.DropTable(
                name: "contacts");

            migrationBuilder.DropTable(
                name: "newsletters");

            migrationBuilder.DropTable(
                name: "blogs");

            migrationBuilder.DropTable(
                name: "categories");

            migrationBuilder.DropTable(
                name: "writers");
        }
    }
}
