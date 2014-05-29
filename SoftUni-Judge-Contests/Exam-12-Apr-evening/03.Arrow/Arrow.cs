using System;

class Arrow
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int widthPicture = n * 2 - 1;
        Console.WriteLine("{0}{1}{0}",new string('.',(widthPicture-n)/2),new string('#',n),new string('.',(widthPicture -n)/2));
        for (int i = 0; i < widthPicture-n-1; i++)
        {
            Console.WriteLine("{0}#{1}#{0}",new string('.',(widthPicture-n)/2),new string('.',widthPicture-n-1));
        }
        Console.WriteLine("{0}{1}{0}",new string('#',n/2+1),new string('.',widthPicture-n-1));
        int innerDots = 1;
        int outerDots = widthPicture - 4;
        for (int i = 0; i < widthPicture-n-1; i++)
        {
            Console.WriteLine("{0}#{1}#{0}",new string('.',innerDots),new string('.',outerDots));
            innerDots++;
            outerDots -= 2;
        }
        Console.WriteLine("{0}#{0}",new string('.',innerDots));
    }
}