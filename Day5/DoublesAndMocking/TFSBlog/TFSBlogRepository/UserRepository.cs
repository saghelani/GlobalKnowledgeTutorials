
using BlogModel;

namespace TFSBlogRepository
{
   public class UserRepository : TFSBlogRepository<User>, IUserRepository
   {
      public UserRepository( string connectionString )
         : base( connectionString )
      {
         //
      }
   }
}
