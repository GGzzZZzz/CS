using System;
class TrailingZeroesInN
{
    static void Main()
    {
        //Write a program that calculates with how many zeroes the factorial of a given number n has at its end. Your program should work well for very big numbers, e.g. n=100000.

        Console.Write("Enter integer positive number: ");
        int n = int.Parse(Console.ReadLine()); ;
        int counter;
        int five = 5;
        int sum = 0;

        while (n > five)
        {
            counter = n / five;
            five = five * 5;

            sum += counter;
        }
        Console.WriteLine(sum);
    }
}