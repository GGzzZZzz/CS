using System;
class TelerikLogo
{
    static void Main()
    {
        int x = 7;
        int z = (x / 2) + 1;
        int width = (x * 3) - 2;
        Console.Write(new string('.', z - 1));
        Console.Write("*");
        Console.Write(new string('.', width - x - 1));
        Console.Write("*");
        Console.WriteLine(new string('.', z - 1));

        Console.Write(new string('.', z - 2));
        Console.Write("*");
        Console.Write(new string('.', 1));
        Console.Write("*");
        Console.Write(new string('.', width - x - 3));
        Console.Write("*");
        Console.Write(new string('.', 1));
        Console.Write("*");
        Console.WriteLine(new string('.', z - 2));
        if (x > 3)
        {
            for (int i = 0, k = 3; i < x / 2 - 1; i++, k += 2)
            {
                Console.Write("*");
                Console.Write(new string('.', k));
                Console.Write("*");
                Console.Write(new string('.', k));
                Console.Write("*");
                Console.Write(new string('.', k));
                Console.WriteLine("*");
            }
            for (int i = 0, k = 1; i < x / 2 - 1; i++, k += 2)
            {
                Console.Write(new string('.', x));
                Console.Write("*");
                Console.Write(new string('.', k));
                Console.Write("*");
                Console.WriteLine(new string('.', x));
            }
        }
        //Console.Write(new string('.',width/2));
        //Console.Write("*");
        //Console.WriteLine(new string('.', width / 2));
        //for (int i = 0, k = 1; i < x - 1; i++,k+=2)
        //{
        //    Console.Write(new string('.', width/2-1-i));
        //    Console.Write("*");
        //    Console.Write(new string('.',k));
        //    Console.Write("*");
        //    Console.WriteLine(new string('.', width/2-1 -i));
        //}
        //for (int i = 0, k = width-x-3; i < x-2; i++, k -= 2)
        //{
        //    Console.Write(new string('.', z + i));
        //    Console.Write("*");
        //    Console.Write(new string('.', k));
        //    Console.Write("*");
        //    Console.WriteLine(new string('.', z + i));
        //}
        //Console.Write(new string('.', width / 2));
        //Console.Write("*");
        //Console.WriteLine(new string('.', width / 2));

        //}
    }
}






