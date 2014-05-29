using System;

class Task1
{
    static void Main()
    {
        int Ax = int.Parse(Console.ReadLine());
        int Ay = int.Parse(Console.ReadLine());
        int Bx = int.Parse(Console.ReadLine());
        int By = int.Parse(Console.ReadLine());
        int Cx = int.Parse(Console.ReadLine());
        int Cy = int.Parse(Console.ReadLine());
        double a = Math.Sqrt(Math.Pow(Bx - Ax,2) + Math.Pow(By - Ay,2));
        double b = Math.Sqrt(Math.Pow(Cx - Bx,2) + Math.Pow(Cy - By,2));
        double c = Math.Sqrt(Math.Pow(Ax - Cx, 2) + Math.Pow(Ay - Cy, 2));
        //bool trianlge = false;
        if(a + b > c && b + c > a && a + c > b)
        {
            //trianlge = true;
            Console.WriteLine("Yes");
            double p = (a + b + c) / 2;
            double area = Math.Sqrt(p*(p - a)*(p - b)*(p - c));
            Console.WriteLine("{0:F2}",area);
        }
        else
        {
            Console.WriteLine("No");
            Console.WriteLine("{0:F2}",a);
        }




    }
}

