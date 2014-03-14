using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.IsoscelesTriangle
{
    class IsoscelesTriangle
    {
        static void Main(string[] args)
        {
            /*Write a program that prints an isosceles triangle of 9 copyright symbols ©, something like this:
   ©
  © ©
 ©   ©
© © © ©
Note that the © symbol may be displayed incorrectly at the console so you may need to change the console character
             * encoding to UTF-8 and the console font.*/

            Console.OutputEncoding = Encoding.Unicode;
            Console.WriteLine("   \u00A9   ");
            Console.WriteLine("  \u00A9 \u00A9");
            Console.WriteLine(" \u00A9   \u00A9");
            Console.WriteLine("\u00A9 \u00A9 \u00A9 \u00A9");
        }
    }
}
