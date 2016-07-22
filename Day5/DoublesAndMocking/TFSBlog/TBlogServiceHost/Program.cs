
using System;
using System.Configuration;
using System.ServiceModel;

using Microsoft.Practices.Unity;

using IoC;
using TBlogService;
using TFSBlogRepository;

namespace TBlogServiceHost
{
   class Program
   {
      static void Main( string[] args )
      {
         InjectionConstructor ctor = new InjectionConstructor(
            ConfigurationManager.ConnectionStrings[ "TFSBlogEntities" ].ConnectionString );

         // Container.Instance.RegisterType<IBlogRepository, BlogRepository>( ctor );

         using ( ServiceHost service = new ServiceHost(
            typeof( BlogService ), new Uri( "http://localhost:9000/TBlog" ) ) )
         {
            service.Open();
            Console.WriteLine( "Service started" );
            Console.ReadLine();
         }
      }
   }
}
