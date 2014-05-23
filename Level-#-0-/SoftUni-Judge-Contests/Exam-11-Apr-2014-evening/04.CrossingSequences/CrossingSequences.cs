using System;
class CrossingSequences
{
    static void Main()
    {
        int first = int.Parse(Console.ReadLine());
        int second = int.Parse(Console.ReadLine());
        int third = int.Parse(Console.ReadLine());
        int startNumber = int.Parse(Console.ReadLine());
        int step = int.Parse(Console.ReadLine());
        int nextNumber = first + second + third;
        if (first == startNumber || second == startNumber || third == startNumber || nextNumber == startNumber)
        {
            Console.WriteLine(startNumber);
        }
        first = second;
        second = third;
        third = nextNumber;
        for (int i = 0; i < 100000; i++)
        {
            
            
            nextNumber = first + second + third;
            first = second;
            second = third;
            third = nextNumber;
            startNumber += step;
            if (nextNumber == startNumber)
            {
                Console.WriteLine(nextNumber);
            }
        }

    }
}