﻿using Blog.DataAccess.Concrete.EntityFrameworkCore.Context;
using Blog.DataAccess.Interfaces;
using Blog.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blog.DataAccess.Concrete.EntityFrameworkCore.Repositories
{
    public class EfBlogRepository : EfGenericRepository<Blog.Entities.Concrete.Blog>, IBlogDal
    {
        public async Task<List<Blog.Entities.Concrete.Blog>> GetAllByCategoryIdAsync(int categoryId)
        {
            using var context = new UdemyBlogContext();
            return await context.Blogs.Join(context.CategoryBlogs, b => b.Id, cb => cb.BlogId, (blog, categoryBlog) => new
            {
                blog,
                categoryBlog
            }).Where(I => I.categoryBlog.CategoryId == categoryId).Select(I => new Blog.Entities.Concrete.Blog
            {
                AppUser = I.blog.AppUser,
                AppUserId = I.blog.AppUserId,
                CategoryBlogs = I.blog.CategoryBlogs,
                Comments = I.blog.Comments,
                Description = I.blog.Description,
                Id = I.blog.Id,
                ImagePath = I.blog.ImagePath,
                PostedTime = I.blog.PostedTime,
                ShortDescription = I.blog.ShortDescription,
                Title = I.blog.Title
            }).ToListAsync();
        }

        public async Task<List<Category>> GetCategoriesAsync(int blogId)
        {
            using var context = new UdemyBlogContext();
            return await context.Categories.Join(context.CategoryBlogs, c => c.Id, cb => cb.CategoryId, (category, categoryBlog) => new
            {
                category,
                categoryBlog
            }).Where(I => I.categoryBlog.BlogId == blogId).Select(I => new Category
            {
                Id = I.category.Id,
                Name = I.category.Name
            }).ToListAsync();
        }

        public async Task<List<Blog.Entities.Concrete.Blog>> GetLastFiveAsync()
        {
            using var context = new UdemyBlogContext();
            return await context.Blogs.OrderByDescending(I => I.PostedTime).Take(5).ToListAsync();
        }
    }
}
