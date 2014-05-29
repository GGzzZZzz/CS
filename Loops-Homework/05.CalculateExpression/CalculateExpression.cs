using System;
using System.Numerics;
class CalculateExpression
{
    static void Main()
    {
        //Write a program that, for a given two integer numbers n and x, calculates the sum S = 1 + 1!/x + 2!/x2 + … + n!/xn. Use only one loop. Print the result with 5 digits after the decimal point.

        Console.Write("Enter n: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Enter x: ");
        int x = int.Parse(Console.ReadLine());
        BigInteger factorial = 1;
        double powerX = 1;
        double sum = 1;
        for(int i = 1; i <= n; i++)
        {
            factorial *= i;
            powerX *= x; // = Math.Pow(x,i)
            sum += (double)factorial / powerX;
        }
        Console.WriteLine("{0:F5}",sum);
    }
}