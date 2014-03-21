using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.ThirdDigitIs7
{
    class ThirdDigitIs7
    {
        static void Main(string[] args)
        {
            //Write an expression that checks for given integer if its third digit from right-to-left is 7.

            Console.Write("Enter integer number:");
            int number = int.Parse(Console.ReadLine());
            int dividedNumber = number / 100;
            Console.WriteLine("Is the third digit of " + " " + number + " " + "is 7?");
            Console.WriteLine(dividedNumber % 10 == 7 ? "The third digit of this number is 7!" : "The third digit of this number is not 7!");
        }
    }
}
