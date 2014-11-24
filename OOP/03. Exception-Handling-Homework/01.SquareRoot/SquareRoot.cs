/*Write a program that reads an integer number and calculates and prints its square root. If the number is invalid or negative, print "Invalid number". In all cases finally print "Good bye". Use try-catch-finally.*/

using System;

internal class SquareRoot
{
    public static void Main()
    {
        try
        {
            uint num = uint.Parse(Console.ReadLine());
            Console.WriteLine(Math.Sqrt(num));
        } 
        catch (FormatException)
        {
            Console.WriteLine("Invalid number!");
        }
        catch (OverflowException)
        {
            Console.WriteLine("Invalid number!");
        }   
        finally
        {
            Console.WriteLine("Good bye!");
        }
    }
}