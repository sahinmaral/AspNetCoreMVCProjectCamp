using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccess.Migrations
{
    public partial class created_database : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "abouts",
                columns: table => new
                {
                    AboutId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AboutDetail = table.Column<string>(nullable: true),
                    AboutImage = table.Column<string>(nullable: true),
                    AboutMapLocation = table.Column<string>(nullable: true),
                    AboutStatus = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_abouts", x => x.AboutId);
                });

            migrationBuilder.CreateTable(
                name: "categories",
                columns: table => new
                {
                    CategoryId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryName = table.Column<string>(nullable: true),
                    CategoryDescription = table.Column<string>(nullable: true),
                    CategoryStatus = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_categories", x => x.CategoryId);
                });

            migrationBuilder.CreateTable(
                name: "contacts",
                columns: table => new
                {
                    ContactId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ContactName = table.Column<string>(nullable: true),
                    ContactSurname = table.Column<string>(nullable: true),
                    ContactMail = table.Column<string>(nullable: true),
                    ContactSubject = table.Column<string>(nullable: true),
                    ContactMessage = table.Column<string>(nullable: true),
                    ContactCreatedDate = table.Column<DateTime>(nullable: false),
                    ContactStatus = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_contacts", x => x.ContactId);
                });

            migrationBuilder.CreateTable(
                name: "newsletters",
                columns: table => new
                {
                    NewsLetterId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NewsLetterMail = table.Column<string>(nullable: true),
                    NewsLetterStatus = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_newsletters", x => x.NewsLetterId);
                });

            migrationBuilder.CreateTable(
                name: "writers",
                columns: table => new
                {
                    WriterId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    WriterUsername = table.Column<string>(nullable: true),
                    WriterName = table.Column<string>(nullable: true),
                    WriterSurname = table.Column<string>(nullable: true),
                    WriterAbout = table.Column<string>(nullable: true),
                    WriterImage = table.Column<string>(nullable: true),
                    WriterMail = table.Column<string>(nullable: true),
                    WriterPassword = table.Column<string>(nullable: true),
                    WriterStatus = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_writers", x => x.WriterId);
                });

            migrationBuilder.CreateTable(
                name: "blogs",
                columns: table => new
                {
                    BlogId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BlogTitle = table.Column<string>(nullable: true),
                    BlogContent = table.Column<string>(nullable: true),
                    BlogThumbnailImage = table.Column<string>(nullable: true),
                    BlogMainImage = table.Column<string>(nullable: true),
                    BlogCreatedDate = table.Column<DateTime>(nullable: false),
                    BlogStatus = table.Column<bool>(nullable: false),
                    CategoryId = table.Column<int>(nullable: false),
                    WriterId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_blogs", x => x.BlogId);
                    table.ForeignKey(
                        name: "FK_blogs_categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "categories",
                        principalColumn: "CategoryId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_blogs_writers_WriterId",
                        column: x => x.WriterId,
                        principalTable: "writers",
                        principalColumn: "WriterId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "blog_ratios",
                columns: table => new
                {
                    BlogRatioId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BlogId = table.Column<int>(nullable: false),
                    LikeRatio = table.Column<decimal>(nullable: false),
                    DislikeRatio = table.Column<decimal>(nullable: false),
                    TotalCommentsCount = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_blog_ratios", x => x.BlogRatioId);
                    table.ForeignKey(
                        name: "FK_blog_ratios_blogs_BlogId",
                        column: x => x.BlogId,
                        principalTable: "blogs",
                        principalColumn: "BlogId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "comments",
                columns: table => new
                {
                    CommentId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CommentAbout = table.Column<string>(nullable: true),
                    CommentCreatedDate = table.Column<DateTime>(nullable: false),
                    CommentStatus = table.Column<bool>(nullable: false),
                    BlogId = table.Column<int>(nullable: false),
                    WriterId = table.Column<int>(nullable: true),
                    LikeOrDislikeStatus = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_comments", x => x.CommentId);
                    table.ForeignKey(
                        name: "FK_comments_blogs_BlogId",
                        column: x => x.BlogId,
                        principalTable: "blogs",
                        principalColumn: "BlogId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_comments_writers_WriterId",
                        column: x => x.WriterId,
                        principalTable: "writers",
                        principalColumn: "WriterId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_blog_ratios_BlogId",
                table: "blog_ratios",
                column: "BlogId");

            migrationBuilder.CreateIndex(
                name: "IX_blogs_CategoryId",
                table: "blogs",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_blogs_WriterId",
                table: "blogs",
                column: "WriterId");

            migrationBuilder.CreateIndex(
                name: "IX_comments_BlogId",
                table: "comments",
                column: "BlogId");

            migrationBuilder.CreateIndex(
                name: "IX_comments_WriterId",
                table: "comments",
                column: "WriterId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "abouts");

            migrationBuilder.DropTable(
                name: "blog_ratios");

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
