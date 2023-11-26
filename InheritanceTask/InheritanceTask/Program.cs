using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person student = new Student("44472","Name",21,4.4);
            student.Showinfo();
            Person employee = new Employee("72444","Tamanna",20,45125);
            employee.Showinfo();

        }
    }
}
