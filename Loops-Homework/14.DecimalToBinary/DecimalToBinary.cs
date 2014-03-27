using System;
using System.Collections.Generic;
class DecimalToBinary
{
    static void Main()
    {
        //Using loops write a program that converts an integer number to its binary representation. The input is entered as long. The output should be a variable of type string. Do not use the built-in .NET functionality.

        long decimalNum = long.Parse(Console.ReadLine());
        List<long> binList = new List<long>();
        while (decimalNum > 0)
        {
            binList.Add(decimalNum % 2);
            decimalNum /= 2;
        }
        string binary;
        //for (int i = binList.Count- 1; i >= 0; i--)
        //{
            
        //}
        binList.Reverse();
        binary = Convert.ToString(binList);

        Console.WriteLine(binList);
    }
}