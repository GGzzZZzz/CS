using System;
using System.Collections.Generic;
class DecimalToBinary
{
    static void Main()
    {
        //Using loops write a program that converts an integer number to its binary representation. The input is entered as long. The output should be a variable of type string. Do not use the built-in .NET functionality.

        Console.Write("Enter integer number: ");
        long decimalNum = long.Parse(Console.ReadLine());
        List<long> binList = new List<long>(); //Create list
        while (decimalNum > 0)
        {
            binList.Add(decimalNum % 2); //Add new byte
            decimalNum /= 2;
        }
        binList.Reverse(); //Reverse the list
        string binary = string.Join("", binList.ToArray()); //Convert to string array and concate elements into string
        Console.WriteLine(binary);

        //Built-in functionality:
        //string binary = Convert.ToString(decimalNum,2);
    }
}