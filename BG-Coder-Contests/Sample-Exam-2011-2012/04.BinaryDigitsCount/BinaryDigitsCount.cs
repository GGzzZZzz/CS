using System;
using System.Collections.Generic;
class BinaryDigitsCount
{
    static void Main()
    {
        int b = int.Parse(Console.ReadLine());
        int n = int.Parse(Console.ReadLine());
        List<long> binList = new List<long>();
        int counter = 0;
      
        for(int i = 0; i < n; i++)
        {
            long number = long.Parse(Console.ReadLine());
            while (number > 0)
            {
                binList.Add(number % 2);
                number = number / 2;
            }
            for(int j = 0; j < binList.Count + j; j++)
            {
                if(binList[0] == b)
                {
                    counter++;
                }
                binList.Remove(binList[0]);
            }
            Console.WriteLine(counter);
            counter = 0;
        }
    }
}