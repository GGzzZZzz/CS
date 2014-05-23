using System;
class BitSifting
{
    static void Main()
    {
        long number = long.Parse(Console.ReadLine());
        int sieves = int.Parse(Console.ReadLine());
        for (int i = 0; i < sieves; i++)
        {
            long sieve = long.Parse(Console.ReadLine());
            number = number & (~sieve);
        }
        int counter = 0;
        //Count '1' bits
        string binary = Convert.ToString(number, 2).PadLeft(64,'0');
        foreach (char bit in binary)
        {
            switch (bit)
            {
                case '1': counter++; break;
            }
        }
        Console.WriteLine(counter);
    }
}