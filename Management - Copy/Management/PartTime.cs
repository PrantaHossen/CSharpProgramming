using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Management
{
    internal class PartTime : Employee
    {
        private double commission;

        internal double Commission
        {
            get { return this.commission; }
            set { this.commission = value; }
        }

        internal PartTime(string id,string name,JoiningDate joiningDate,double salary,string position,double comission): base(id,name,joiningDate,salary,position)
        { 
            this.Commission = comission;
        }

        protected override double GrossIncome()
        {
            double tIncome = (Salary * 12) + (Commission);
            return tIncome;
        }


        protected override double NetTax()
        {
            double tax = ((Salary * 12) + (Commission)) * .15;
            Console.WriteLine("Net Tax : {0}", tax);
            return tax;
        }

        internal override void ShowInfo()
        {
            base.ShowInfo();
           
            
        }
    }
}
