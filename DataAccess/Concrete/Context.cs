using Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concrete
{
    public class Context:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=SAHINMARAL;Database=CoreBlogDb;Trusted_Connection=True;");
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<About>().ToTable("abouts");
            modelBuilder.Entity<Blog>().ToTable("blogs");
            modelBuilder.Entity<Writer>().ToTable("writers");
            modelBuilder.Entity<Category>().ToTable("categories");
            modelBuilder.Entity<Comment>().ToTable("comments");
            modelBuilder.Entity<Contact>().ToTable("contacts");
            modelBuilder.Entity<NewsLetter>().ToTable("newsletters");
            modelBuilder.Entity<BlogRatio>().ToTable("blog_ratios");
        }

        public DbSet<About> Abouts { get; set; }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Writer> Writers { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<NewsLetter> NewsLetters { get; set; }
        public DbSet<BlogRatio> BlogRatios { get; set; }
    }
}