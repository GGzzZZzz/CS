using System;
class BinaryToDecimalNum
{
    static void Main()
    {
        //Using loops write a program that converts a binary integer number to its decimal form. The input is entered as string. The output should be a variable of type long. Do not use the built-in .NET functionality.

        Console.Write("Enter binary integer number: ");
        string binary = Console.ReadLine();
        byte[] bytes = new byte[binary.Length];//Initialize an array
        for (int i = 0; i < bytes.Length; i++)
        {
            bytes[i] = Convert.ToByte(binary.Substring(i, 1)); //Fill the array
        }
        int power = bytes.Length - 1;
        long decimalNum = 0;
        for (int i = 0; i < bytes.Length; i++)
        {
            decimalNum += bytes[i] * (long)Math.Pow(2, power);
            power--;
        }
        Console.WriteLine(decimalNum);
    }
}