using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.ExtractBitFromInt
{
    class ExtractBitFromInt
    {
        static void Main(string[] args)
        {
            //Write an expression that extracts from given integer n the value of given bit at index p.

            Console.Write("Enter integer number:");
            int num = int.Parse(Console.ReadLine());
            Console.Write("Enter bit position:");
            byte bitPosition = byte.Parse(Console.ReadLine());
            int mask = 1 << bitPosition; //Making bitwise mask
            Console.WriteLine((num & mask) == 0 ? "Bit at position" + " " + bitPosition + " " + "is 0!" : "Bit at position" + " " + bitPosition + " " + "is 1!"); //Bitwise comparing number and mask
        }
    }
}
