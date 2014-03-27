using System;
class Test
{
    static void Main()
    {
        string startTime = "1:00 PM";
        DateTime stratT = Convert.ToDateTime(startTime);
        string endTime = "3:00 AM";
        DateTime endT = Convert.ToDateTime(endTime);
        DateTime now = DateTime.Now;
        string time = now.ToString("hh:mm tt");
        if ((now >= endT) && (now <= stratT))
        {
            Console.WriteLine("non-beer time");
        }
        else
        {
            Console.WriteLine("beer time");
        }
    }
}