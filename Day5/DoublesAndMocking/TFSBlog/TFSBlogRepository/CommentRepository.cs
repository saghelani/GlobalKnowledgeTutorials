
using BlogModel;

namespace TFSBlogRepository
{
   public class CommentRepository : TFSBlogRepository<Comment>, ICommentRepository
   {
      public CommentRepository( string connectionString )
         : base( connectionString )
      {
         //
      }
   }
}
