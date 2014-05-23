using System;
class OddEvenSum
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int oddSum = 0;
        int evenSum = 0;
        for (int i = 1; i < n*2+ 1; i++)
        {
            int nextNum = int.Parse(Console.ReadLine());
            if (i % 2 != 0)
            {
                oddSum += nextNum;
            }
            else
            {
                evenSum += nextNum;
            }
        }
        if (oddSum == evenSum)
        {
            Console.WriteLine("Yes, sum={0}",oddSum);
        }
        else
        {
            Console.WriteLine("No, diff={0}",Math.Abs(oddSum-evenSum));
        }
    }
}