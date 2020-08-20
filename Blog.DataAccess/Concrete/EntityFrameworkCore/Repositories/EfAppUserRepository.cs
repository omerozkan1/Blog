using Blog.DataAccess.Interfaces;
using Blog.Entities.Concrete;

namespace Blog.DataAccess.Concrete.EntityFrameworkCore.Repositories
{
    public class EfAppUserRepository : EfGenericRepository<AppUser>,IAppUserDal
    {
    }
}
