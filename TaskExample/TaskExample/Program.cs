using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskExample
{
    enum Week : sbyte 
    {
        Sat=20,
        Sun=70,
        Mon=-90
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Sample s= new Sample();

            int g = Sample.b;
            int y = s.c;

            Console.WriteLine("{0}",Week.Sun);

            int w= (int)Week.Sun;
            Console.WriteLine("{0}",w);
        }
    }
}
