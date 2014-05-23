using System;
using System.Numerics;

class P2_4_8
{
    static void Main()
    {
        BigInteger a = int.Parse(Console.ReadLine());
        BigInteger b = int.Parse(Console.ReadLine());
        BigInteger c = int.Parse(Console.ReadLine());
        BigInteger result = 0;
        BigInteger result2 = 0;
        if(b == 2)
        {
            result = a % c;
        }
        else if (b == 4)
        {
            result = a + c;
        }
        else if(b == 8)
        {
            result = a * c;
        }
        if(result % 4 == 0)
        {
            result2 = result / 4;
            Console.WriteLine(result2);
            Console.WriteLine(result);
        }
        else
        {
            result2 = result % 4;
            Console.WriteLine(result2);
            Console.WriteLine(result);
        }
    }
}