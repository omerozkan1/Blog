using Blog.WebUI.Models;
using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Blog.WebUI.ApiServices.Interfaces
{
    public interface IBlogApiService
    {
        Task<List<BlogListViewModel>> GetAllAsync();
        Task<BlogListViewModel> GetByIdAsync(int id);
        Task<List<BlogListViewModel>> GetAllByCategoryIdAsync(int id);
        Task AddAsync(BlogAddViewModel model);
        Task UpdateAsync(BlogUpdateViewModel model);
        Task DeleteAsync(int id);
        Task<List<CommentListViewModel>> GetCommentsAsync(int blogId, int? parentCommentId);
        Task AddToComment(CommentAddViewModel model);
        Task<List<CategoryListViewModel>> GetCategoriesAsync(int blogId);
        Task<List<BlogListViewModel>> GetLastFiveAsync();
        Task<List<BlogListViewModel>> SearchAsync(string s);
        Task AddToCategoryAsync(CategoryBlogViewModel model);
        Task RemoveFromCategoryAsync(CategoryBlogViewModel model);
    }
}
