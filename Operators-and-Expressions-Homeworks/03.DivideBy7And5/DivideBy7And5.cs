using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.DivideBy7And5
{
    class DivideBy7And5
    {
        static void Main(string[] args)
        {
            //Write a Boolean expression that checks for given integer if it can be divided (without remainder) by 7 and 5 in the same time.

            Console.WriteLine("Enter integer number, please.");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine(num % 5 == 0 && num % 7 == 0 ? "This integer can be divided (without reminder) by 7 and 5 in the same time!" :"This integer can't be divided (without reminder) by 7 and 5  in the same time!");
        }
    }
}
