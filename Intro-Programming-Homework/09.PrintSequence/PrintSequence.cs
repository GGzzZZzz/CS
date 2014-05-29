using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.PrintSequence
{
    class PrintSequence
    {
        static void Main(string[] args)
        {
            //Write a program that prints the first 10 members of the sequence: 2, -3, 4, -5, 6, -7, ...

            sbyte counter = 1;
            byte i;
            for (i = 2; i < 12; i++)
            {
                Console.WriteLine(i * counter);
                counter *= -1;
            }
        }
    }
}
