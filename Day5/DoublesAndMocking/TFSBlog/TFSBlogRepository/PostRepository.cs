
using BlogModel;

namespace TFSBlogRepository
{
   public class PostRepository : TFSBlogRepository<Post>, IPostRepository
   {
      public PostRepository( string connectionString )
         : base( connectionString )
      {
         //
      }
   }
}
