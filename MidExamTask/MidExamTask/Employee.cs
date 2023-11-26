using System;

namespace MidExamTask
{
    internal class JoiningDate
    {
        private int day;
        private int month;
        private int year;

        internal int Day
        {
            get { return this.day; }
            set
            {
                if (value <= 31 && value > 0)
                {
                    this.day = value;
                }
                else
                {
                    this.day = -1;
                }
            }
        }
        internal int Month
        {
            get { return this.month; }
            set
            {
                if (value <= 12 && value > 0)
                {
                    this.month = value;
                }
                else
                {
                    this.month = -1;
                }
            }
        }
        internal int Year
        {
            get { return this.year; }
            set
            {
                if (value <= 2022 && value > 0)
                {
                    this.year = value;
                }
                else
                {
                    this.year = -1;
                }
            }
        }

        internal JoiningDate(int day, int month, int year)
        {
            this.day = day;
            this.month = month;
            this.year = year;
        }

        internal void ShowJoiningDate()
        {
            Console.WriteLine("Joining Date : {0}-{1}-{2}", this.day, this.month, this.year);

        }
    }

    internal class Employee : Person
    {
        private string companyName;
        private double salary;
        JoiningDate jDate;
        //double bonus;

       /* internal double Bonus
        {
            get { return this.bonus; }
            set { this.bonus = value; }
        }*/

        internal double Bonus { get; set; }

        internal string CompanyName
        {
            get { return this.companyName; }
            set { this.companyName = value; }
        }
        internal double Salary
        {
            get { return this.salary; }
            set
            {
                if (value > 0)
                {
                    this.salary = value;
                }
                else
                {
                    this.salary = -1;
                }
            }
        }
        internal JoiningDate JDate
        {
            get { return this.jDate; }
            set { this.jDate = value; }
        }

        internal Employee(string id, string name, DOBformat dob, AddressFormat address, string companyName, double salary, JoiningDate jDate, double bonus) : base(id, name, dob, address)
        {
            this.CompanyName = companyName;
            this.Salary = salary;
            this.JDate = jDate;
            this.Bonus = bonus;
        }

        public void GrossIncome()
        {
            double gincome = (Salary * 12) + (Bonus * 2);
            Console.WriteLine(gincome);
        }

        internal override void ShowPersonInfo()
        {
            Console.WriteLine();
            base.ShowPersonInfo();
            Console.WriteLine("Company Name : {0}", this.companyName);
            Console.WriteLine("Employee Salary {0}", this.salary);
            this.jDate.ShowJoiningDate();
            Console.Write("Totatl Income in a year :"); this.GrossIncome();
            Console.WriteLine();

        }


    }
}
