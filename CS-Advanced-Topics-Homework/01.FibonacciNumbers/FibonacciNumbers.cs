using System;
using System.Numerics;
class FibonacciNumbers
{
    static void Main()
    {
        //Define a method Fib(n) that calculates the nth Fibonacci number.

        int n = int.Parse(Console.ReadLine());
         Fib(n);
    }
    static void Fib(int n)
    {
        BigInteger numOne = 0;
        BigInteger numTwo = 1;
        BigInteger nextNum;
        for (int i = 1; i <= n; i++)
        {
            nextNum = numOne + numTwo;
            numOne = numTwo;
            numTwo = nextNum;
        }
        Console.WriteLine(nextNum);
    }
}