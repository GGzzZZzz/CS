using System;

class NumberComparer
{
    static void Main()
    {
        //Write a program that gets two numbers from the console and prints the greater of them. Try to implement this without if statements.

        Console.WriteLine("Enter two numbers");
        Console.Write("First number = ");
        int firstNum = int.Parse(Console.ReadLine());
        Console.Write("Second number = ");
        int secondnum = int.Parse(Console.ReadLine());
        int greaterNum = Math.Max(firstNum, secondnum);
        Console.WriteLine("The greater number is {0}.", greaterNum);
    }
}
