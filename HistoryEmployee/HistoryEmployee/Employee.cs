using System;
using System.Runtime.Serialization.Formatters;

namespace HistoryEmployee
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
                if (value > 0 && value <= 31)
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
                if (value > 0 && value <= 12)
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
        { get { return this.year; }
        set
            {
                if (value > 0 && value<=12)
                {
                    this.year = value;
                }
            }
        }

        internal void ShowJoiningDate()
        {
            Console.WriteLine("Day: {0}",this.day);
            Console.WriteLine("Month: {0}",this.month);
            Console.WriteLine("Year: {0}",this.year);
        }
    }
    internal class Employee
    {
        private string id;
        private string name;
        private string position;
        JoiningDate date;
        private double salary;


        internal string ID
        {
            get { return this.id; }
            set { this.id = value; }
        }
        internal string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }
        internal string Position
        {
            get { return this.position; }
            set
            {
                this.position = value;
            }
        }
        internal JoiningDate Date
        {
            get { return this.date; }
            set
            {
                this.date = value;
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

        internal Employee() { }
        internal Employee(string id,string name,string position,JoiningDate date,double salary)
        {
            this.ID = id;
            this.Name = name;
            this.Position = position;
            this.Date = date;
            this.Salary = salary;
        }

        internal virtual void Showinfo()
        {
            Console.WriteLine("ID: {0}",this.id);
            Console.WriteLine("Name: {0}",this.name);
            Console.WriteLine("Position: {0}",this.position);
            this.date.ShowJoiningDate();
            Console.WriteLine("Salary: {0}",this.salary);
        }


    }
}
