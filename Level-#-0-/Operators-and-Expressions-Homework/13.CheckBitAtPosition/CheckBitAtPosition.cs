using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.CheckBitAtPosition
{
    class CheckBitAtPosition
    {
        static void Main(string[] args)
        {
            //Write a Boolean expression that returns if the bit at position p (counting from 0, starting from the right) in given integer number n has value of 1.

            Console.Write("Enter integer number:");
            int num = int.Parse(Console.ReadLine());
            Console.Write("Enter bit position:");
            byte bitPosition = byte.Parse(Console.ReadLine());
            int mask = 1 << bitPosition; //Making bitwise mask
            Console.WriteLine((num & mask) == 0 ? false:true); //Bitwise comparing number and mask
        }
    }
}
