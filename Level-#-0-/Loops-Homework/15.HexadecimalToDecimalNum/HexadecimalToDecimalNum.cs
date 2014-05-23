using System;
class HexadecimalToDecimalNum
{
    static void Main()
    {
        //Using loops write a program that converts a hexadecimal integer number to its decimal form. The input is entered as string. The output should be a variable of type long. Do not use the built-in .NET functionality.

        Console.Write("Enter hexadecimal");
        string input = Console.ReadLine();
        string[] hex = new string[input.Length]; //Create an array
        for (int i = 0; i < hex.Length; i++)
        {
            hex[i] = Convert.ToString(input.Substring(i, 1)); //Fill the array
        }
        int power = 0;
        long decimalNum = 0;
        Array.Reverse(hex); //Reverse the array
        for (int i = 0; i < hex.Length; i++)
        {
            decimalNum += Convert.ToInt32(hex[i], 16) * (long)Math.Pow(16, power);
            power++;
        }
        Console.WriteLine(decimalNum);

        // Built-in functionality:
        // int hex = Convert.ToInt32(input, 16);
    }
}