using System;
class JoroTheFootballPlayer
{
    static void Main()
    {
        string leapYear = Console.ReadLine();
        double numOfHolidays = double.Parse(Console.ReadLine());
        double numOfWeekends = double.Parse(Console.ReadLine());
        double sum = 0;
        if(leapYear == "t")
        {
            sum = 3 + (numOfHolidays * 0.5) + (numOfWeekends * 1) + (((52 - numOfWeekends) * 2) / 3);
            Console.WriteLine((int)sum);
        }
        else if(leapYear == "f")
        {
            sum = (numOfHolidays * 0.5) + (numOfWeekends * 1) + (((52 - numOfWeekends) * 2) / 3);
            Console.WriteLine((int)sum);
        }
    }
}