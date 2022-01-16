using Core.Entities.Concrete;
using Entities.Concrete;

using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concrete
{
    public class Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=SAHINMARAL;Database=CoreBlogDb;Trusted_Connection=True;");
        }

        public DbSet<About> Abouts { get; set; }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Writer> Writers { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<NewsLetter> NewsLetters { get; set; }
        public DbSet<BlogRatio> BlogRatios { get; set; }
        public DbSet<Notification> Notifications { get; set; }
        public DbSet<NotificationSymbol> NotificationSymbols { get; set; }
        public DbSet<NotificationType> NotificationTypes { get; set; }
        public DbSet<Message> Messages { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Admin> Admins { get; set; }
    }
}