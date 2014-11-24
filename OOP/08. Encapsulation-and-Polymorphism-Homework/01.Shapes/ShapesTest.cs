using System;
using System.Collections.Generic;

public class ShapesTest
{
    public static void Main()
    {
        IShape[] shapes = new IShape[]
        {
            new Triangle(5.5, 1.3, 20),
            new Rectangle(7.3, 4.1),
            new Circle(4.5)
        };

        foreach (IShape shape in shapes)
        {
            Console.WriteLine(shape.GetType() + "'s area:{0:F2}", shape.CalculateArea());
            Console.WriteLine(shape.GetType() + "'s perimeter:{0:F2}", shape.CalculatePerimeter());
            Console.WriteLine();
        }
    }
}