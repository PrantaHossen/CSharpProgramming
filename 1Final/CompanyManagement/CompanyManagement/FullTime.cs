using System;
using System.Media;

namespace CompanyManagement
{
    internal class FullTime : Employee
    {
        double bonus;
        internal double Bonus
        {
            get { return bonus; }
            set
            {
                if (value > 0)
                {
                    this.bonus = value;
                }
                else
                    this.bonus = -1;
            }
        }
        internal override string Id
        {
            set { base.Id = value; }
        }

        internal FullTime(string name, DateTime date, double salary, double bonus) : base(name,date,salary)
        {
            this.Bonus=bonus;
        }

        internal override double GrossIncome()
        {
            double gincome = (Salary * 12) + bonus;
            return gincome;
        }

        internal override double NetTax()
        {
            double nettax = (Salary * 12) * 0.10 + (bonus*.02);
            return nettax;
        }

        internal override void ShowInformation()
        {
            base.ShowInformation();
           
        }
    }

}
