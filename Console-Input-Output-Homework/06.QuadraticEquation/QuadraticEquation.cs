using System;

class QuadraticEquation
{
    static void Main()
    {
        //Write a program that reads the coefficients a, b and c of a quadratic equation ax2 + bx + c = 0 and solves it (prints its real roots).

        Console.WriteLine("Enter coefficients of the quadratic equation:");
        Console.Write("a = ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("b = ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("c = ");
        double c = double.Parse(Console.ReadLine());
        Console.WriteLine("The quadratic equation looks like this: {0}x^2 + {1}x + {2} = 0", a, b, c);
        double x1, x2; //Real roots
        double d;//Discriminant
        d = (b * b) - (4 * a * c); //Finding discriminant
        double x3;
        if (d > 0)
        {
            x1 = (-b + Math.Sqrt(d)) / (2 * a); //Formula
            x2 = (-b - Math.Sqrt(d)) / (2 * a); //Formula

            Console.WriteLine("The quadratic equation has two real roots: \r\nx1 = {0:F2} \r\nx2 = {1:F2}", x1, x2);
        }
        else
        {
            if (d == 0)
            {
                x3 = -b / 2 * a; //Formula
                Console.WriteLine("The quadratic equation has one real root: \r\nx1 = x2 = {0:F2}.", x3);
            }
            else
            {
                Console.WriteLine("The quadratic eqauation hasn't real roots.");
            }
        }
    }
}