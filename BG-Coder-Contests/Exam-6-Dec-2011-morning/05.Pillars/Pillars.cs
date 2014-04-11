using System;
class Pillars
{
    static void Main()
    {
        int[] number = new int[8];
        int pillar = -1;
        int countCells = -1;

        for (int i = 0; i < number.Length; i++)
        {
            number[i] = int.Parse(Console.ReadLine());
        }

        for (int i = 7; i >= 0; i--) //i=pillar
        {
            int leftCount = 0;
            int rightCount = 0;

            for (int nums = 0; nums < 8; nums++)
            {
                for (int shift = 0; shift < i; shift++)
                {
                    int bit = (number[nums] >> shift) & 1;
                    if (bit == 1) rightCount++;
                }
                for (int shift = i + 1; shift < 8; shift++)
                {
                    int bit = (number[nums] >> shift) & 1;
                    if (bit == 1) leftCount++;
                }
            }

            if (leftCount == rightCount)
            {
                pillar = i;
                countCells = leftCount;
                break;
            }
        }
        if (pillar > -1)
        {
            Console.WriteLine(pillar);
            Console.WriteLine(countCells);
        }
        else Console.WriteLine("No");
    }
}