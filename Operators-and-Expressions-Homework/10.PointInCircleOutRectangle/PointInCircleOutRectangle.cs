using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.PointInCircleOutRectangle
{
    class PointInCircleOutRectangle
    {
        static void Main(string[] args)
        {
            //Write an expression that checks for given point (x, y) if it is within the circle K({1, 1}, 1.5) and out of the rectangle R(top=1, left=-1, width=6, height=2).

            Console.Write("Enter x:");
            float x = float.Parse(Console.ReadLine());
            Console.Write("Enter y:");
            float y = float.Parse(Console.ReadLine());
            float radius = 1.5f;
            x = x - 1; //Because the circle K has coordinates{1,1}
            y = y - 1; //Because the circle K has coordinates{1,1}
            bool insideCircle = ((x * x) + (y * y) <= radius * radius) == true;
            x++;
            y++;
            bool insideRectangle = ((x >= -1) && (x <= 5) && (y <= 1) && (y >= -1)) == false;
            Console.WriteLine(insideCircle && insideRectangle ? "Yes" : "No");
        }
    }
}