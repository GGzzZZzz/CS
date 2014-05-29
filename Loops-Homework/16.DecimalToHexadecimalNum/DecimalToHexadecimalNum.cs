using System;
using System.Collections.Generic;
class DecimalToHexadecimalNum
{
    static void Main()
    {
        //Using loops write a program that converts an integer number to its hexadecimal representation. The input is entered as long. The output should be a variable of type string. Do not use the built-in .NET functionality.

        Console.Write("Enter integer number: ");
        long decimalNum = long.Parse(Console.ReadLine());
        List<long> hex = new List<long>(); //Create list
        while (decimalNum > 0)
        {
            hex.Add(decimalNum % 16);
            decimalNum /= 16;
        }
        hex.Reverse(); //Reverse the list
        string[] result = new string[hex.Count];
        for (int i = 0; i < hex.Count; i++)
        {
            result[i] = hex[i].ToString("X");

        }
        DateTime old = DateTime.Now;
        string hexNum = string.Join("", result); //Concate elements into string
        Console.WriteLine(hexNum);
    }
}