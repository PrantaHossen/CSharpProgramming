using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceTask
{
    internal class Employee : Person
    {
        private double salary;

        internal double Salary
        {
            get { return this.salary; }
            set { this.salary = value; }
        }

        internal Employee(string id,string name,int age,double salary): base(id,name,age)
        {
            this.Salary=salary;
        }

        internal override void Showinfo()
        {
            base.Showinfo();
            Console.WriteLine("Salary: {0}",this.Salary);
        }
    }
}
