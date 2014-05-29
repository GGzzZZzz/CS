using System;
using System.Numerics;

class FibonacciNumbers
{
    static void Main()
    {
        //Write a program that reads a number n and prints on the console the first n members of the Fibonacci sequence (at a single line, separated by spaces) : 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, …. Note that you may need to learn how to use loops.
        Console.Write("Enter number n: ");
        int n = int.Parse(Console.ReadLine());
        BigInteger numOne = 0;
        BigInteger numTwo = 1;
        BigInteger nextNum;
        if (n == 1)
        {
            Console.WriteLine(numOne); //Print the first member
        }
        else if (n == 2)
        {
            Console.Write("{0} {1} \n", numOne, numTwo); //Print the first and second members
        }
        else
        {
            Console.Write("{0} {1} ", numOne, numTwo); //Print the first and second members
            for (int i = 2; i < n; i++)
            {
                nextNum = numOne + numTwo; //Calculate the next member
                Console.Write("{0} ", nextNum); //Print the next member
                numOne = numTwo; //Second becomes first
                numTwo = nextNum; //Next becomes second
            }
        }
    }
}