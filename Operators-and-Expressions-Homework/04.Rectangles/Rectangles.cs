using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Rectangles
{
    class Rectangles
    {
        static void Main(string[] args)
        {
            //Write an expression that calculates rectangle’s perimeter and area by given width and height. 

            Console.Write("Width = ");
            float width = float.Parse(Console.ReadLine());
            Console.Write("Height = ");
            float height = float.Parse(Console.ReadLine());
            Console.WriteLine("The rectangle's area is" + " " + (width * height)); //Using formula
        }
    }
}
