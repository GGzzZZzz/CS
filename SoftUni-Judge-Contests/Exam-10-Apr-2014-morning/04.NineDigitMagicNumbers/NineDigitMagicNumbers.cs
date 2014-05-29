using System;
class NineDigitMagicNumbers
{
    static void Main()
    {
        int sum = int.Parse(Console.ReadLine());
        int diff = int.Parse(Console.ReadLine());
        int start = 111;
        int end = 777;
        bool match = false;
        for (int i = start; i <= end; i++)
        {
            int middleNum = i + diff;
            int rightNum = middleNum + diff;
            if(IsValidNumber(i) && IsValidNumber(middleNum) && IsValidNumber(rightNum) && CalculateSumOfDigits(i) + CalculateSumOfDigits(middleNum) + CalculateSumOfDigits(rightNum) == sum && rightNum <= 777)
            {
                match = true;
                Console.WriteLine("{0}{1}{2}",i,middleNum,rightNum);
            }
        }
        if (!match)
        {
            Console.WriteLine("No");
        }
    }

    private static int CalculateSumOfDigits(int i)
    {
        int sum = 0;
        while (i > 0)
        {
            sum += i % 10;
            i = i / 10;
        }
        return sum;
    }

    private static bool IsValidNumber(int i)
    {
        string digits = i.ToString();
        foreach (char digit in digits)
        {
            if (digit < '1' || digit > '7')
            {
                return false;
            }
        }
        return true;
    }
}