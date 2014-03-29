using System;
using System.Numerics;
class CalculateNumOfCombinatorics
{
    static void Main()
    {
        //        In combinatorics, the number of ways to choose k different members out of a group of n different elements (also known as the number of combinations) is calculated by the following formula:

        //For example, there are 2598960 ways to withdraw 5 cards out of a standard deck of 52 cards. Your task is to write a program that calculates n! / (k! * (n-k)!) for given n and k (1 < k < n < 100). Try to use only two loops. 

        Console.Write("Enter number n < 100: ");
        string inputN = Console.ReadLine();
        Console.Write("Enter number 1 < k < n: ");
        string inputK = Console.ReadLine();
        int n, k;
        //Check data is valid
        while (!int.TryParse(inputN, out n) || (!int.TryParse(inputK, out k)) || (n >= 100) || (k <= 1) || (k >= n))
        {
            Console.WriteLine("Incorrect input data! Enter again!");
            Console.Write("n: ");
            inputN = Console.ReadLine();
            Console.Write("k: ");
            inputK = Console.ReadLine();
        }
        //Calculate factorials
        BigInteger factorialN = 1;
        BigInteger factorialK = 1;
        BigInteger factorielM = 1; //(n-k)!
        for (int i = 1; i <= n; i++) //Using only one loop
        {
            factorialN *= i;
            if (i <= k)
            {
                factorialK *= i;
            }
            if (i <= n - k)
            {
                factorielM *= i;
            }
        }
        Console.WriteLine(factorialN / (factorialK *(factorielM)));
    }
}