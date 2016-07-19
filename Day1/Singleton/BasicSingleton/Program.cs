using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BasicSingleton
{
    class Program
    {
        static void Main(string[] args)
        {
            HighLander sing1 = null;
            HighLander sing2 = null;

            Thread t1 = new Thread(() => sing1 = HighLander.GetInstance());
            Thread t2 = new Thread(() => sing2 = HighLander.GetInstance());

            t1.Start();
            t2.Start();

            t1.Join();
            t2.Join();

            Debug.Assert(object.ReferenceEquals(sing1, sing2));
        }
    }
}
