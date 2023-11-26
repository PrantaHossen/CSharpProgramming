using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Cal
{
    public void Addition()
    {
        int sum=0, number, n;
        Console.Write("Enter Number Of items : ");
        number=int.Parse(Console.ReadLine());

        for(int i=0;i<number;i++)
        {
            Console.Write("Enter Number : {0}",i+1);
            n=int.Parse(Console.ReadLine());
            sum = sum+ n;

        }
        Console.Write("Total of this numbers is: {0}",sum);

    }

    public void diff()
    {
        int diff, num, n;

        Console.WriteLine("Enter Two numbers to find their difference");
        Console.Write("Enter First Number : ");
        num=int.Parse(Console.ReadLine());
        Console.Write("Enter Second Number: ");
        n=int.Parse(Console.ReadLine());

        diff = num - n;
        Console.Write("Difference is : {0}",diff);
    }

    public void mul()
    {
        int mul = 1;
        int n, numbers;
        Console.Write("Enter Numbers Of Items: ");
        numbers = int.Parse(Console.ReadLine());
        for(int i=0;i<numbers;i++)
        {
            Console.Write("Enter Items: {0}",i+1);
            n = int.Parse(Console.ReadLine());
            mul = mul*n;
        }
        Console.Write("Numbers Multiply is : {0} ",mul);
    }

    public void div()
    {
        int div, num, n;
        Console.Write("Enter Two numbers Find their quotient: ");
        Console.Write("Enter Numerator ");
        num= int.Parse(Console.ReadLine());
        Console.Write("Enter Demanator: ");
        n=int.Parse(Console.ReadLine());
        div = num/n;
        Console.Write("Quotient is : {0} ",div);
    }
}

namespace calculator
{

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine( "***Which operation you want to perform***\n");
            Console.WriteLine( "Press 0 for exit\n");
            Console.WriteLine("Press 1 for addition \n");
            Console.WriteLine( "Press 2 for subtraction\n");
            Console.WriteLine( "Press 3 for multiplication\n");
            Console.WriteLine("Press 4 for division\n");
            Console.Write("Press option: ");

            Cal a= new Cal();
            int op=Convert.ToInt32(Console.ReadLine());
            switch(op)
            {
                case 1:
                    a.Addition();
                    break;
               case 2:
                    a.diff();
                    break;
                case 3:
                    a.mul();
                    break;
                case 4:
                    a.div();
                    break;

                case 0:
                    
                 default:
                    Console.WriteLine("Invalid Input");
                    break;
            }

        }
    }
}
