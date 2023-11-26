using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexerStudy
{
    internal delegate void DelSample(int r);  
    internal class DelegateExample
    {
        internal delegate int DelSample2(int a, int y);
      public void Add(int x)
        {
            Console.WriteLine(x+10);
        }

        public void Sub(int x)
        {
            Console.WriteLine(100-x);
        }

        public void M3(int x, int y)
        {
           Console.WriteLine(x+y);

            return x + y;
        }
    }
}
