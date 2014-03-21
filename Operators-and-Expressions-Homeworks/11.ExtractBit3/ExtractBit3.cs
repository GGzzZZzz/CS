using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.ExtractBit3
{
    class ExtractBit3
    {
        static void Main(string[] args)
        {
            //Using bitwise operators, write an expression for finding the value of the bit #3 of a given unsigned integer. The bits are counted from right to left, starting from bit #0. The result of the expression should be either 1 or 0.

            Console.Write("Enter unsigned integer:");
            uint num = uint.Parse(Console.ReadLine());
            byte bitPosition = 3;
            int mask = 1 << bitPosition; //Making bitwise mask
            Console.WriteLine((num & mask) == 0 ? "Bit #3 is 0!" : "Bit #3 is 1!"); //Bitwise comparing number and mask
        }
    }
}
