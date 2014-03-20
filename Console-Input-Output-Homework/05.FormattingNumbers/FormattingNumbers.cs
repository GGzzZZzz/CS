using System;

class FormattingNumbers
{
    static void Main()
    {
        //Write a program that reads 3 numbers: an integer a (0 ≤ a ≤ 500), a floating-point b and a floating-point c and prints them in 4 virtual columns on the console. Each column should have a width of 10 characters. The number a should be printed in hexadecimal, left aligned; then the number a should be printed in binary form, padded with zeroes, then the number b should be printed with 2 digits after the decimal point, right aligned; the number c should be printed with 3 digits after the decimal point, left aligned. 

        Console.Write("Enter integer a: ");
        int intA = int.Parse(Console.ReadLine());
        while(intA < 0 || intA > 500) //Check number is valid
        {
            Console.WriteLine("Invalid input! Try again!");
            intA = int.Parse(Console.ReadLine());
        }
        Console.Write("Enter floating point number b: ");
        decimal decimalB = decimal.Parse(Console.ReadLine());
        Console.Write("Enter floating point number c: ");
        decimal decimalC = decimal.Parse(Console.ReadLine());
        Console.Write("{0,-10:x}",intA);
        Console.Write(Convert.ToString(intA, 2).PadLeft(10,'0'));
        Console.Write("{0,10:F2}",decimalB);
        Console.Write("{0,-10:F3}",decimalC);
    }
}