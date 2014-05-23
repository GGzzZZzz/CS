using System;
using System.Globalization;
class BeerTime
{
    static void Main()
    {
        //A beer time is after 1:00 PM and before 3:00 AM. Write a program that enters a time in format “hh:mm tt” (an hour in range [01...12], a minute in range [00…59] and AM / PM designator) and prints “beer time” or “non-beer time” according to the definition above or “invalid time” if the time cannot be parsed. Note that you may need to learn how to parse dates and times.

        string startBeerTime = "1:00 PM";
        string endBeerTime = "3:00 AM";
        string preMidnight = "23:59 PM";
        string midnight = "12:00 AM";
        DateTime start = Convert.ToDateTime(startBeerTime);
        DateTime end = Convert.ToDateTime(endBeerTime);
        DateTime preMid = Convert.ToDateTime(preMidnight);
        DateTime mid = Convert.ToDateTime(midnight);
        DateTime time;
        Console.Write("Enter time in format h:mm tt: ");
        string input = Console.ReadLine();
        if (DateTime.TryParseExact(input, "h:mm tt", CultureInfo.CreateSpecificCulture("en-US"), DateTimeStyles.None, out time))
        {
            if (time >= start && time <= preMid)
            {
                Console.WriteLine("Beer time!");
            }
            else if (time >= mid && time < end)
            {
                Console.WriteLine("Beer time!");
            }
            else
            {
                Console.WriteLine("Non-beer time!");
            }
        }
        else
        {
            Console.WriteLine("Invalid time!");
        }
    }
}