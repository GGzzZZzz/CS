using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16.PrintLongSequence
{
    class PrintLongSequence
    {
        static void Main(string[] args)
        {
            /*Write a program that prints the first 1000 members of the sequence: 2, -3, 4, -5, 6, -7, … 
             * You might need to learn how to use loops (search in Internet).*/

            sbyte counter = 1;
            int i;
            for (i = 2; i < 1002; i++)
            {
                Console.WriteLine(i * counter);
                counter *= -1;
            }
        }
    }
}
