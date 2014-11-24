/*Write a method ReadNumber(int start, int end) that enters an integer number in given range [start…end]. If an invalid number or non-number text is entered, the method should throw an exception. Using this method write a program that enters 10 numbers: a1, a2, … a10, such that 1 < a1 < … < a10 < 100. If the user enters an invalid number, let the user to enter again.*/

using System;

internal class EnterNumbers
{
    public static void Main()
    {
        int start = 0;
        int end = 100;
        int num = -1;
        int nextNum = 0;

        for (int i = 0; i < 10; i++)
        {
            try
            {
                nextNum = ReadNumbers(start, end);
                if (nextNum <= num)
                {
                    throw new ArgumentException();
                }

                num = nextNum;
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("Number should be in range [{0}...{1}]! Enter again:", nextNum, end);
                i--;
            }
            catch (ArgumentException)
            {
                Console.WriteLine("Number should be greater than {0}! Enter again:", num);
                i--;
            }
            catch (FormatException)
            {
                Console.WriteLine("Entered data is not a number! Enter again:");
                i--;
            }
        }
    }

    public static int ReadNumbers(int start, int end)
    {
        string input = Console.ReadLine();
        int num;
        if (!int.TryParse(input, out num))
        {
            throw new FormatException();
        }
        else if (num < start || num > end)
        {
            throw new ArgumentOutOfRangeException();
        }

        return num;
    }
}