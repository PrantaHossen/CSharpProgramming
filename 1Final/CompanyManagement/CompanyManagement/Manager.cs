using System;

namespace CompanyManagement
{
    internal class Manager : FullTime
    {
        private double kpi;
        internal double Kpi
        {
            get { return this.kpi; }
            set { this.kpi = value; }
        }

        internal override string Id
        {
            set
            {
                base.Id = "M-00" + value;
            }
        }

        internal Manager(string name, DateTime date, double salary, double bonus, double kpi) : base(name, date, salary, bonus)
        {
            this.kpi = kpi;
        }
        internal override double GrossIncome()
        {
            double gincome = base.GrossIncome() + kpi;
            Console.WriteLine("Gross Income Of Manager :{0}",gincome);
            return gincome;
        }
        internal override double NetTax()
        {
            double nettax = base.NetTax() + (kpi * 0.03);
            Console.WriteLine("Net Tax of Manager : {0}",nettax);
            return nettax;
        }
        internal override void ShowInformation()
        {
            base.ShowInformation();
            Console.WriteLine("KPI of Manager : {0}",this.kpi);
        }
    }
}
