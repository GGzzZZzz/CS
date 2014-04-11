using System;
using System.Numerics;
class Tribonacci
{
    static void Main()
    {
        BigInteger num1 = int.Parse(Console.ReadLine());
        BigInteger num2 = int.Parse(Console.ReadLine());
        BigInteger num3 = int.Parse(Console.ReadLine());
        uint n = uint.Parse(Console.ReadLine());
        BigInteger nextNum = 0;
        if (n == 1)
        {
            nextNum = num1;
            Console.WriteLine(nextNum);
        }
        else if (n == 2)
        {
            nextNum = num2;
            Console.WriteLine(nextNum);
        }
        else if (n == 3)
        {
            nextNum = num3;
            Console.WriteLine(nextNum);
        }
        else
        {
            for (int i = 0; i < n - 3; i++)
            {
                nextNum = num1 + num2 + num3;
                num1 = num2;
                num2 = num3;
                num3 = nextNum;
            }
            Console.WriteLine(nextNum);
        }
    }
}