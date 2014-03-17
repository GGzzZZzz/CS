using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Four_DigitNumber
{
    class Four_DigitNumber
    {
        static void Main(string[] args)
        {
//            Write a program that takes as input a four-digit number in format abcd (e.g. 2011) and performs the following:
//•	Calculates the sum of the digits (in our example 2+0+1+1 = 4).
//•	Prints on the console the number in reversed order: dcba (in our example 1102).
//•	Puts the last digit in the first position: dabc (in our example 1201).
//•	Exchanges the second and the third digits: acbd (in our example 2101).
//The number has always exactly 4 digits and cannot start with 0.

            Console.Write("Enter integer number with exactly 4 digits:");
            int num = int.Parse(Console.ReadLine());
            int firstDigit = (num / 1000) % 10;
            int secondDigit = (num / 100) % 10;
            int thirdDigit = (num / 10) % 10;
            int fourthDigit = (num / 1) % 10;
            Console.WriteLine(firstDigit + secondDigit + thirdDigit + fourthDigit);
            Console.WriteLine("{0}{1}{2}{3}",fourthDigit,thirdDigit,secondDigit,firstDigit);
            Console.WriteLine("{0}{1}{2}{3}",fourthDigit,firstDigit,secondDigit,thirdDigit);
            Console.WriteLine("{0}{1}{2}{3}", firstDigit, thirdDigit, secondDigit, fourthDigit);
        }
    }
}
