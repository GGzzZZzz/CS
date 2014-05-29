using System;
class HayvanNumbers
{
    static void Main()
    {
        int sum = int.Parse(Console.ReadLine());
        int diff = int.Parse(Console.ReadLine());
        bool match = false;
        for (int firstNum = 555; firstNum <=999; firstNum++)
        {
            int secondNum = firstNum + diff;
            int thirdNum = secondNum + diff;
            if (CheckNumberIsValid(firstNum) && CheckNumberIsValid(secondNum) && CheckNumberIsValid(thirdNum) && CalculateSum(firstNum) + CalculateSum(secondNum) + CalculateSum(thirdNum) == sum && thirdNum <= 999)
            {
                match = true;
                Console.WriteLine("{0}{1}{2}",firstNum,secondNum,thirdNum);
            }
        }
        if (!match)
        {
            Console.WriteLine("No");
        }
    }

    private static int CalculateSum(int firstNum)
    {
        int sumOfDigits = 0;
        while (firstNum > 0)
        {
            sumOfDigits += firstNum % 10;
            firstNum /= 10;
        }
        return sumOfDigits;
    }

    private static bool CheckNumberIsValid(int firstNum)
    {
        string digits = firstNum.ToString();
        foreach (char digit in digits)
        {
            if (digit < '5' || digit > '9')
            {
                return false;
            }
        }
        return true;
    }
}