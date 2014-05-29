using System;
class UKflag
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        for (int i = 1; i <= n/2; i++)
        {
            Console.Write(new string('.', i - 1));
            Console.Write("\\");
            Console.Write(new string('.', n/2-i));
            Console.Write("|");
            Console.Write(new string('.', n / 2 - i));
            Console.Write("/");
            Console.Write(new string('.', i - 1));
            Console.WriteLine();
        }
        Console.Write(new string('-',n/2));
        Console.Write("*");
        Console.WriteLine(new string('-',n/2));
        for (int i = n/2; i > 0; i--)
        {
            Console.Write(new string('.', i-1));
            Console.Write("/");
            Console.Write(new string('.', n / 2 - i));
            Console.Write("|");
            Console.Write(new string('.', n / 2 - i));
            Console.Write("\\");
            Console.Write(new string('.', i - 1));
            Console.WriteLine();
        }
    }
}