using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidExamTask
{
    internal static  class Organization
    {
        private static Person[] personList = new Person[100];
        private static int count = 0;
        
        
        internal static  void AddPerson(Person p)
        {
            personList[count] = p;
            count++;
        }

        internal static  void ShowAll()
        {
            int index = 0;
                while(index < count) 
            {
                personList[index].ShowPersonInfo();
                index++;
            }
        }

        internal static void Search(string key)
        {
            int index = 0;
            bool found = false; 
            while(index < count) 
            {
                if(key== personList[index].Id) 
                {
                    Console.WriteLine("Found");
                    personList[index].ShowPersonInfo();
                }
                index++;
                break;
            }
            if(!found)
            { Console.WriteLine("Not found"); }
        }
    }
}
