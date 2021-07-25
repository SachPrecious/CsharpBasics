using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {

            int number = 53;
            int aNumber;
            var SomeNumber = 33;
            Console.WriteLine("Enter a Number");
            aNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Number is " + number + " A Number Is " + aNumber + " Some Number is " + SomeNumber);


            double doubleValue = 44.5;
            Console.WriteLine("Enter a Number");
            Double aDoubleNumber = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Double Values " + doubleValue + " " + aDoubleNumber);
            Console.ReadKey();

            
        }
    }
}
