
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Management
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee fullTime = new FullTime("123","Burce",new JoiningDate(12,10,2022),55000,"Manager",20000);
            fullTime.ShowInfo();
            Employee partTime = new FullTime("452", "sojol",new JoiningDate(5,6,2022),23000,"Executive",5000);
            partTime.ShowInfo();
        }
    }
}
