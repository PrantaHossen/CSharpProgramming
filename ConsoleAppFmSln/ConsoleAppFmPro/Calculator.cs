using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppFmPro
{
    internal class Calculator
    {
       internal void Addtion(int x, int y)
        {
            Console.WriteLine("{0}", x+y);
        }

        internal void Addition(int x,int y,int z)
        {
            Console.WriteLine("{0}",x+y+z);
        }

        internal void Addition(int x,int y,int z,int w)
        {
            Console.WriteLine("{0}", x+y+z+w);
        }

        internal void Addition(int x, string r)
        {
            Console.WriteLine("{0}", x+r);
        }

        internal void Addition(string x, int r)
        {
            Console.WriteLine("{0}", x+r);
        }

        internal void Addition(string x, int y, int w)
        {
            Console.WriteLine("{0}", x+y+w);
        }

        internal void Addition()
        {
            Console.WriteLine("5");
        }

        internal void Addition(int[] info)
        {
            int sum=0,count=0;

            while(count<info.Length)
            {
                sum+=info[count];
                count++;
            }
            Console.WriteLine("{0",sum);

        }
    }
}
