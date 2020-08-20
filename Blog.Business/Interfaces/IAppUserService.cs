using Blog.DTO.DTOs.AppUserDtos;
using Blog.Entities.Concrete;
using System.Threading.Tasks;

namespace Blog.Business.Interfaces
{
    public interface IAppUserService : IGenericService<AppUser>
    {
        Task<AppUser> CheckUserAsync(AppUserLoginDto appUserLoginDto);
        Task<AppUser> FindByNameAsync(string userName);
    }
}
