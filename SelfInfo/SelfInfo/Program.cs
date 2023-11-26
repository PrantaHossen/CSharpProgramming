using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelfInfo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Type a Name : ");
            string name=Console.ReadLine();
            PersonInfo info = new PersonInfo(123,name,23,"B+",new AddressFormat(21,32,"DHK"));
            info.showPersonInfo();

            AddressFormat a1 = new AddressFormat(12,21,"Dhaka");

            PersonInfo info1 = new PersonInfo(124,"XYZ",32,"A+",a1);
            info1.showPersonInfo();
        }
    }
}
