using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.ComparingFloats
{
    class ComparingFloats
    {
        static void Main(string[] args)
        {
            /*Write a program that safely compares floating-point numbers with precision eps = 0.000001.
             * Note that we cannot directly compare two floating-point numbers a and
             * b by a==b because of the nature of the floating-point arithmetic.
             * Therefore, we assume two numbers are equal if they are more closely to each other than a fixed constant eps.*/

            Console.Write("Enter first real number a = ");
            decimal a = decimal.Parse(Console.ReadLine());
            Console.Write("Enter second real number b = ");
            decimal b = decimal.Parse(Console.ReadLine());
            Console.WriteLine("a = b is {0}", Math.Abs(a - b) < 0.000001m);
        }
    }
}
