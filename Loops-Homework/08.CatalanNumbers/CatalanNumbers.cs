using System;
using System.Numerics;
class CatalanNumbers
{
    static void Main()
    {
        //Write a program to calculate the nth Catalan number by given n (1 < n < 100).

        Console.Write("Enter number 1 < n < 100: ");
        string input = Console.ReadLine();
        int n;
        while (!int.TryParse(input,out n) || (n <= 1) || (n >= 100)) //Check data is valid
        {
            Console.Write("Invalid input!Enter again!\nn: ");
            input = Console.ReadLine();
        }
        //Calculate factorials
        BigInteger factorialOne = 1;
        BigInteger factorialTwo = 1;
        BigInteger factorialThree = 1;
        for (int i = 1; i <= 2 * n; i++)
        {
            factorialOne *= i;
        }
        for (int i = 1; i <= n + 1; i++)
        {
            factorialTwo *= i;
        }
        for (int i = 1; i <= n; i++)
        {
            factorialThree *= i;
        }
        Console.WriteLine(factorialOne / (factorialTwo * factorialThree));
    }
}