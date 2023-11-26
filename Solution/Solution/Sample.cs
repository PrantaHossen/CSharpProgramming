using System;

namespace Solution
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

        internal void Swap(int a, int b)
        {
            int t = a;
            a = b;
            b = t;

            Console.WriteLine("{0} , {1}", a, b);
        }

        internal void M1(out int k)
        {
            k = 8;
        }

        internal void M2(int a, string b, double[] t, ref byte d, out bool q, decimal[] n, params long[] l)
        {
            q = true;
        }

        internal void M3(byte a, byte b, byte c = 3)
        {
            Console.WriteLine("{0} {1} {2}", a, b, c);

        }

        internal void M4(byte x,byte y,byte z)
        {
            Console.WriteLine("{0} {1} {2}", x, y, z);
        }
    }



}
