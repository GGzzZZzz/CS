using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.NullValuesArithmetic
{
    class NullValuesArithmetic
    {
        static void Main(string[] args)
        {
            /*Create a program that assigns null values to an integer and to a double variable.
             * Try to print these variables at the console.
             * Try to add some number or the null literal to these variables and print the result.*/

            int? a = null;
            double? b = null;
            Console.WriteLine("This integer has value null a=" + a);
            Console.WriteLine("This double has value null b=" + b);
            Console.WriteLine();
            a = 55;
            b = 164.5;
            Console.WriteLine("This integer has value a=" + "" + a);
            Console.WriteLine("This double has value b=" + "" + b);
        }
    }
}
