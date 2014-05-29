using System;
class Anacci
{
    static void Main()
    {
        char firstLetter = char.Parse(Console.ReadLine());
        char secondLetter = char.Parse(Console.ReadLine());
        int lines = int.Parse(Console.ReadLine());
        int sum = 0;
        char nextLetter;
        if (lines == 1)
        {
            Console.WriteLine(firstLetter);
        }
        else if (lines > 1)
        {
            Console.WriteLine(firstLetter);
            Console.Write(secondLetter);
            nextLetter = CalculateNextLetter(firstLetter, secondLetter, sum);
            Console.WriteLine(nextLetter);
            firstLetter = secondLetter;
            secondLetter = nextLetter;
            if (lines > 2)
            {
                for (int i = 0; i < lines - 2; i++)
                {
                    //Invoce method twise per line
                    nextLetter = CalculateNextLetter(firstLetter, secondLetter, sum);
                    Console.Write("{0}{1}", nextLetter, new string(' ', i + 1));
                    firstLetter = secondLetter;
                    secondLetter = nextLetter;
                    nextLetter = CalculateNextLetter(firstLetter, secondLetter, sum);
                    Console.WriteLine("{0}", nextLetter);
                    firstLetter = secondLetter;
                    secondLetter = nextLetter;
                }
            }
        }
    }

    private static char CalculateNextLetter(char firstLetter, char secondLetter, int sum)
    {
        char nextLetter;
        sum = (firstLetter - 64) + (secondLetter - 64);
        if (sum > 26)
        {
            sum %= 26;
        }
        nextLetter = (char)(sum + 64);

        return nextLetter;
    }
}