﻿// <auto-generated />
using System;
using DataAccess.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace DataAccess.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20211009222603_added_database_at_the_postgresql")]
    partial class added_database_at_the_postgresql
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                .HasAnnotation("ProductVersion", "3.1.15")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("Entities.Concrete.About", b =>
                {
                    b.Property<int>("AboutId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("about_id")
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("AboutDetail")
                        .HasColumnName("about_detail")
                        .HasColumnType("text");

                    b.Property<string>("AboutImage")
                        .HasColumnName("about_image")
                        .HasColumnType("text");

                    b.Property<string>("AboutMapLocation")
                        .HasColumnName("about_map_location")
                        .HasColumnType("text");

                    b.Property<bool>("AboutStatus")
                        .HasColumnName("about_status")
                        .HasColumnType("boolean");

                    b.HasKey("AboutId");

                    b.ToTable("abouts");
                });

            modelBuilder.Entity("Entities.Concrete.Blog", b =>
                {
                    b.Property<int>("BlogId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("blog_id")
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("BlogContent")
                        .HasColumnName("blog_content")
                        .HasColumnType("text");

                    b.Property<DateTime>("BlogCreatedDate")
                        .HasColumnName("blog_created_date")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("BlogMainImage")
                        .HasColumnName("blog_main_image")
                        .HasColumnType("text");

                    b.Property<bool>("BlogStatus")
                        .HasColumnName("blog_status")
                        .HasColumnType("boolean");

                    b.Property<string>("BlogThumbnailImage")
                        .HasColumnName("blog_thumbnail_image")
                        .HasColumnType("text");

                    b.Property<string>("BlogTitle")
                        .HasColumnName("blog_title")
                        .HasColumnType("text");

                    b.Property<int>("CategoryId")
                        .HasColumnName("category_id")
                        .HasColumnType("integer");

                    b.Property<int>("WriterId")
                        .HasColumnName("writer_id")
                        .HasColumnType("integer");

                    b.HasKey("BlogId");

                    b.HasIndex("CategoryId");

                    b.HasIndex("WriterId");

                    b.ToTable("blogs");
                });

            modelBuilder.Entity("Entities.Concrete.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("category_id")
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("CategoryDescription")
                        .HasColumnName("category_description")
                        .HasColumnType("text");

                    b.Property<string>("CategoryName")
                        .HasColumnName("category_name")
                        .HasColumnType("text");

                    b.Property<bool>("CategoryStatus")
                        .HasColumnName("category_status")
                        .HasColumnType("boolean");

                    b.HasKey("CategoryId");

                    b.ToTable("categories");
                });

            modelBuilder.Entity("Entities.Concrete.Comment", b =>
                {
                    b.Property<int>("CommentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("comment_id")
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int>("BlogId")
                        .HasColumnName("blog_id")
                        .HasColumnType("integer");

                    b.Property<string>("CommentAbout")
                        .HasColumnName("comment_about")
                        .HasColumnType("text");

                    b.Property<DateTime>("CommentCreatedDate")
                        .HasColumnName("comment_created_date")
                        .HasColumnType("timestamp without time zone");

                    b.Property<bool>("CommentStatus")
                        .HasColumnName("comment_status")
                        .HasColumnType("boolean");

                    b.Property<int>("WriterId")
                        .HasColumnName("writer_id")
                        .HasColumnType("integer");

                    b.HasKey("CommentId");

                    b.HasIndex("BlogId");

                    b.HasIndex("WriterId");

                    b.ToTable("comments");
                });

            modelBuilder.Entity("Entities.Concrete.Contact", b =>
                {
                    b.Property<int>("ContactId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("contact_id")
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<DateTime>("ContactCreatedDate")
                        .HasColumnName("contact_created_date")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("ContactMail")
                        .HasColumnName("contact_mail")
                        .HasColumnType("text");

                    b.Property<string>("ContactMessage")
                        .HasColumnName("contact_message")
                        .HasColumnType("text");

                    b.Property<string>("ContactName")
                        .HasColumnName("contact_name")
                        .HasColumnType("text");

                    b.Property<bool>("ContactStatus")
                        .HasColumnName("contact_status")
                        .HasColumnType("boolean");

                    b.Property<string>("ContactSubject")
                        .HasColumnName("contact_subject")
                        .HasColumnType("text");

                    b.Property<string>("ContactSurname")
                        .HasColumnName("contact_surname")
                        .HasColumnType("text");

                    b.HasKey("ContactId");

                    b.ToTable("contacts");
                });

            modelBuilder.Entity("Entities.Concrete.NewsLetter", b =>
                {
                    b.Property<int>("NewsLetterId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("newsletter_id")
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("NewsLetterMail")
                        .HasColumnName("newsletter_mail")
                        .HasColumnType("text");

                    b.Property<bool>("NewsLetterStatus")
                        .HasColumnName("newsletter_status")
                        .HasColumnType("boolean");

                    b.HasKey("NewsLetterId");

                    b.ToTable("newsletters");
                });

            modelBuilder.Entity("Entities.Concrete.Writer", b =>
                {
                    b.Property<int>("WriterId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("writer_id")
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("WriterAbout")
                        .HasColumnName("writer_about")
                        .HasColumnType("text");

                    b.Property<string>("WriterImage")
                        .HasColumnName("writer_image")
                        .HasColumnType("text");

                    b.Property<string>("WriterMail")
                        .HasColumnName("writer_mail")
                        .HasColumnType("text");

                    b.Property<string>("WriterName")
                        .HasColumnName("writer_name")
                        .HasColumnType("text");

                    b.Property<string>("WriterPassword")
                        .HasColumnName("writer_password")
                        .HasColumnType("text");

                    b.Property<bool>("WriterStatus")
                        .HasColumnName("writer_status")
                        .HasColumnType("boolean");

                    b.Property<string>("WriterSurname")
                        .HasColumnName("writer_surname")
                        .HasColumnType("text");

                    b.Property<string>("WriterUsername")
                        .HasColumnName("writer_username")
                        .HasColumnType("text");

                    b.HasKey("WriterId");

                    b.ToTable("writers");
                });

            modelBuilder.Entity("Entities.Concrete.Blog", b =>
                {
                    b.HasOne("Entities.Concrete.Category", "Category")
                        .WithMany("Blogs")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Entities.Concrete.Writer", "Writer")
                        .WithMany("Blogs")
                        .HasForeignKey("WriterId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Entities.Concrete.Comment", b =>
                {
                    b.HasOne("Entities.Concrete.Blog", "Blog")
                        .WithMany("Comments")
                        .HasForeignKey("BlogId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Entities.Concrete.Writer", "Writer")
                        .WithMany("Comments")
                        .HasForeignKey("WriterId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}