using System;
class _3_6_9
{
    static void Main()
    {
        long a = long.Parse(Console.ReadLine());
        long b = long.Parse(Console.ReadLine());
        long c = long.Parse(Console.ReadLine());
        long result = 0;
        long result2 = 0;
        if (b == 3)
        {
            result = a + c;
        }
        else if(b == 6)
        {
            result = a * c;
        }
        else if(b == 9)
        {
            result = a % c;
        }
        if (result % 3 == 0)
        {
            result2 = result / 3;
        }
        else
        {
            result2 = result % 3;
        }
        Console.WriteLine(result2);
        Console.WriteLine(result);
    }
}