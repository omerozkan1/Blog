using Blog.Business.Interfaces;
using Blog.DataAccess.Interfaces;
using Blog.Entities.Concrete;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Blog.Concrete
{
    public class CommentManager : GenericManager<Comment>,ICommentService
    {
      
        private readonly ICommentDal _commentDal;
        public CommentManager(IGenericDal<Comment> genericDal, ICommentDal commentDal) : base(genericDal)
        {
            _commentDal = commentDal;
            
        }

        public Task<List<Comment>> GetAllWithSubCommentsAsync(int blogId, int? parentId)
        {
            return _commentDal.GetAllWithSubCommentsAsync(blogId, parentId);
        }
    }
}
