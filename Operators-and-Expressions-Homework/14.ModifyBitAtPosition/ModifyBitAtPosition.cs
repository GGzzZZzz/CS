using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.ModifyBitAtPosition
{
    class ModifyBitAtPosition
    {
        static void Main(string[] args)
        {
            //We are given an integer number n, a bit value v (v=0 or 1) and a position p. Write a sequence of operators (a few lines of C# code) that modifies n to hold the value v at the position p from the binary representation of n while preserving all other bits in n.

            Console.Write("Enter integer number:");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine(Convert.ToString(num,2).PadLeft(32,'0')); //Binary representation of number in 32 bits
            Console.Write("Enter bit position:");
            byte bitPosition = byte.Parse(Console.ReadLine());
            Console.Write("Enter bit value 0 or 1:");
            byte bitValue = byte.Parse(Console.ReadLine());
            int newNum = 0;
            if(bitValue == 0) //Checking bit value
            {
                newNum = num & ~(1 << bitPosition); //Set bit value to be 0
                Console.WriteLine(newNum);
                Console.WriteLine(Convert.ToString(newNum, 2).PadLeft(32, '0'));
            }
            else if(bitValue == 1)
            {
                newNum = num | (1 << bitPosition); //Set bit value to be 1
                Console.WriteLine(newNum);
                Console.WriteLine(Convert.ToString(newNum, 2).PadLeft(32, '0')); //Binary representation of new number in 32 bits
            }
            else
            {
                Console.WriteLine("Invalid input! Choose bit value to be 0 or 1!" );
            }
        }
    }
}
