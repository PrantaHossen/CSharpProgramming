using System;

namespace Management
{
    struct JoiningDate
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
            Console.WriteLine("Joining Date  : {0}-{1}-{2}", this.day, this.month, this.year);

        }


    }
    internal class Employee
    {
        private string id;
        private string name;
        JoiningDate joiningDate;
        private double salary;
        private string position;

        internal String ID
        {
            get { return this.id; }
            set { this.id = value; }
        }

        internal string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        internal JoiningDate JoiningDate
        {
            get { return this.joiningDate; }
            set
            {
                this.joiningDate = value;
            }
        }

        internal double Salary
        {
            get { return this.salary; }
            set
            {
                this.salary = value;
            }
        }

        internal String Position
        {
            get { return this.position; }
            set
            {
                this.position = value;
            }
        }

        internal Employee() { }

        internal Employee(string id, string name, JoiningDate joiningDate, double salary, string position)
        {
            this.ID = id;
            this.Name = name;
            this.JoiningDate = joiningDate;
            this.Salary = salary; 
            this.Position = position;
        }

        protected virtual double GrossIncome()
        {
            return Salary;
        }

        protected virtual double NetTax()
        {
            
            return salary;
            
        }

        internal virtual void ShowInfo()
        {
            Console.WriteLine("");
            Console.WriteLine("Employee Id :{0}",this.id);
            Console.WriteLine("EMployee Name: {0}",this.name);
            this.JoiningDate.ShowJoiningDate();
            Console.WriteLine("Salary: {0}",this.salary);
            Console.WriteLine("Postion: {0}",this.position);
            this.GrossIncome();
            this.NetTax();
           
        }
    }
}
