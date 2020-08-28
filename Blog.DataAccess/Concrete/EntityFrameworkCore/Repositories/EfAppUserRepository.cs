using Blog.DataAccess.Concrete.EntityFrameworkCore.Context;
using Blog.DataAccess.Interfaces;
using Blog.Entities.Concrete;

namespace Blog.DataAccess.Concrete.EntityFrameworkCore.Repositories
{
    public class EfAppUserRepository : EfGenericRepository<AppUser>,IAppUserDal
    {
        private readonly UdemyBlogContext _context;
        public EfAppUserRepository(UdemyBlogContext context) : base(context)
        {
            
        }
    }
}
