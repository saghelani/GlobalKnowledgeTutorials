
using System.Configuration;

using Microsoft.Practices.Unity;
using Microsoft.Practices.Unity.Configuration;

namespace IoC
{
   public class Container
   {
      private static Container container;

      private readonly IUnityContainer unityContainer = new UnityContainer();

      private Container()
      {
         this.unityContainer.LoadConfiguration();
      }

      public static IUnityContainer Instance
      {
         get
         {
            if ( container == null )
            {
               container = new Container();
            }

            return container.unityContainer;
         }
      }
   }
}
