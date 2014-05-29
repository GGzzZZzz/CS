using System;

class SumOfnNums
{
    static void Main()
    {
        //Write a program that enters a number n and after that enters more n numbers and calculates and prints their sum. Note that you may need to use a for-loop.

        Console.Write("Enter number n: ");
        int n = int.Parse(Console.ReadLine());
        int sum = 0;
        for (int i = 0; i < n; i++)
        {
            Console.Write("Input number: ");
            int number = int.Parse(Console.ReadLine());
            sum = sum + number;
        }
        Console.WriteLine("The sum of these numbers is {0}.",sum);
    }
}