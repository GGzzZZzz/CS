using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.UnicodeValue
{
    class UnicodeValue
    {
        static void Main(string[] args)
        {
            /*Declare a character variable and assign it with the symbol that has Unicode code 72,
             * and then print it. Hint: first,
             * use the Windows Calculator to find the hexadecimal representation of 72. The output should be “H”.*/

            char symbol = (char)0x48;
            Console.WriteLine(symbol);
        }
    }
}
