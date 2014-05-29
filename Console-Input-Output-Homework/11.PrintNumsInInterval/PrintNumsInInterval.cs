using System;

class PrintNumsInInterval
{
    static void Main()
    {
        //Write a program that reads two positive integer numbers and prints how many numbers p exist between them such that the reminder of the division by 5 is 0.

        Console.WriteLine("Enter two positive integers to set the interval");
        Console.Write("Input first integer: ");
        int first = int.Parse(Console.ReadLine());
        while(first < 0) //Check first number is valid
        {
            Console.Write("Invalid input! Enter positive integer: ");
            first = int.Parse(Console.ReadLine());
        }
        Console.Write("Input second integer: ");
        int second = int.Parse(Console.ReadLine());
        while(second < 0 || second <= first) //Check second number is valid
        {
            Console.Write("Invalid input! Enter positive integer bigger than the first: ");
            second = int.Parse(Console.ReadLine());
        }
        Console.WriteLine("The interval is [{0} - {1}]",first,second);
        int counter = 0;
        for(int i = first; i <=second; i++) //Check interval
        {
            if(i % 5 == 0)
            {
                counter++; //Increminate the number of integers
            }
        }
        Console.WriteLine("p={0}",counter);
    }
}