﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.PointInCircle
{
    class PointInCircle
    {
        static void Main(string[] args)
        {
            //Write an expression that checks if given point (x,  y) is inside a circle K({0, 0}, 2).

            Console.Write("Enter x:");
            float x = float.Parse(Console.ReadLine());
            Console.Write("Enter y:");
            float y = float.Parse(Console.ReadLine());
            Console.WriteLine((x * x) + (y * y) <= 2 * 2 ? true : false); // Using Pitahor theorem (x*x) + (y*y) <= r*r
        }
    }
}
