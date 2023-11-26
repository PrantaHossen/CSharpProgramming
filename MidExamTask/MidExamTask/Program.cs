using System;

namespace MidExamTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person[] persons = new Person[5];
            /*persons[0] = new Student("45115", "Omayer", new DOBformat(27, 8, 2002), new AddressFormat(12, 27, "Dhaka"), "AIUB", 3.85);
            persons[1] = new Employee("123", "Bruce", new DOBformat(7, 8, 1995), new AddressFormat(12, 45, "Dhaka"), "ACI", 45000, new JoiningDate(12,7,2022),2500);
            persons[2]= new Employee("158", "xyz", new DOBformat(7, 8, 1985), new AddressFormat(12, 45, "Dhaka"), "RFL", 35000, new JoiningDate(12, 7, 2022), 900);
            */
            /*foreach (Person person in personlist)
            {
                Console.WriteLine();
                person.ShowPersonInfo();
            }*/
            //Organization q = new Organization();
            Organization.AddPerson(new Student("45115", "Omayer", new DOBformat(27, 8, 2002), new AddressFormat(12, 27, "Dhaka"), "AIUB", 3.85));
            Organization.AddPerson(new Employee("123", "Bruce", new DOBformat(7, 8, 1995), new AddressFormat(12, 45, "Dhaka"), "ACI", 45000, new JoiningDate(12, 7, 2022), 2500));
            Organization.AddPerson(new Employee("158", "xyz", new DOBformat(7, 8, 1985), new AddressFormat(12, 45, "Dhaka"), "RFL", 35000, new JoiningDate(12, 7, 2022), 900));

           // Organization.ShowAll();
            Organization.Search(Console.ReadLine());
        }
    }
}
