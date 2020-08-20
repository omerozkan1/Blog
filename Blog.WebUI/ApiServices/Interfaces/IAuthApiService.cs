using Blog.WebUI.Models;
using System.Threading.Tasks;

namespace Blog.WebUI.ApiServices.Interfaces
{
    public interface IAuthApiService
    {
        Task<bool> SignIn(AppUserLoginViewModel model);
    }
}
