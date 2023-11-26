using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Parent
    {
        internal Parent()//:this(" Hello") 
        {
            Console.WriteLine("P-D");
        }
        internal Parent(int a )//:this()
        {
            Console.WriteLine("P-NDI "+a);
        }

        internal Parent(string w)
        {
            Console.WriteLine("P-NDS"+w);
        }

        internal  void MethodA()
        {
            Console.WriteLine("Method P");
        }

        internal virtual void MethodB()
        {
            Console.WriteLine("Method B");
        }
        internal virtual void MethodC()
        {
            Console.WriteLine("Method C");
        }
    }
}
