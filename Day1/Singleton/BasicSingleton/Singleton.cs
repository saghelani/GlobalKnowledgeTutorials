using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicSingleton
{
    public class Singleton
    {
        private static Singleton singleton = null;

        private static object sharedLock = new object();

        private Singleton()
        {

        }

        public static Singleton GetInstance()
        {

            if (singleton == null)
            {
                lock (sharedLock)
                {
                    if (singleton == null)
                    {
                        singleton = new Singleton();
                    }

                }
            }

            return singleton;
        }

    }
}
