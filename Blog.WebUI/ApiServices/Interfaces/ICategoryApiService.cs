using Blog.WebUI.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Blog.WebUI.ApiServices.Interfaces
{
    public interface ICategoryApiService
    {
        Task<List<CategoryListViewModel>> GetAllAsync();
        Task<List<CategoryWithBlogsCountModel>> GetAllWithBlogsCount();
        Task<CategoryListViewModel> GetByIdAsync(int id);
        Task AddAsync(CategoryAddViewModel model);
        Task UpdateAsync(CategoryUpdateViewModel model);
        Task DeleteAsync(int id);
    }
}
