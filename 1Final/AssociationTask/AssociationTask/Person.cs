using System;

namespace AssociationTask
{
    struct DobFormate
    {
        int day;
        int month;
        int year;

        internal int Day
        {
            get { return this.day; }
            set
            {
                if (value > 0 && value <= 31)
                { this.day = value; }
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
                if (value > 0 && value <= 12)
                { this.month = value; }
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
                if (value <= 2022 && value >= 1900)
                { this.year = value; }
                else
                {
                    this.year = -1;
                }
            }
        }

        internal DobFormate(int day, int month, int year)
        {
            this.day = day;
            this.month = month;
            this.year = year;

        }

        internal void ShowDate()
        {
            Console.WriteLine("Date Of Birth: {0}-{1}-{2}", this.day, this.month, this.year);

        }
    }
    struct AddressFormat
    {
        internal string RoadNo { get; set; }
        internal string Area { get; set; }
        internal string District { get; set; }

        internal AddressFormat(string roadno, string area, string district)
        {
            this.RoadNo = roadno;
            this.Area = area;
            this.District = district;
        }

        internal void ShowAddress()
        {
            Console.WriteLine("Road No {0}: ", this.RoadNo);
            Console.WriteLine("Area Name {0}", this.Area);
            Console.WriteLine("Distric {0}", this.District);
        }
        internal class Person
        {

            internal string Id { get; set; }
            internal string Name { get; set; }
            internal string Position { get; set; }
            internal DobFormate Date { get; set; }
            internal AddressFormat Address { get; set; }

            internal Person() { }

            internal Person(string id, string name, string position, DobFormate date, AddressFormat address)
            {
                this.Id = id;
                this.Name = name;
                this.Position = position;
                this.Date = date;
                this.Address = address;

            }

            internal virtual void ShowPersonInfo()
            {
                Console.WriteLine(" ");
                Console.WriteLine("Perons Id : {0}", this.Id);
                Console.WriteLine("Perons Name : {0}", this.Name);
                Console.WriteLine("Perons Position : {0}", this.Position);
                this.Date.ShowDate();
                this.Address.ShowAddress();
                Console.WriteLine();
            }
        }
    }
}
