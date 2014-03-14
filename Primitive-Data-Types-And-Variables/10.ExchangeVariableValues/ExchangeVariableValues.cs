using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.ExchangeVariableValues
{
    class ExchangeVariableValues
    {
        static void Main(string[] args)
        {
            /*Declare two integer variables a and b and assign them with 5 and 10 and after that exchange their values.
             * Print the variable values before and after the exchange.*/

            uint a = 5;
            uint b = 10;
            Console.WriteLine("a=" + "" + a);
            Console.WriteLine("b=" + "" + b);
            Console.WriteLine();
            a = a + b;
            b = a - b;
            a = a - b;
            Console.WriteLine("a=" + "" + a);
            Console.WriteLine("b=" + "" + b);
        }
    }
}
