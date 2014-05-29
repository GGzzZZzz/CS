using System;

class Task2
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int innerDots = 1;
        int outerDots = n/2;
        Console.WriteLine("{0}*{0}",new string('.',outerDots),new string('.',outerDots));
        //Console.WriteLine();
        outerDots--;
        for (int i = 0; i < n/2 - 1; i++)
        {
            Console.WriteLine("{0}*{1}*{0}", new string('.', outerDots), new string('.', innerDots), new string('.', outerDots));
            outerDots--;
            innerDots+=2;
            
        }
        Console.WriteLine(new string('*',n));
        int dots1 = n / 4;
        int dots2 = n - (dots1 * 2) - 2;
        for(int i = 0; i < n/2-1; i++)
        {
            Console.WriteLine("{0}*{1}*{0}",new string('.',dots1),new string('.',dots2));
        }
        Console.WriteLine("{0}{1}{0}",new string('.',dots1),new string('*',dots2 + 2),new string('.',dots1));

    }
}

