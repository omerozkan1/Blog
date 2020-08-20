using System.Threading.Tasks;

namespace Blog.WebUI.ApiServices.Interfaces
{
    public interface IimageApiService
    {
        Task<string> GetBlogImageByIdAsync(int id);
    }
}
