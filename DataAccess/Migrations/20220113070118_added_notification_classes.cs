using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccess.Migrations
{
    public partial class added_notification_classes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_blog_ratios_blogs_BlogId",
                table: "blog_ratios");

            migrationBuilder.DropForeignKey(
                name: "FK_blogs_categories_CategoryId",
                table: "blogs");

            migrationBuilder.DropForeignKey(
                name: "FK_blogs_writers_WriterId",
                table: "blogs");

            migrationBuilder.DropForeignKey(
                name: "FK_comments_blogs_BlogId",
                table: "comments");

            migrationBuilder.DropForeignKey(
                name: "FK_comments_writers_WriterId",
                table: "comments");

            migrationBuilder.DropPrimaryKey(
                name: "PK_writers",
                table: "writers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_newsletters",
                table: "newsletters");

            migrationBuilder.DropPrimaryKey(
                name: "PK_contacts",
                table: "contacts");

            migrationBuilder.DropPrimaryKey(
                name: "PK_comments",
                table: "comments");

            migrationBuilder.DropPrimaryKey(
                name: "PK_categories",
                table: "categories");

            migrationBuilder.DropPrimaryKey(
                name: "PK_blogs",
                table: "blogs");

            migrationBuilder.DropPrimaryKey(
                name: "PK_abouts",
                table: "abouts");

            migrationBuilder.DropPrimaryKey(
                name: "PK_blog_ratios",
                table: "blog_ratios");

            migrationBuilder.RenameTable(
                name: "writers",
                newName: "Writers");

            migrationBuilder.RenameTable(
                name: "newsletters",
                newName: "NewsLetters");

            migrationBuilder.RenameTable(
                name: "contacts",
                newName: "Contacts");

            migrationBuilder.RenameTable(
                name: "comments",
                newName: "Comments");

            migrationBuilder.RenameTable(
                name: "categories",
                newName: "Categories");

            migrationBuilder.RenameTable(
                name: "blogs",
                newName: "Blogs");

            migrationBuilder.RenameTable(
                name: "abouts",
                newName: "Abouts");

            migrationBuilder.RenameTable(
                name: "blog_ratios",
                newName: "BlogRatios");

            migrationBuilder.RenameIndex(
                name: "IX_comments_WriterId",
                table: "Comments",
                newName: "IX_Comments_WriterId");

            migrationBuilder.RenameIndex(
                name: "IX_comments_BlogId",
                table: "Comments",
                newName: "IX_Comments_BlogId");

            migrationBuilder.RenameIndex(
                name: "IX_blogs_WriterId",
                table: "Blogs",
                newName: "IX_Blogs_WriterId");

            migrationBuilder.RenameIndex(
                name: "IX_blogs_CategoryId",
                table: "Blogs",
                newName: "IX_Blogs_CategoryId");

            migrationBuilder.RenameIndex(
                name: "IX_blog_ratios_BlogId",
                table: "BlogRatios",
                newName: "IX_BlogRatios_BlogId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Writers",
                table: "Writers",
                column: "WriterId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_NewsLetters",
                table: "NewsLetters",
                column: "NewsLetterId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Contacts",
                table: "Contacts",
                column: "ContactId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Comments",
                table: "Comments",
                column: "CommentId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Categories",
                table: "Categories",
                column: "CategoryId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Blogs",
                table: "Blogs",
                column: "BlogId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Abouts",
                table: "Abouts",
                column: "AboutId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_BlogRatios",
                table: "BlogRatios",
                column: "BlogRatioId");

            migrationBuilder.CreateTable(
                name: "NotificationSymbols",
                columns: table => new
                {
                    NotificationSymbolId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SymbolName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NotificationSymbols", x => x.NotificationSymbolId);
                });

            migrationBuilder.CreateTable(
                name: "NotificationTypes",
                columns: table => new
                {
                    NotificationTypeId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NotificationTypeName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NotificationTypes", x => x.NotificationTypeId);
                });

            migrationBuilder.CreateTable(
                name: "Notifications",
                columns: table => new
                {
                    NotificationId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NotificationTypeId = table.Column<int>(nullable: false),
                    NotificationSymbolId = table.Column<int>(nullable: false),
                    NotificationDetail = table.Column<string>(nullable: true),
                    NotificationStatus = table.Column<bool>(nullable: false),
                    NotificationDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Notifications", x => x.NotificationId);
                    table.ForeignKey(
                        name: "FK_Notifications_NotificationSymbols_NotificationSymbolId",
                        column: x => x.NotificationSymbolId,
                        principalTable: "NotificationSymbols",
                        principalColumn: "NotificationSymbolId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Notifications_NotificationTypes_NotificationTypeId",
                        column: x => x.NotificationTypeId,
                        principalTable: "NotificationTypes",
                        principalColumn: "NotificationTypeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Notifications_NotificationSymbolId",
                table: "Notifications",
                column: "NotificationSymbolId");

            migrationBuilder.CreateIndex(
                name: "IX_Notifications_NotificationTypeId",
                table: "Notifications",
                column: "NotificationTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_BlogRatios_Blogs_BlogId",
                table: "BlogRatios",
                column: "BlogId",
                principalTable: "Blogs",
                principalColumn: "BlogId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Blogs_Categories_CategoryId",
                table: "Blogs",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "CategoryId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Blogs_Writers_WriterId",
                table: "Blogs",
                column: "WriterId",
                principalTable: "Writers",
                principalColumn: "WriterId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_Blogs_BlogId",
                table: "Comments",
                column: "BlogId",
                principalTable: "Blogs",
                principalColumn: "BlogId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_Writers_WriterId",
                table: "Comments",
                column: "WriterId",
                principalTable: "Writers",
                principalColumn: "WriterId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BlogRatios_Blogs_BlogId",
                table: "BlogRatios");

            migrationBuilder.DropForeignKey(
                name: "FK_Blogs_Categories_CategoryId",
                table: "Blogs");

            migrationBuilder.DropForeignKey(
                name: "FK_Blogs_Writers_WriterId",
                table: "Blogs");

            migrationBuilder.DropForeignKey(
                name: "FK_Comments_Blogs_BlogId",
                table: "Comments");

            migrationBuilder.DropForeignKey(
                name: "FK_Comments_Writers_WriterId",
                table: "Comments");

            migrationBuilder.DropTable(
                name: "Notifications");

            migrationBuilder.DropTable(
                name: "NotificationSymbols");

            migrationBuilder.DropTable(
                name: "NotificationTypes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Writers",
                table: "Writers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_NewsLetters",
                table: "NewsLetters");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Contacts",
                table: "Contacts");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Comments",
                table: "Comments");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Categories",
                table: "Categories");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Blogs",
                table: "Blogs");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Abouts",
                table: "Abouts");

            migrationBuilder.DropPrimaryKey(
                name: "PK_BlogRatios",
                table: "BlogRatios");

            migrationBuilder.RenameTable(
                name: "Writers",
                newName: "writers");

            migrationBuilder.RenameTable(
                name: "NewsLetters",
                newName: "newsletters");

            migrationBuilder.RenameTable(
                name: "Contacts",
                newName: "contacts");

            migrationBuilder.RenameTable(
                name: "Comments",
                newName: "comments");

            migrationBuilder.RenameTable(
                name: "Categories",
                newName: "categories");

            migrationBuilder.RenameTable(
                name: "Blogs",
                newName: "blogs");

            migrationBuilder.RenameTable(
                name: "Abouts",
                newName: "abouts");

            migrationBuilder.RenameTable(
                name: "BlogRatios",
                newName: "blog_ratios");

            migrationBuilder.RenameIndex(
                name: "IX_Comments_WriterId",
                table: "comments",
                newName: "IX_comments_WriterId");

            migrationBuilder.RenameIndex(
                name: "IX_Comments_BlogId",
                table: "comments",
                newName: "IX_comments_BlogId");

            migrationBuilder.RenameIndex(
                name: "IX_Blogs_WriterId",
                table: "blogs",
                newName: "IX_blogs_WriterId");

            migrationBuilder.RenameIndex(
                name: "IX_Blogs_CategoryId",
                table: "blogs",
                newName: "IX_blogs_CategoryId");

            migrationBuilder.RenameIndex(
                name: "IX_BlogRatios_BlogId",
                table: "blog_ratios",
                newName: "IX_blog_ratios_BlogId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_writers",
                table: "writers",
                column: "WriterId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_newsletters",
                table: "newsletters",
                column: "NewsLetterId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_contacts",
                table: "contacts",
                column: "ContactId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_comments",
                table: "comments",
                column: "CommentId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_categories",
                table: "categories",
                column: "CategoryId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_blogs",
                table: "blogs",
                column: "BlogId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_abouts",
                table: "abouts",
                column: "AboutId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_blog_ratios",
                table: "blog_ratios",
                column: "BlogRatioId");

            migrationBuilder.AddForeignKey(
                name: "FK_blog_ratios_blogs_BlogId",
                table: "blog_ratios",
                column: "BlogId",
                principalTable: "blogs",
                principalColumn: "BlogId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_blogs_categories_CategoryId",
                table: "blogs",
                column: "CategoryId",
                principalTable: "categories",
                principalColumn: "CategoryId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_blogs_writers_WriterId",
                table: "blogs",
                column: "WriterId",
                principalTable: "writers",
                principalColumn: "WriterId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_comments_blogs_BlogId",
                table: "comments",
                column: "BlogId",
                principalTable: "blogs",
                principalColumn: "BlogId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_comments_writers_WriterId",
                table: "comments",
                column: "WriterId",
                principalTable: "writers",
                principalColumn: "WriterId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
