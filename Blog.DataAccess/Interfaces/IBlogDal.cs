using Blog.Entities.Concrete;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Blog.DataAccess.Interfaces
{
    public interface IBlogDal : IGenericDal<Blog.Entities.Concrete.Blog>
    {
        Task<List<Blog.Entities.Concrete.Blog>> GetAllByCategoryIdAsync(int categoryId);
        Task<List<Category>> GetCategoriesAsync(int blogId);
        Task<List<Blog.Entities.Concrete.Blog>> GetLastFiveAsync();
    }
}
