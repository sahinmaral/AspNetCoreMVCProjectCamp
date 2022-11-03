using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccess.Migrations
{
    public partial class modified_every_properties_of_entity_by_naming_conventions : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "NotificationTypeName",
                table: "NotificationTypes",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "NotificationTypeId",
                table: "NotificationTypes",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "SymbolName",
                table: "NotificationSymbols",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "NotificationSymbolId",
                table: "NotificationSymbols",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "NotificationStatus",
                table: "Notifications",
                newName: "Status");

            migrationBuilder.RenameColumn(
                name: "NotificationDate",
                table: "Notifications",
                newName: "CreatedAt");

            migrationBuilder.RenameColumn(
                name: "NotificationId",
                table: "Notifications",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "NotificationHeader",
                table: "NotificationInformations",
                newName: "Header");

            migrationBuilder.RenameColumn(
                name: "NotificationDetail",
                table: "NotificationInformations",
                newName: "Detail");

            migrationBuilder.RenameColumn(
                name: "NotificationInformationsId",
                table: "NotificationInformations",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "NewsLetterStatus",
                table: "NewsLetters",
                newName: "Status");

            migrationBuilder.RenameColumn(
                name: "NewsLetterMail",
                table: "NewsLetters",
                newName: "Email");

            migrationBuilder.RenameColumn(
                name: "NewsLetterId",
                table: "NewsLetters",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "MessageSubject",
                table: "Messages",
                newName: "Subject");

            migrationBuilder.RenameColumn(
                name: "MessageOpened",
                table: "Messages",
                newName: "IsMessageOpened");

            migrationBuilder.RenameColumn(
                name: "MessageDetail",
                table: "Messages",
                newName: "Detail");

            migrationBuilder.RenameColumn(
                name: "MessageDateTime",
                table: "Messages",
                newName: "CreatedAt");

            migrationBuilder.RenameColumn(
                name: "MessageId",
                table: "Messages",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "LanguageShortName",
                table: "Languages",
                newName: "ShortName");

            migrationBuilder.RenameColumn(
                name: "LanguageName",
                table: "Languages",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "LanguageId",
                table: "Languages",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "ContactSubject",
                table: "Contacts",
                newName: "Subject");

            migrationBuilder.RenameColumn(
                name: "ContactOpened",
                table: "Contacts",
                newName: "IsOpened");

            migrationBuilder.RenameColumn(
                name: "ContactNameSurname",
                table: "Contacts",
                newName: "NameSurname");

            migrationBuilder.RenameColumn(
                name: "ContactMessage",
                table: "Contacts",
                newName: "Message");

            migrationBuilder.RenameColumn(
                name: "ContactMail",
                table: "Contacts",
                newName: "Email");

            migrationBuilder.RenameColumn(
                name: "ContactCreatedDate",
                table: "Contacts",
                newName: "CreatedAt");

            migrationBuilder.RenameColumn(
                name: "ContactAnswered",
                table: "Contacts",
                newName: "IsAnswered");

            migrationBuilder.RenameColumn(
                name: "ContactId",
                table: "Contacts",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "CommentStatus",
                table: "Comments",
                newName: "Status");

            migrationBuilder.RenameColumn(
                name: "CommentCreatedDate",
                table: "Comments",
                newName: "CreatedAt");

            migrationBuilder.RenameColumn(
                name: "CommentId",
                table: "Comments",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "CategoryStatus",
                table: "Categories",
                newName: "Status");

            migrationBuilder.RenameColumn(
                name: "CategoryName",
                table: "Categories",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "CategoryDescription",
                table: "Categories",
                newName: "Description");

            migrationBuilder.RenameColumn(
                name: "CategoryId",
                table: "Categories",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "BlogTitle",
                table: "Blogs",
                newName: "Title");

            migrationBuilder.RenameColumn(
                name: "BlogThumbnailImage",
                table: "Blogs",
                newName: "ThumbnailImage");

            migrationBuilder.RenameColumn(
                name: "BlogStatus",
                table: "Blogs",
                newName: "Status");

            migrationBuilder.RenameColumn(
                name: "BlogMainImage",
                table: "Blogs",
                newName: "MainImage");

            migrationBuilder.RenameColumn(
                name: "BlogCreatedDate",
                table: "Blogs",
                newName: "CreatedAt");

            migrationBuilder.RenameColumn(
                name: "BlogContent",
                table: "Blogs",
                newName: "Content");

            migrationBuilder.RenameColumn(
                name: "BlogId",
                table: "Blogs",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "BlogRatioId",
                table: "BlogRatios",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "AboutStatus",
                table: "Abouts",
                newName: "Status");

            migrationBuilder.RenameColumn(
                name: "AboutMapLocation",
                table: "Abouts",
                newName: "MapLocation");

            migrationBuilder.RenameColumn(
                name: "AboutImage",
                table: "Abouts",
                newName: "ImageUrl");

            migrationBuilder.RenameColumn(
                name: "AboutDetail",
                table: "Abouts",
                newName: "Detail");

            migrationBuilder.RenameColumn(
                name: "AboutId",
                table: "Abouts",
                newName: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Name",
                table: "NotificationTypes",
                newName: "NotificationTypeName");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "NotificationTypes",
                newName: "NotificationTypeId");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "NotificationSymbols",
                newName: "SymbolName");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "NotificationSymbols",
                newName: "NotificationSymbolId");

            migrationBuilder.RenameColumn(
                name: "Status",
                table: "Notifications",
                newName: "NotificationStatus");

            migrationBuilder.RenameColumn(
                name: "CreatedAt",
                table: "Notifications",
                newName: "NotificationDate");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Notifications",
                newName: "NotificationId");

            migrationBuilder.RenameColumn(
                name: "Header",
                table: "NotificationInformations",
                newName: "NotificationHeader");

            migrationBuilder.RenameColumn(
                name: "Detail",
                table: "NotificationInformations",
                newName: "NotificationDetail");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "NotificationInformations",
                newName: "NotificationInformationsId");

            migrationBuilder.RenameColumn(
                name: "Status",
                table: "NewsLetters",
                newName: "NewsLetterStatus");

            migrationBuilder.RenameColumn(
                name: "Email",
                table: "NewsLetters",
                newName: "NewsLetterMail");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "NewsLetters",
                newName: "NewsLetterId");

            migrationBuilder.RenameColumn(
                name: "Subject",
                table: "Messages",
                newName: "MessageSubject");

            migrationBuilder.RenameColumn(
                name: "IsMessageOpened",
                table: "Messages",
                newName: "MessageOpened");

            migrationBuilder.RenameColumn(
                name: "Detail",
                table: "Messages",
                newName: "MessageDetail");

            migrationBuilder.RenameColumn(
                name: "CreatedAt",
                table: "Messages",
                newName: "MessageDateTime");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Messages",
                newName: "MessageId");

            migrationBuilder.RenameColumn(
                name: "ShortName",
                table: "Languages",
                newName: "LanguageShortName");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Languages",
                newName: "LanguageName");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Languages",
                newName: "LanguageId");

            migrationBuilder.RenameColumn(
                name: "Subject",
                table: "Contacts",
                newName: "ContactSubject");

            migrationBuilder.RenameColumn(
                name: "NameSurname",
                table: "Contacts",
                newName: "ContactNameSurname");

            migrationBuilder.RenameColumn(
                name: "Message",
                table: "Contacts",
                newName: "ContactMessage");

            migrationBuilder.RenameColumn(
                name: "IsOpened",
                table: "Contacts",
                newName: "ContactOpened");

            migrationBuilder.RenameColumn(
                name: "IsAnswered",
                table: "Contacts",
                newName: "ContactAnswered");

            migrationBuilder.RenameColumn(
                name: "Email",
                table: "Contacts",
                newName: "ContactMail");

            migrationBuilder.RenameColumn(
                name: "CreatedAt",
                table: "Contacts",
                newName: "ContactCreatedDate");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Contacts",
                newName: "ContactId");

            migrationBuilder.RenameColumn(
                name: "Status",
                table: "Comments",
                newName: "CommentStatus");

            migrationBuilder.RenameColumn(
                name: "CreatedAt",
                table: "Comments",
                newName: "CommentCreatedDate");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Comments",
                newName: "CommentId");

            migrationBuilder.RenameColumn(
                name: "Status",
                table: "Categories",
                newName: "CategoryStatus");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Categories",
                newName: "CategoryName");

            migrationBuilder.RenameColumn(
                name: "Description",
                table: "Categories",
                newName: "CategoryDescription");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Categories",
                newName: "CategoryId");

            migrationBuilder.RenameColumn(
                name: "Title",
                table: "Blogs",
                newName: "BlogTitle");

            migrationBuilder.RenameColumn(
                name: "ThumbnailImage",
                table: "Blogs",
                newName: "BlogThumbnailImage");

            migrationBuilder.RenameColumn(
                name: "Status",
                table: "Blogs",
                newName: "BlogStatus");

            migrationBuilder.RenameColumn(
                name: "MainImage",
                table: "Blogs",
                newName: "BlogMainImage");

            migrationBuilder.RenameColumn(
                name: "CreatedAt",
                table: "Blogs",
                newName: "BlogCreatedDate");

            migrationBuilder.RenameColumn(
                name: "Content",
                table: "Blogs",
                newName: "BlogContent");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Blogs",
                newName: "BlogId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "BlogRatios",
                newName: "BlogRatioId");

            migrationBuilder.RenameColumn(
                name: "Status",
                table: "Abouts",
                newName: "AboutStatus");

            migrationBuilder.RenameColumn(
                name: "MapLocation",
                table: "Abouts",
                newName: "AboutMapLocation");

            migrationBuilder.RenameColumn(
                name: "ImageUrl",
                table: "Abouts",
                newName: "AboutImage");

            migrationBuilder.RenameColumn(
                name: "Detail",
                table: "Abouts",
                newName: "AboutDetail");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Abouts",
                newName: "AboutId");
        }
    }
}
