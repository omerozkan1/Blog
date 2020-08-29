using Blog.WebUI.Models;
using System.Threading.Tasks;

namespace Blog.WebUI.ApiServices.Interfaces
{
    public interface INewsApiService
    {
        Task<RemoteNewsApiModel> GetNews();
    }
}
