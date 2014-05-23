using System;

class CirclePerimeterAndArea
{
    static void Main()
    {
        //Write a program that reads the radius r of a circle and prints its perimeter and area formatted with 2 digits after the decimal point.

        Console.Write("Enter circle's radius r = ");
        double radius = double.Parse(Console.ReadLine());
        double pi = Math.PI;
        double perimeter = 2 * pi * radius; //Used formula
        double area = pi * (radius * radius); //Formula
        Console.WriteLine("The circle's perimeter is {0:F2} and its area is {1:F2}.", perimeter, area);
    }
}