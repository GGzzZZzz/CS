using System;
using System.Collections.Generic;
class BitsUp
{
    static void Main()
    {
        int numberOfBytes = int.Parse(Console.ReadLine());
        int step = int.Parse(Console.ReadLine());
        string binary = "";
        for (int i = 0; i < numberOfBytes; i++)
        {
            int number = int.Parse(Console.ReadLine());
            binary += Convert.ToString(number, 2).PadLeft(8, '0');
        }
        List<char> bits = new List<char>();
        for (int i = 0; i < binary.Length; i++)
        {
            bits.Add(binary[i]);
        }
        for (int i = 1; i < bits.Count; i += step)
        {
            bits[i] = '1';
        }
        string bin = "";
        int counter = 0;
        int lenght = 8;
        for (int i = 0; i < numberOfBytes; i++)
        {
            for (int j = counter; j < lenght ; j++)
            {
                 bin += bits[j];
                 counter++;
            }
            uint result = Convert.ToUInt32(bin,2);
            Console.WriteLine(result);
            lenght += 8;
            bin = "";
        }
    }
}