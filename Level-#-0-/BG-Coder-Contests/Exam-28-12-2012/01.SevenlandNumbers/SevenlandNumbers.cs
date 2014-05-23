using System;
class SevenlandNumbers
{
    static void Main()
    {
        int num = int.Parse(Console.ReadLine());
        int remainder = num % 10;
        int remainderTwo = num % 100;
        if (remainder == 6)
        {
            if (num == 666)
            {
                num += 334;
            }
            else if (remainderTwo == 66)
            {
                num += 34;
            }
            else if (remainderTwo < 66)
            {
                num += 4;
            }
        }
        else
        {
            num += 1;
        }
        Console.WriteLine(num);
    }
}