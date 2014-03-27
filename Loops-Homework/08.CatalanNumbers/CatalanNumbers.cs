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
        //Calculate factoriels
        BigInteger factorielOne = 1;
        BigInteger factorielTwo = 1;
        BigInteger factorielThree = 1;
        for (int i = 1; i <= 2 * n; i++)
        {
            factorielOne *= i;
        }
        for (int i = 1; i <= n + 1; i++)
        {
            factorielTwo *= i;
        }
        for (int i = 1; i <= n; i++)
        {
            factorielThree *= i;
        }
        Console.WriteLine(factorielOne / (factorielTwo * factorielThree));
    }
}