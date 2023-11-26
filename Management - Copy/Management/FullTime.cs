using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Management
{
    internal class FullTime : Employee
    {
        private double bonus;

        internal double Bonus
        {
            get { return this.bonus; }
            set { this.bonus = value; }
        }

        internal FullTime(string id,string name,JoiningDate joiningDate,double salary,string position,double bonus) : base(id, name, joiningDate, salary, position)
        {
            this.Bonus = bonus;
        }

        protected override double GrossIncome()
        { 
            double tIncome = (Salary * 12) + (Bonus * 2);
            Console.WriteLine("Total Income: {0}",tIncome);
            return tIncome;
        }

        protected override double NetTax()
        {
           double tax = ((Salary * 12) + (Bonus * 2))*.20;
            Console.WriteLine("Net Tax : {0}",tax);
            return tax;
        }
        internal override void ShowInfo()
        {
            base.ShowInfo();
        }
    }
}
