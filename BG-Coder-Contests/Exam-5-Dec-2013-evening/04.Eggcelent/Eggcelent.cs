using System;
class Eggcelent
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int height = 2 * n;
        int width = (3 * n) - 1;
        int widthD = (3 * n) + 1;
        int top = n - 1;
        int bottom = n - 1;
        //Top
        Console.WriteLine("{0}{1}{0}",new string('.',n + 1),new string('*',top));
        int outerDots = n - 1;
        int innerDots = n + 1;
        int counter = 0;
        for (int i = 0; i < height - n - 2; i++)
        {
            Console.WriteLine("{0}*{1}*{0}",new string('.',outerDots),new string('.',innerDots));
            innerDots+=4;
            outerDots-=2;
            if (outerDots < 0)
            {
                outerDots = 1;
                counter++;
            }
            if (innerDots > width)
            {
                innerDots = width - 2;
            }
        }
        //Middle
        Console.Write(".*");
        for (int i = 0; i < width/2; i++)
        {
            Console.Write("@");
            if(i > width/2-2)
            {
                break;
            }
            Console.Write(".");
        }
        Console.WriteLine("*.");
        Console.Write(".*");
        for (int i = 0; i < width / 2; i++)
        {
            Console.Write(".");
            if (i > width / 2 - 2)
            {
                break;
            }
            Console.Write("@");
        }
        Console.WriteLine("*.");
        //Bottom
        int innerDots2 = 1;
        int outerDots2 = width - 2;
        for (int i = 0; i < height - n - 2; i++)
        {
            Console.WriteLine("{0}*{1}*{0}", new string('.', innerDots2), new string('.', outerDots2));
            if (counter-1 > i) 
            {
                innerDots2 = widthD - width - 1;
                outerDots2 = width - 2;
            }
            else
            {
                innerDots2 += 2;
                outerDots2 -= 4;
            }
        }
        Console.WriteLine("{0}{1}{0}",new string('.',n +1),new string('*',bottom));
    }
}