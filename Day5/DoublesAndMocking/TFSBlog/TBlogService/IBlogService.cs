
using System.Collections.Generic;
using System.ServiceModel;

using TBlogService.Models;

namespace TBlogService
{
   [ServiceContract]
   public interface IBlogService
   {
      [OperationContract]
      IEnumerable<Blog> GetBlogs();
   }
}
