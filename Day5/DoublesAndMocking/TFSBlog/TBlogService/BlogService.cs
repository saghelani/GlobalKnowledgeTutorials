
using System.Collections.Generic;
using System.Configuration;

using Microsoft.Practices.Unity;

using IoC;
using TBlogService.Models;
using TFSBlogRepository;

namespace TBlogService
{
   public class BlogService : IBlogService
   {
      private IBlogRepository repository;

      // public BlogService() : this( new BlogRepository(
      //       ConfigurationManager.ConnectionStrings[ "TFSBlogEntities" ].ConnectionString ) )
      // {
      //    //
      // }

      public BlogService() : this( Container.Instance.Resolve<IBlogRepository>() )
      {
         //
      }

      public BlogService( IBlogRepository repository )
      {
         this.repository = repository;
      }

      public IEnumerable<Blog> GetBlogs()
      {
         // string connectionString =
         //    ConfigurationManager.ConnectionStrings[ "TFSBlogEntities" ].ConnectionString;
         // IBlogRepository repository = new BlogRepository( connectionString );

         Blogs blogFactory = new Blogs();
         IEnumerable<Blog> blogs = blogFactory.GetBlogs( this.repository, 10, 1 );

         return blogs;
      }
   }
}
