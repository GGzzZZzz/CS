using System;
using System.Numerics;
class CalculateDivision
{
    static void Main()
    {
        //Write a program that calculates n! / k! for given n and k (1 < k < n < 100). Use only one loop.

        Console.Write("Enter number n < 100: ");
        string inputN = Console.ReadLine();
        Console.Write("Enter number 1 < k < n: ");
        string inputK = Console.ReadLine();
        int n,k;
        //Check data is valid
        while (!int.TryParse(inputN,out n) || (!int.TryParse(inputK,out k)) || (n >= 100) || (k <= 1) || (k >= n))
        {
            Console.WriteLine("Incorrect input data! Enter again!");
            Console.Write("n: ");
            inputN = Console.ReadLine();
            Console.Write("k: ");
            inputK = Console.ReadLine();
        }
        //Calculate factoriels
        BigInteger factorielN = 1;
        BigInteger factorielK = 1;
        for (int i = 1; i <= n; i++)
        {
            factorielN *= i;
            if (i <= k)
            {
                factorielK *= i;
            }
        }
        Console.WriteLine(factorielN / factorielK);
    }
}