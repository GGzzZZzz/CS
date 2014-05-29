using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.AgeAfterTenYears
{
    class AgeAfterTenYears
    {
        static void Main(string[] args)
        {
            //Write a program to read your age from the console and print how old you will be after 10 years.

            Console.WriteLine("How old are you?");
            int ageInTenYears;
            ageInTenYears = int.Parse(Console.ReadLine()) + 10;
            Console.WriteLine("You will be {0} years old in 10 years", ageInTenYears);
        }
    }
}
