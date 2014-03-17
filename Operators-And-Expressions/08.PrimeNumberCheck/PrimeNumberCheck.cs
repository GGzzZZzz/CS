using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.PrimeNumberCheck
{
    class PrimeNumberCheck
    {
        static void Main(string[] args)
        {
            //Write an expression that checks if given positive integer number n (n ≤ 100) is prime (i.e. it is divisible without remainder only to itself and 1). 

            Console.WriteLine("Enter positive integer number <=100");
            uint num = uint.Parse(Console.ReadLine());
            if (num > 1 && num <= 100) // Checks numbers in interval
            {
                if (num == 2 || num == 3 || num == 5 || num == 7) // Checks numbers 2, 3, 5, 7
                {
                    Console.WriteLine("This integer IS prime number!");
                }
                else
                {
                    if (num % 2 != 0 && num % 3 != 0 && num % 5 != 0 && num % 7 != 0) // Checks division with reminder
                    {
                        Console.WriteLine("This integer IS a prime number!");
                    }
                    else
                    {
                        Console.WriteLine("This integer is NOT a prime number!");
                    }
                }
            }
            else
            {
                Console.WriteLine("Invalid input! Please enter an integer which is in range!");
            }
        }
    }
}
