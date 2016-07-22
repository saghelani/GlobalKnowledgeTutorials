
using System.Linq;

using BlogModel;
using Repository;

namespace TFSBlogRepository
{
   public interface IBlogRepository : IRepository<Blog>
   {
      IQueryable<Blog> GetBlogPosts( int id );
      IQueryable<Blog> GetBlogs();
   }
}
