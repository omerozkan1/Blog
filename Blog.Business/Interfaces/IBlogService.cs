using Blog.DTO.DTOs.CategoryBlogDtos;
using Blog.Entities.Concrete;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Blog.Business.Interfaces
{
    public interface IBlogService : IGenericService<Blog.Entities.Concrete.Blog>
    {
        Task<List<Blog.Entities.Concrete.Blog>> GetAllSortedByPostedTimeAsync();
        Task AddToCategoryAsync(CategoryBlogDto categoryBlogDto);
        Task RemoveFromCategoryAsync(CategoryBlogDto categoryBlogDto);
        Task<List<Blog.Entities.Concrete.Blog>> GetAllByCategoryIdAsync(int categoryId);
        Task<List<Category>> GetCategoriesAsync(int blogId);
        Task<List<Blog.Entities.Concrete.Blog>> GetLastFiveAsync();
        Task<List<Blog.Entities.Concrete.Blog>> SearchAsync(string searchString);
    }

    
}
