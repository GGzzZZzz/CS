using System;
class OnesAndZeros
{
    static void Main()
    {
        uint n = uint.Parse(Console.ReadLine());
        string binary = Convert.ToString(n, 2).PadLeft(32,'0');
        for (int i = 0; i < 5; i++)
        {
            for (int j = 16; j < binary.Length; j++)
            {
                if(i == 0)
                {
                    if (binary[j] == '0')
                    {
                        Console.Write("###");
                    }
                    else
                    {
                        Console.Write(".#.");
                    }
                    if(j < binary.Length-1)
                    {
                        Console.Write('.');
                    }
                }
                if(i == 1)
                {
                    if (binary[j] == '0')
                    {
                        Console.Write("#.#");
                    }
                    else
                    {
                        Console.Write("##.");
                    }
                    if (j < binary.Length - 1)
                    {
                        Console.Write('.');
                    }
                }
                if((i == 2) || (i == 3))
                {
                    if (binary[j] == '0')
                    {
                        Console.Write("#.#");
                    }
                    else
                    {
                        Console.Write(".#.");
                    }
                    if (j < binary.Length - 1)
                    {
                        Console.Write('.');
                    }
                }
                if(i == 4)
                {
                    Console.Write("###");
                    if (j < binary.Length - 1)
                    {
                        Console.Write('.');
                    }
                }
            }
            Console.WriteLine();
        }
    }
}