using System;
using System.Collections.Generic;
class CatchTheBits
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
        string str = "";
        for (int i = 1; i < bits.Count; i += step)
        {
            str += bits[i];
        }
        if (str.Length < 8)
        {
            str = Convert.ToString(str).PadRight(8, '0');
        }
        else if (str.Length > 8 && str.Length < 16)
        {
            str = Convert.ToString(str).PadRight(16, '0');
        }
        else if (str.Length > 16 && str.Length < 32)
        {
            str = Convert.ToString(str).PadRight(32, '0');
        }
        else if (str.Length > 32 && str.Length < 64)
        {
            str = Convert.ToString(str).PadRight(64, '0');
        }
        else if (str.Length > 64 && str.Length < 128)
        {
            str = Convert.ToString(str).PadRight(128, '0');
        }
        else if (str.Length > 128 && str.Length < 256)
        {
            str = Convert.ToString(str).PadRight(256, '0');
        }
        else if (str.Length > 256 && str.Length < 512)
        {
            str = Convert.ToString(str).PadRight(512, '0');
        }
        else if (str.Length > 512 && str.Length < 1024)
        {
            str = Convert.ToString(str).PadRight(1024, '0');
        }
        
        int counter = 0;
        int lenght = 8;
        string bin = "";
        for (int i = 0; i < str.Length/8; i++)
        {
            for (int j = counter; j < lenght; j++)
            {
                bin += str[j];
                counter++;
            }
            uint result = Convert.ToUInt32(bin, 2);
            Console.WriteLine(result);
            lenght += 8;
            bin = "";
        }
    }
}