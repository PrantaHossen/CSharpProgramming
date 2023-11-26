using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppFmPro
{
    internal class Sample
    {
        internal void Summation(params int[] info)
        {
            int sum = 0, count = 0;

            while (count < info.Length)
            {
                sum += info[count];
                count++;
            }
            Console.WriteLine("{0}", sum);

        }
    }

    internal void Swap(int a ,int b)
    {

    }
}
