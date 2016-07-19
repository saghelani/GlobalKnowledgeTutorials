using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicSingleton
{
    public abstract class GenericSingleton<T> where T : class
    {
        private static T instance = null;

        public static T GetInstance()
        {
            if (instance == null)
            {
                Activator.CreateInstance(typeof(T), System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance, null, null, System.Globalization.CultureInfo.InvariantCulture); 
            }
            return instance;
        }

    }
}
