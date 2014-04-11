using System;
using System.Globalization;
using System.Numerics;
class Test
{
    static void Main()
    {
        try
        {
            CultureInfo bgBG = new CultureInfo("bg-BG");
            string dateString = Console.ReadLine();
            DateTime startDate = DateTime.ParseExact(dateString, "d.MM.yyyy", bgBG);
            dateString = Console.ReadLine();
            DateTime endDate = DateTime.ParseExact(dateString, "d.MM.yyyy", bgBG);

            TimeSpan difference = endDate - startDate;
            Console.WriteLine(difference.Days);
        }
        catch (FormatException)
        {
            Console.WriteLine("Invalid date! Dates must be in format dd.MM.yyyy.");
        }
    }
}