using Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace DataAccess
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options)
        {

        }

        public DbSet<Article> Articles { get; set; }
        public DbSet<Topic> Topics { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserDetail> UserDetails { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-U8PCRHO\SQLEXPRESS01; Initial Catalog=MVCBlogDB; Integrated Security=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UserDetail>().Property(a => a.UserFirstName).HasMaxLength(50).IsRequired();
            modelBuilder.Entity<UserDetail>().Property(a => a.UserSurname).HasMaxLength(50).IsRequired();
            modelBuilder.Entity<User>().Property(a => a.UserMail).HasMaxLength(50).IsRequired();
            modelBuilder.Entity<Article>().Property(a => a.ArticleHeading).HasMaxLength(30).IsRequired();
            modelBuilder.Entity<User>().Property(a => a.Password).IsRequired();

            modelBuilder.Entity<User>().HasMany(a => a.Articles).WithOne(b => b.User).HasForeignKey(c => c.UserId).OnDelete(DeleteBehavior.Restrict);
            modelBuilder.Entity<User>().HasMany(a => a.LikedArticles).WithMany(b => b.LikedUsers);

            modelBuilder.Entity<UserDetail>().Ignore(a => a.UserPhoto);
        }
    }
}
