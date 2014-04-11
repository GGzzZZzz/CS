using System;

class Secrets
{
    static void Main()
    {
        string input = Console.ReadLine();
        input = input.TrimStart('-'); //ignore negative input
        int specSum = 0;
        int[] digits = new int[input.Length];
        for (int i = 0; i < digits.Length; i++)
        {
            digits[i] = input[i] - '0';
        }
        Array.Reverse(digits);
        for (int i = 0; i < digits.Length; i++)
        {
            if (i % 2 == 0)
            {
                specSum += digits[i] * (int)Math.Pow(i + 1, 2);
            }
            else
            {
                specSum += (int)Math.Pow(digits[i], 2) * (i + 1);
            }
        }
        if (specSum % 10 == 0)
        {
            Console.WriteLine(specSum);
            Console.WriteLine("{0} has no secret alpha-sequence",input);
        }
        else
        {
            int seqLenght = specSum % 10;
            int remainder = specSum % 26;
            char firstLetter = (char)(remainder + 1 + 64);
            Console.WriteLine(specSum);
            Console.Write(firstLetter);
            for (int i = 0; i < seqLenght-1; i++)
            {
                firstLetter++;
                if (firstLetter > (char)90)
                {
                    firstLetter =  (char)(1 + 64);
                }
                Console.Write(firstLetter);
            }
        }
    }
}