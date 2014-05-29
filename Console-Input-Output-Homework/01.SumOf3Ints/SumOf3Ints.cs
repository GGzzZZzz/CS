using System;
class SumOf3Ints
{
    static void Main()
    {
        //Write a program that reads 3 integer numbers from the console and prints their sum.

        Console.Write("Enter first integer: ");
        int first = int.Parse(Console.ReadLine());
        Console.Write("Enter second integer: ");
        int second = int.Parse(Console.ReadLine());
        Console.Write("Enter third integer: ");
        int third = int.Parse(Console.ReadLine());
        int sum = first + second + third;
        Console.WriteLine("The sum of these 3 integers is {0}.",sum);
    }
}