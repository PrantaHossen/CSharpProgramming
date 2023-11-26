using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppFmPro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculator c =new Calculator();
            c.Addtion(5,8);
            //c.Addtion(3,8,5);
            int[] a1 = { 4,7,5,9,9,6};
            int[] a2 = { 4,7,5,4,9,8};
            //c.Addition(a1);

            Sample s = new Sample();

            //s.Summation(1,2,3,4,5,6,7,8,9);
            int p = 10, q = 20;
            s.Swap(p,q);
        }
    }
}
