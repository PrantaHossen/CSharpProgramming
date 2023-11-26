using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexerStudy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DelegateExample d1= new DelegateExample();
            //ds1.Add(5);

            DelSample ds1 = new DelSample(d1.Add);
            ds1(40);

            DelSample ds2 = d1.Sub;
            ds2(5);

            DelSample ds = ds1 + ds2;
            ds(50);

            DelegateExample.DelSample2 dd = d1.M3();
            dd(5, 6);
            /*Generic<int> g1 = new Generic<int>();
            g1.ay = 56;

            Generic<double> g2 = new Generic<double>();
            g2.ay = 1.0;

            Generic<string> g3 = new Generic<string>();
            g3.ay = "Generic";

            Generic<Test> g4 = new Generic<Test>();

            g4.ay = new Test();*/

            //Generic<int,string> g5= new Generic<int,string>();

            /*Test t = new Test();

            t.Bx[0] = 10;
            t.Bx[1] = 20;
            t.Bx[2] = 30;

            foreach(int e in t.Bx)
             {
                Console.WriteLine(e + " ");
                //Console.WriteLine();
            }

            t[0] = 100;//t.cx[0]=100
            t[1] = 200;//t.cx[1]=200*/
        }
    }
}
