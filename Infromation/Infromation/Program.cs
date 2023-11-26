using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Infromation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student();
            s1.Id=1;//s1.SetID(1); //s1.id= 1;
            Console.WriteLine("Type a name: ");
            string name=Console.ReadLine();
            s1.Name = name;//s1.SetName(name);  //s1.name = "Bruce";
            Console.WriteLine("Type Blood Group: ");
            string bloodGroup=Console.ReadLine();
            s1.BloodGroup = bloodGroup;//s1.SetBloodGroup(bloodGroup);//s1.bloodGroup = "B+";
            s1.Cgpa = 3.55;//s1.SetCgpa(3.55);//s1.cgpa = 3.55;
            s1.Address= new AddressFormat(1, 2, 1129, "KHULNA");//s1.SetAddress(new AddressFormat(1, 2, 1129, "KHULNA"));//s1.address = new AddressFormat(1,2,1129,"KHULNA");
            s1.showStudentInfo();
            //Console.WriteLine("{0}",s1.GetName());

            AddressFormat a1 = new AddressFormat(025,12,1214,"Kishorganj");

            Student s2 = new Student(21, "Jisan", "A+",a1,4.5);
            s2.showStudentInfo();

            Student s3 = new Student(12,"Rahim","AB+", new AddressFormat(012, 42, 1224, "Chattogram"), 3.54);
             s3.showStudentInfo();


            Console.WriteLine();
            DateTime currentTime= DateTime.Now;
            Console.WriteLine(currentTime);
        }
    }
}
