using System;
class WorkHours
{
    static void Main()
    {
        int requredHours = int.Parse(Console.ReadLine());
        double availableDays = double.Parse(Console.ReadLine());
        double productivity = double.Parse(Console.ReadLine());
        double efficientWorkHours = 0;
        availableDays-= availableDays * 0.10;
        efficientWorkHours = (availableDays * 12) * (productivity / 100);
        if (requredHours > (int)efficientWorkHours)
        {
            Console.WriteLine("No");
        }
        else
        {
            Console.WriteLine("Yes");
        }
        Console.WriteLine((int)efficientWorkHours - requredHours);
    }
}