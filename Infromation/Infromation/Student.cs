using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infromation
{
    struct AddressFormat
    {
        private byte houseNo;
        private byte roadNo;
        private ushort postalCode;
        private string dristic;

        public byte GetHouseNo()
        {
            return houseNo;
        }

        public void SetHouseNo(byte houseNo)
        {
            this.houseNo = houseNo;
        }
        public byte GetRoadNo()
        {
            return roadNo;
        }

        public void SetRoadNo(byte roadNo)
        {
            this.roadNo = roadNo;   
        }
        public ushort GetPostalCode()
        {
            return postalCode;
        }
        public void SetPostalCode(ushort postalCode)
        {
            this.postalCode = postalCode;
        }

        public string GetDristic()
        {
            return dristic;
        }

        public void SetDristic(string dristic)
        {
            this.dristic=dristic;
        }


        public AddressFormat(byte houseNo, byte roadNo, ushort postalCode, string dristic)
        { 
            this.houseNo = houseNo;
            this.roadNo = roadNo;
            this.postalCode = postalCode;
            this.dristic = dristic;
        }

        public void printAddress()
        {
            Console.WriteLine("House No: {0}", this.GetHouseNo());//this.houseNo);
            Console.WriteLine("Road No : {0}", this.GetRoadNo());//this.roadNo);
            Console.WriteLine("Postal Code : {0}", this.GetPostalCode());//this.postalCode);
            Console.WriteLine("District : {0}", this.GetDristic());//this.dristic);

        }
    }
    internal class Student
    {
        public byte id;
        public string name;
        public string bloodGroup;
        public AddressFormat address;
        public double cgpa;

        public byte Id
        {
            get { return this.id; }
            set { this.id = value; }
        }

    public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }
        public string BloodGroup
        {
            get { return this.bloodGroup; }
           set { this.bloodGroup = value; }
        }

        public AddressFormat Address
        {
            get { return this.address; }
            set
            {
                this.address = value;
            }
        }

        public double Cgpa
        {
            get { return this.cgpa; }
            set
            {
                if(value>=0.0 && value <=4.00)
                {
                    this.cgpa = value;
                }
                else
                {
                    this.cgpa = -1;
                }
                  
           }
        }

        public byte GetId()
        {
            return this.id;
        }

        public void SetID(byte id)
        {
            this.id = id;
        }

        public string GetName()
        {
            return this.name;
        }

        public void SetName(string name) 
        {
            this.name = name;
        }

        public string GetBloodGroup()
        {
            return bloodGroup;
        }

        public void SetBloodGroup(string bloodGroup)
        {
            this.bloodGroup = bloodGroup;
        }

        public AddressFormat GetAddress()
        {
            return address;
        }

        public void SetAddress(AddressFormat address)
        {
            this.address = address;
        }

        public double GetCgpa()
        {
            return cgpa;
        }

        public void SetCgpa(double cgpa)
        { 
            if(cgpa>=0.0 && cgpa<=4.0)
            this.cgpa=cgpa;

            else
            {
                this.cgpa = -1;
                Console.WriteLine("Invalid Input");
            }
        }
        



        public Student() { }

        public Student(byte id,string name, string bloodGroup, AddressFormat address,double cgpa)
        {
            this.Id = id;//this.SetID(id);//this.id = id;
            this.Name = name;//this.SetName(name);//this.name = name;  
            this.BloodGroup = bloodGroup;//SetBloodGroup(bloodGroup);//this.bloodGroup = bloodGroup;
            this.Address = address;//SetAddress(address);//this.address = address;
            this.Cgpa = cgpa;//SetCgpa(cgpa);//this.cgpa = cgpa;
        }
        

        public void showStudentInfo()
        {
            Console.WriteLine("");
            Console.WriteLine("Student Info: ");
            Console.WriteLine("Student id :{0}", this.Id);//this.GetId());//this.getid);
            Console.WriteLine("Student Name : {0}", this.Name);//this.GetName()); //this.name;
            Console.WriteLine("Student Blood Group: {0}", this.BloodGroup);//GetBloodGroup());//this.bloodGroup);
            this.Address.printAddress();//GetAddress().printAddress();//this.address.printAddress();
            Console.WriteLine("Student CGPA: {0}", this.GetCgpa());//this.cgpa);
        }
    }
}
