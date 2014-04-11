using System;
using System.Globalization;
class DifferenceBetweenDates
{
    static void Main()
    {
        //Write a program that enters two dates in format dd.MM.yyyy and returns the number of days between them.
        CultureInfo bg = new CultureInfo("bg-BG");
        string firstInput = Console.ReadLine();
        DateTime firstDate = DateTime.ParseExact(firstInput, "d.MM.yyyy", bg);
        string secondInput = Console.ReadLine();
        DateTime secondDate = DateTime.ParseExact(secondInput, "d.MM.yyyy", bg);
        int days = (int)NumberOfDays(firstDate, secondDate);
        Console.WriteLine(days);
    }
    static double NumberOfDays(DateTime first,DateTime second)
    {
        TimeSpan difference = second - first;
        int result = (int)difference.TotalDays;
        return result;
    }
}