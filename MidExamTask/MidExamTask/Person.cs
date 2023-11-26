using System;

namespace MidExamTask
{
    struct DOBformat
    {
        private int day;
        private int month;
        private int year;

        internal int Day
        {
            get { return this.day; }
            set
            {
                if (value <= 31 && value > 0)
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
                if (value <= 12 && value > 0)
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
        {
            get { return this.year; }
            set
            {
                if (value <= 2022 && value > 0)
                {
                    this.year = value;
                }
                else
                {
                    this.year = -1;
                }
            }
        }

        internal DOBformat(int day, int month, int year)
        {
            this.day = day;
            this.month = month;
            this.year = year;
        }

        internal void ShowDob()
        {
            Console.WriteLine("Date Of Birth : {0}-{1}-{2}", this.day, this.month, this.year);

        }


    }

    struct AddressFormat
    {
        private int houseNo;
        private int roadNo;
        private string district;

        internal int HouseNo
        {
            get { return this.houseNo; }
            set { this.houseNo = value; }
        }
        internal int RoadNo
        {
            get { return this.roadNo; }
            set { this.roadNo = value; }
        }
        internal string District
        {
            get { return this.district; }
            set { this.district = value; }
        }

        internal AddressFormat(int houseNo, int roadNo, string district)
        {
            this.houseNo = houseNo;
            this.roadNo = roadNo;
            this.district = district;
        }

        internal void ShowAddress()
        {
            Console.WriteLine("House  No : {0}", this.houseNo);
            Console.WriteLine("Road No: {0}", this.roadNo);
            Console.WriteLine("District : {0}", this.district);
        }

    }
    internal class Person
    {
        private string id;
        private string name;
        DOBformat dob;
        AddressFormat address;

        internal string Id
        {
            get { return this.id; }
            set { this.id = value; }
        }
        internal string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }
        internal DOBformat Dob
        {
            get { return this.dob; }
            set { this.dob = value; }
        }

        internal AddressFormat Address
        {
            get { return this.address; }
            set { this.address = value; }
        }
        internal Person() { }

        internal Person(string id, string name, DOBformat dob, AddressFormat address)
        {
            this.Id = id;
            this.Name = name;
            this.Dob = dob;
            this.address = address;

        }

        internal virtual void ShowPersonInfo()
        {
            Console.WriteLine("ID : {0}", this.id);
            Console.WriteLine("Name : {0}", this.name);
            this.dob.ShowDob();
            this.address.ShowAddress();
        }
    }
}
