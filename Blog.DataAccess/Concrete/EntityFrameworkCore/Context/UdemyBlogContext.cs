using Blog.DataAccess.Concrete.EntityFrameworkCore.Mapping;
using Blog.Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace Blog.DataAccess.Concrete.EntityFrameworkCore.Context
{
    public class UdemyBlogContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=DESKTOP-KVV1JMS; database=Blog; user id=ebauser; password=3235860;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new AppUserMap());
            modelBuilder.ApplyConfiguration(new BlogMap());
            modelBuilder.ApplyConfiguration(new CategoryMap());
            modelBuilder.ApplyConfiguration(new CategoryBlogMap());
            modelBuilder.ApplyConfiguration(new CommentMap());
        }


        public DbSet<AppUser> AppUsers { get; set; }
        public DbSet<Blog.Entities.Concrete.Blog> Blogs { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<CategoryBlog> CategoryBlogs { get; set; }
        public DbSet<Comment> Comments { get; set; }
    }
}
