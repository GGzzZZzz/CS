using System;
class Volleyball
{
    static void Main()
    {
        string leapYear = Console.ReadLine();
        double numberOfHolidays = double.Parse(Console.ReadLine());
        double hometownWeekends = double.Parse(Console.ReadLine());
        double plays = 0;
        plays = hometownWeekends + (((48 - hometownWeekends) * 3)/4) + ((numberOfHolidays * 2)/3);
        if (leapYear == "leap")
        {
            plays += plays* 0.15;
            Console.WriteLine((int)plays);
        }
        else
        {
            Console.WriteLine((int)plays);
        }
    }
}