using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product
{
    struct DateFormate
    {
        private byte day;
        private byte month;
        private ushort year;

      internal byte Day
        {
            get { return day; }
            set
            {
                if(value>0 && value<=31)
                    this.day = value;
                else
                    this.day = 0;
            }
        }
        public byte GetMonth()
        {
            return month;

        }
        public void SetMonth(byte month)
        {
            if(month>0 && month<=12)
                this.month = month; 
            else
            {
                Console.WriteLine("Invalid");
            }
        }
        public ushort GetYear()
        {
            return year;
        }
        public void SetYear(ushort year)
        {
            if(year<=2022)
            {
                this.year = year;
            }
            else
            {
                Console.WriteLine("Invalid");
            }
        }
        public DateFormate(byte day,byte month,ushort year)
        {
            this.day = day;
            this.month = month;
            this.year = year;
        }

        public void ShowDate()
        {
            Console.Write("Manufacturing Date:");
            Console.Write("{0}-{1}-{2}", this.day, this.GetMonth(), this.GetYear());
            Console.WriteLine( );

        }
    }

    struct ExpDate
    {
        private byte day;
        private byte month;
        private ushort year;

        public ExpDate(byte day, byte month, ushort year)
        {
            this.day = day;
            this.month = month;
            this.year = year;
        }

        public byte GetDay()
        {
            return day;
        }
        public void SetDay(byte day)
        {
            if (this.day > 0 && this.day <= 31)

                this.day = day;

            else
            {
                Console.WriteLine("Invalid day");
            }

        }
        public byte GetMonth()
        {
            return month;

        }
        public void SetMonth(byte month)
        {
            if (month > 0 && month <= 12)
                this.month = month;
            else
            {
                Console.WriteLine("Invalid");
            }
        }
        public ushort GetYear()
        {
            return year;
        }
        public void SetYear(ushort year)
        {
            if (year >= 2022)
            {
                this.year = year;
            }
            else
            {
                Console.WriteLine("Invalid");
            }
        }

        public void ShowExpDate()
        {
            Console.Write("Exp Date:");
            Console.Write("{0}-{1}-{2}", this.GetDay(), this.GetMonth(), this.GetYear());
            Console.WriteLine();

        }
    }
    internal class Product
    {
        
        private byte id;
        private string name;
        private double price;
        private byte quantity;
        private DateFormate date;
        private ExpDate expDate;

        public Product()
        {

        }

        public Product(byte id,string name,double price,byte quantity,DateFormate date,ExpDate expDate)
        {
            this.SetId(id);
            this.SetName(name);
            this.SetPrice(price);
            this.SetQuantity(quantity);
            this.SetDate(date);
            this.SetExpDate(expDate);

        }
        public byte GetId()
        {
            return id;
        }
        public void SetId(byte id)
        {
            this.id = id;
        }
        public string  GetName()
        {
            return name;
        }
        public void SetName(string name)
        {
            this.name = name;
        }
        public double GetPrice()
        {
            return price;
        }
        public void SetPrice(double price)
        {
            this.price = price;
        }
        public byte GetQuantity()
        {
            return quantity;
        }
        public void SetQuantity(byte quantity)
        {
            this.quantity = quantity;
        }

        public DateFormate GetDate()
        {
            return date;
        }
        public void SetDate(DateFormate date)
        {
            this.date = date;
        }
        public ExpDate GetExpDate()
        {
            return expDate; 
        }
        public void SetExpDate(ExpDate expDate)
        {
            this.expDate=expDate;
        }

        public void ShowInfo()
        {
            Console.WriteLine();
            Console.WriteLine("Product id : {0}",this.GetId());
            Console.WriteLine("Product name: {0}",this.GetName());
            Console.WriteLine("Product Price: {0}",this.GetPrice());
            Console.WriteLine("Product quantity: {0}",this.GetQuantity());
            this.date.ShowDate();
            this.expDate.ShowExpDate();
            Console.WriteLine();


        }
    }
}
