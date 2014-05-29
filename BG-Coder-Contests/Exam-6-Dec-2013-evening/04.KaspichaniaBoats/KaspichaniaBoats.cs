using System;
class KaspichaniaBoats
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int width = n * 2 + 1;
        int height = 6 + ((n - 3) / 2) * 3;
        char dots = '.' ;
        char asterix = '*';

        Console.Write(new string(dots,n));
        Console.Write(asterix);
        Console.Write(new string(dots, n));
        Console.WriteLine();
        for (int i = 0; i < n - 1; i++)
        {
            Console.Write(new string(dots,n-1-i));
            Console.Write(asterix);
            Console.Write(new string(dots,i));
            Console.Write(asterix);
            Console.Write(new string(dots, i));
            Console.Write(asterix);
            Console.Write(new string(dots, n - 1 - i));
            Console.WriteLine();
        }
        Console.WriteLine(new string(asterix, width));
        for (int i = 0; i < height-n-2; i++)
        {
            Console.Write(new string(dots, i + 1));
            Console.Write(asterix);
            Console.Write(new string(dots, n - 2 - i));
            Console.Write(asterix);
            Console.Write(new string(dots, n - 2 - i));
            Console.Write(asterix);
            Console.Write(new string(dots, i + 1));
            Console.WriteLine();
        }
        Console.Write(new string(dots, (width - n) / 2));
        Console.Write(new string(asterix, n));
        Console.Write(new string(dots, (width - n) / 2));
        Console.WriteLine();
    }
}