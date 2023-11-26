using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyManagement
{
    internal class ITExecutive : FullTime
    {
        double commission;

        internal double Commission
        {
            get { return this.commission; }
            set { this.commission = value; }
        }
        internal override string Id
        { 
            set
            { 
                base.Id ="I-00"+value; 
            }
        }


        internal ITExecutive(string name, DateTime date, double salary, double bonus,double commision) : base(name, date, salary, bonus)
        {
            this.commission = commision;
        }

        internal override double GrossIncome()
        {
            double netIncome = base.GrossIncome() + commission;
            Console.WriteLine("Gross Income Of IT Executive: {0}",netIncome);
            return netIncome;

        }

        internal override double NetTax()
        {
            double netTax = base.NetTax() * (commission * 0.5);
            Console.WriteLine("Net Tax Of IT Executive: {0}",netTax);
            return netTax;
        }
        internal override void ShowInformation()
        {
            base.ShowInformation();
            Console.WriteLine("Bonus For IT Executive : {0}",this.commission);
        }


    }
}
