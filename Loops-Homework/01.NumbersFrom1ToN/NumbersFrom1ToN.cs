using System;
class NumbersFrom1ToN
{
    static void Main()
    {
        //Write a program that enters from the console a positive integer n and prints all the numbers from 1 to n, on a single line, separated by a space. 

        Console.Write("Enter positive integer number: ");
        string input = Console.ReadLine();
        int num;
        while(!int.TryParse(input,out num) || (num < 1))
        {
            Console.Write("Invalid input!Try again: ");
            input = Console.ReadLine();
        }
        for (int i = 1; i <= num; i++)
        {
            Console.Write(i);
            if(i < num) //Ignore the last interval
            {
                Console.Write(" ");
            }
        }
        Console.WriteLine();
    }
}