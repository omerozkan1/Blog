using Blog.DataAccess.Concrete.EntityFrameworkCore.Mapping;
using Blog.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace Blog.DataAccess.Concrete.EntityFrameworkCore.Context
{
    public class UdemyBlogContext : DbContext
    {
        //private readonly IConfiguration _configuration;
        //public UdemyBlogContext(IConfiguration configuration)
        //{
        //    _configuration = configuration;
        //}
        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer(_configuration.GetConnectionString("db1"));
        //}

        public UdemyBlogContext(DbContextOptions<UdemyBlogContext> options):base(options)
        {

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
