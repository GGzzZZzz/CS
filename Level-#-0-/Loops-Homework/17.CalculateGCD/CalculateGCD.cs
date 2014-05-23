using System;
class CalculateGCD
{
    static void Main()
    {
        //Write a program that calculates the greatest common divisor (GCD) of given two integers a and b. Use the Euclidean algorithm (find it in Internet).

        Console.WriteLine("Enter 2 integers each on separate line");
        int first = int.Parse(Console.ReadLine());
        int second = int.Parse(Console.ReadLine());
        while (first == 0 || second == 0) //Ignore zero
        {
            Console.WriteLine("Cannot divide by zero!Enter integers again");
            first = int.Parse(Console.ReadLine());
            second = int.Parse(Console.ReadLine());
        }
        int remainder = 1;
        while(remainder != 0)
        {
            remainder = first % second;
            first = second;
            second = remainder;
        }
        Console.WriteLine("GCD = {0}",Math.Abs(first));
    }
}