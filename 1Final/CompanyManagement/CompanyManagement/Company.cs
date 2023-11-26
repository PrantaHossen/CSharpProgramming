using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CompanyManagement
{
    internal static class Company
    {
        private static Employee[] employeeList = new Employee[100];
        private static int count = 0;

        internal static void AddEmployee(Employee e)
        {
            employeeList[count] = e;
            count++;
        }

        internal static void RemovePerson()
        {
            int index = 0;
            Console.WriteLine("Count {0}", count);
            while (index < count)
            {
                if (employeeList[index] != null)
                {
                    employeeList[index].ShowInformation();
                    index++;
                }

            }

        }
        internal static void ShowAll()
        {
            int index = 0;
            Console.WriteLine("Count {0}", count);
            while (index < count)
            {
                if (employeeList[index] != null)
                {
                    employeeList[index].ShowInformation();
                    index++;
                }

            }
        }
        internal static bool Search(string key, out int r)
        {

            int index = 0;
            bool found = false;
            while (index < count)
            {
                if (key.Equals(employeeList[index].Id))
                {
                    found = true;
                    Console.WriteLine("Employee Found");
                    employeeList[index].ShowInformation();
                    r = index;
                    return found;
                }

                index++;
            }

            if (!found)
                Console.WriteLine("Data Not Found Marhaba");
            r = -1;
            return found;
        }

        internal static void Scase()
        {
            Console.WriteLine();
            Console.WriteLine("Press 1 For Add Employee");
            Console.WriteLine("Press 2 For Remove Employee");
            Console.WriteLine("Press 3 For  Remove Employee");

            int x;
            x = Convert.ToInt32(Console.ReadLine());

            switch(x)
            {
                case 1:
                    Console.WriteLine("Adding Employee");
                    void AddEmployee(Employee e)
                    {
                        employeeList[count] = e;
                        count++;
                    }
                    Console.WriteLine("Adding Person Done!");
                    break;
                    case 2:
                    Console.WriteLine("Remove Person Opeation..........");
                     void RemovePerson()
                    {
                        int index = 0;
                        Console.WriteLine("Count {0}", count);
                        while (index < count)
                        {
                            if (employeeList[index] != null)
                            {
                                employeeList[index].ShowInformation();
                                index++;
                            }

                        }

                    }
                    break; 
                  
                    default :
                    Console.WriteLine("Exit");
                    break;
                   
            }

        }

    }
}
