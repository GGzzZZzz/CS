using System;

public class StringDisperserTester
{
    public static void Main()
    {
        var stringDispersers = new StringDisperser[]
            {
                new StringDisperser("gosho", "pesho", "tanio"),
                new StringDisperser("boicho", "mircho", "petko"),
                new StringDisperser("siso", "krisko", "krasi"),
            };

        Array.Sort(stringDispersers);

        foreach (var stringDisperser in stringDispersers)
        {
            Console.WriteLine(stringDisperser);
        }

        Console.WriteLine();

        Console.WriteLine(stringDispersers[0].Equals(stringDispersers[1]));
        Console.WriteLine(stringDispersers[0].Equals(stringDispersers[0]));
        Console.WriteLine();

        foreach (var stringDisperser in stringDispersers)
        {
            foreach (var ch in stringDisperser)
            {
                Console.Write(ch + " ");
            }

            Console.WriteLine();
        }
    }
}