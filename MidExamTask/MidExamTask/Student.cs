using System;

namespace MidExamTask
{
    internal class Student : Person
    {
        private string instituteName;
        private double cgpa;

        internal string InstituteName
        {
            get { return this.instituteName; }
            set { this.instituteName = value; }
        }
        internal double CGPA
        {
            get { return this.cgpa; }
            set
            {
                if (value <= 4 && value > 0)
                {
                    this.cgpa = value;
                }
                else
                {
                    this.cgpa = -1;
                }
            }
        }

        internal Student(string id, string name, DOBformat dob, AddressFormat address, string instituteName, double cgpa) : base(id, name, dob, address)
        {
            this.InstituteName = instituteName;
            this.CGPA = cgpa;
        }

        internal override void ShowPersonInfo()
        {
            base.ShowPersonInfo();
            Console.WriteLine("Institution Name : {0}", this.instituteName);
            Console.WriteLine("Cgpa: {0}", this.cgpa);
        }
    }
}
