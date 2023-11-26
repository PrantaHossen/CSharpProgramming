using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product p1 = new Product();
            p1.SetId(1);
            p1.SetName("Mouse");
            p1.SetPrice(32.33);
            p1.SetQuantity(120);
            p1.SetDate(new DateFormate(32,2,2022));
            p1.SetExpDate(new ExpDate(20,5,2030));
            p1.ShowInfo();

            Product p2=new Product(2,"KeyBoard",33.54,22,new DateFormate(23,4,2022),new ExpDate(23,4,2029));
            p2.ShowInfo();

        }
    }
}
