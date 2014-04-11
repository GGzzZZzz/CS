using System;
class Fire
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int outerDots = n/2-1;
        int innerDots = 0;
        for (int i = 0; i < n/2; i++)
        {
            Console.Write("{0}#{1}#{0}",new string('.',outerDots - i),new string('.',innerDots));
            Console.WriteLine();
            innerDots += 2;
        }
        outerDots = n - 2;
        innerDots = 0;
        for (int i = 0; i < n / 4; i++)
        {
            Console.Write("{0}#{1}#{0}", new string('.', innerDots + i), new string('.', outerDots));
            Console.WriteLine();
            outerDots -= 2;
        }
        Console.WriteLine(new string('-',n));
        innerDots = 0;
        int outerSlash = n / 2;
        for (int i = 0; i < n/2; i++)
        {
            Console.Write("{0}{1}{2}{0}",new string('.',innerDots + i),new string('\\',outerSlash),new string('/',outerSlash),new string('.',innerDots + i));
            Console.WriteLine();
            outerSlash--;
        }
    }
}