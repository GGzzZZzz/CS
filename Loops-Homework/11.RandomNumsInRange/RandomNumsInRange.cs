using System;
class RandomNumsInRange
{
    static void Main()
    {
        //Write a program that enters 3 integers n, min and max (min ≤ max) and prints n random numbers in the range [min...max].

        Console.Write("Enter n: ");
        string inputn = Console.ReadLine();
        Console.Write("Enter min: ");
        string inputmin = Console.ReadLine();
        Console.Write("Enter max: ");
        string inputmax = Console.ReadLine();
        int n, min, max;
        while (!int.TryParse(inputn, out n) || (n <= 0) || (!int.TryParse(inputmin, out min)) || (min < 0) || (!int.TryParse(inputmax, out max) || (max <= min))) //Check data is valid
        {
            Console.Write("Incorrect input! Enter again!\nn: ");
            inputn = Console.ReadLine();
            Console.Write("min: ");
            inputmin = Console.ReadLine();
            Console.Write("max: ");
            inputmax = Console.ReadLine();
        }
        int num;
        for (int i = 0; i < n; i++)
        {
            Random randomNumber = new Random();
            num = randomNumber.Next(min, max+1); //Because max is not included
            Console.Write(num + " ");
        }
    }
}