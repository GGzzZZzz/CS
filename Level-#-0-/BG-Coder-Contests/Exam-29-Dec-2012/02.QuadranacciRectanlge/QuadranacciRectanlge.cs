using System;
class QuadranacciRectanlge
{
    static void Main()
    {
        long a = long.Parse(Console.ReadLine());
        long b = long.Parse(Console.ReadLine());
        long c = long.Parse(Console.ReadLine());
        long d = long.Parse(Console.ReadLine());
        byte rows = byte.Parse(Console.ReadLine());
        byte cols = byte.Parse(Console.ReadLine());
        byte n = 4;
        long nextNum = 0;
        if (cols == n)
        {
            Console.WriteLine("{0} {1} {2} {3}", a, b, c, d);
            for (int i = 0; i < rows - 1; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    nextNum = a + b + c + d;
                    a = b;
                    b = c;
                    c = d;
                    d = nextNum;
                    Console.Write(nextNum);
                    if(j < cols-1) //Ignore the last space
                    {
                        Console.Write(" ");
                    }
                }
                if(i < rows - 2) // Ignore tne last empty line
                {
                    Console.WriteLine();
                }
            }
        }
        else
        {
            Console.Write("{0} {1} {2} {3} ", a, b, c, d);
            for (int i = n; i < cols; i++)
            {
                nextNum = a + b + c + d;
                a = b;
                b = c;
                c = d;
                d = nextNum;
                Console.Write(nextNum);
                if(i < cols -1)
                {
                    Console.Write(" ");
                }
            }
            Console.WriteLine();
            for (int i = 0; i < rows - 1; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    nextNum = a + b + c + d;
                    a = b;
                    b = c;
                    c = d;
                    d = nextNum;
                    Console.Write(nextNum);
                    if (j < cols - 1)
                    {
                        Console.Write(" ");
                    }
                }
                if (i < rows - 2)
                {
                    Console.WriteLine();
                }
            }
        }
    }
}