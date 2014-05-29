using System;
using System.Collections.Generic;
class PrimesInGivenRange
{
    static void Main()
    {
        //Write a method that calculates all prime numbers in given range and returns them as list of integers.Write a method to print a list of integers. Write a program that enters two integer numbers (each at a separate line) and prints all primes in their range, separated by a comma.

        int startNum = int.Parse(Console.ReadLine());
        int endNum = int.Parse(Console.ReadLine());
        // Invoce the FindPrimesInRange() method
        List<int> primeNums = FindPrimesInRange(startNum, endNum);
        // Print the list
        for (int i = 0; i < primeNums.Count; i++)
        {
            if(i != primeNums.Count-1) //Ignore the last coma and space
            {
                Console.Write(primeNums[i] + ", ");
            }
            else
            {
                Console.WriteLine(primeNums[i]);
            }
        }
    }
    static List<int> FindPrimesInRange(int start, int end)
    {
        List<int> primeNums = new List<int>();
        for (int i = start; i <= end; i++)
        {
            bool isPrime = true;
            int counter = 1;
            while (counter <= Math.Sqrt(i))
            {
                if (i % counter == 0 && counter > 1)
                {
                    isPrime = false;
                }
                counter++;
            }
            if (isPrime == true)
            {
                if (i < 2)
                {
                    
                }
                else
                {
                    primeNums.Add(i);
                }
            }
        }
        return primeNums;
    }
}