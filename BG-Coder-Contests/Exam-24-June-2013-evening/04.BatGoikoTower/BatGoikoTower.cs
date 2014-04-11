using System;
class BatGoikoTower
{
    static void Main()
    {
        int height = int.Parse(Console.ReadLine());
        int dashRowIndex = 1;
        int dashRowIncrement = 1;
        for (int i = 0; i < height; i++)
        {
            Console.Write(new string('.',height - 1 - i));
            Console.Write('/');
            if (dashRowIndex == i)
            {
                Console.Write(new string('-',i * 2));
                dashRowIncrement++;
                dashRowIndex += dashRowIncrement;
            }
            else
            {
                Console.Write(new string('.', i * 2));
            }
            Console.Write("\\");
            Console.WriteLine(new string('.',height - 1 - i));
        }
    }
}