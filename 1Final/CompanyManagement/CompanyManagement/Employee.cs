using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace CompanyManagement
{
    internal class Employee
    {
        private static int serialno = 0;
        protected string id;
        private string name;
        private DateTime dob;
        private double salary;

        internal virtual string Id
        { get { return this.id; }

            set
            {
                this.id ="E"+ value;
            }
        }

        internal string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        internal DateTime DOB
        {
            get { return this.dob; }
            set { this.dob = value; }

        }

        internal double Salary
        { get { return this.salary; }
            set { this.salary = value; }
        }

        internal Employee() { }

        internal Employee(string name, DateTime dob, double salary)
        {
            this.Id = (++serialno).ToString();
            this.Name = name;
            this.DOB = dob;
            this.Salary = salary;
        }

        

        internal virtual double GrossIncome()
        {
            return this.salary;
        }

        internal virtual double NetTax()
        {
            return this.salary;
        }

        internal virtual void ShowInformation()
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("ID- {0}", this.Id);
            Console.WriteLine("Name : {0}", this.name);
            Console.WriteLine("Date of Birth : {0:D}", this.dob);
            Console.WriteLine("Salary : {0}",this.salary);
            this.GrossIncome();
            this.NetTax();
            
        }

    }
}

