using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyManagement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Company.AddEmployee(new PartTime("Einama", new DateTime(2000, 11, 11),17000));
            Company.AddEmployee(new PartTime("Kalifa", new DateTime(1999, 1, 21), 21000));
            Company.AddEmployee(new Manager("Koeal", new DateTime(1995, 12, 3), 85000, 11200,5500));
            Company.AddEmployee(new ITExecutive("Payel", new DateTime(1997, 5, 31),65200,13650,4200));
           

            Company.ShowAll();
            
            Company.Scase();
        }
    }
}
