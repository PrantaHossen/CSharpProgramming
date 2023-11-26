using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Child : Parent
    {
        internal Child() //: base(11)
        {
            Console.WriteLine("P-C");
        }
        internal Child(int a)//:this()
        {
            Console.WriteLine("P-C={0}",a);
        }

        internal Child(string p)// :this(1)
        {

            Console.WriteLine("C-NDS"+p);
        }

        internal  void MethodA()
        {
            Console.WriteLine("Method A");
        }

        internal override void MethodB()
        {
            Console.WriteLine("Child Method B");
        }
        internal new void MethodC()
        {
            Console.WriteLine("Child Methodc");
        }
    }
}
