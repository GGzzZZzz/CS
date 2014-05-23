using System;

class NumsFrom1ToN
{
    static void Main()
    {
        //Write a program that reads an integer number n from the console and prints all the numbers in the interval [1..n], each on a single line. Note that you may need to use a for-loop.

        Console.Write("Input integer number n: ");
        int number = int.Parse(Console.ReadLine());
        Console.WriteLine("The interval is [1-" + number + "]");
        for (int i = 1; i <= number; i++)
        {
            Console.WriteLine(i);
        }
    }
}