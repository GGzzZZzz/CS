using System;
using System.Globalization;

    class ExamSchedule
    {
        static void Main()
        {
            int startHour = int.Parse(Console.ReadLine());
            int startMinutes = int.Parse(Console.ReadLine());
            string partOfDay = Console.ReadLine();
            int durationHour = int.Parse(Console.ReadLine());
            int durationMinutes = int.Parse(Console.ReadLine());
            int endHour = 0;
            int endMinutes = 0;
            string startTime = "";
            if (startHour < 10)
            {
                 startTime = "0"+ Convert.ToString(startHour) + ":" + Convert.ToString(startMinutes) + ":" + Convert.ToString(partOfDay);
            }
            else
            {
                startTime = Convert.ToString(startHour) + ":" + Convert.ToString(startMinutes) + ":" + Convert.ToString(partOfDay);
            }
            
            DateTime start = DateTime.ParseExact(startTime, "HH:mm:tt", CultureInfo.CreateSpecificCulture("en-US"));
            string durationTime = "";
            if (durationHour < 0)
            {
                durationTime = "0" + durationHour + ":" + durationMinutes;
            }
            else
            {
                durationTime = durationHour + ":" + durationMinutes;
            }
           
            
        }
    }
