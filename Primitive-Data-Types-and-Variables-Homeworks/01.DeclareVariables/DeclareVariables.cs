using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.DeclareVariables
{
    class DeclareVariables
    {
        static void Main(string[] args)
        {
            /*Declare five variables choosing for each of them the most appropriate of the types byte, sbyte, short, ushort,
             * int, uint, long, ulong to represent the following values: 52130, -115, 4825932, 97, -10000.
             * Choose a large enough type for each number to ensure it will fit in it. Try to compile the code.*/

            uint a = 52130;
            sbyte b = -115;
            uint c = 4825932;
            byte d = 97;
            int e = -10000;
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
            Console.WriteLine(d);
            Console.WriteLine(e);
        }
    }
}
