using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.OddOrEventIntegers
{
    class OddOrEventIntegers
    {
        static void Main(string[] args)
        {
            //Write an expression that checks if given integer is odd or even. 

            Console.WriteLine("Enter integer number, please.");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine(x % 2 == 0 ? "The integer is even!" : "The integer is odd!");
        }
    }
}
