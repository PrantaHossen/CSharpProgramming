using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyManagement
{
    internal class PartTime : Employee
    {
        internal PartTime(string name,DateTime date,double salary):base(name,date,salary)
        {

        }

        internal override string Id
        {
            set 
            {
                base.Id = "P-00" + value ;
            }
        }

        internal override double GrossIncome()
        {
            double gincome = Salary * 12;
            Console.WriteLine("Gross Income :{0}",gincome);
            return gincome ;
           
        }

        internal override double NetTax()
        {
            double netTax = (Salary * 12) * 0.15;
            Console.WriteLine("Total Tax :{0}",netTax);
            return netTax ;
            
        }
        internal override void ShowInformation()
        {
            base.ShowInformation();
        }
    }
}
