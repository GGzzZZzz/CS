using System;
class FighterAttack
{
    static void Main()
    {
        //plant
        int px1 = int.Parse(Console.ReadLine());
        int py1 = int.Parse(Console.ReadLine());
        int px2 = int.Parse(Console.ReadLine());
        int py2 = int.Parse(Console.ReadLine());
        //fighter
        int fx = int.Parse(Console.ReadLine());
        int fy = int.Parse(Console.ReadLine());
        int distance = int.Parse(Console.ReadLine());

        int swaper1 = Math.Min(px1, px2);
        int swaper2 = Math.Max(px1, px2);
        px1 = swaper1;
        px2 = swaper2;

        swaper1 = Math.Max(py1, py2);
        swaper2 = Math.Min(py1, py2);
        py1 = swaper1;
        py2 = swaper2;

        fx += distance;

        int damage = 0;
        damage += CalculateDamage(px1, py1, px2, py2, fx, fy);
        Console.WriteLine(damage + "%");

    }

    private static int CalculateDamage(int px1, int py1, int px2, int py2, int fx, int fy)
    {
        int damage = 0;
        if ((fx >= px1 && fx <= px2) && (fy <= py1 && fy >= py2))
        {
            damage += 100;
        }
        if ((fx + 1 >= px1 && fx + 1 <=px2) && (fy <= py1 && fy >= py2))
        {
            damage += 75;
        }
        if ((fx >= px1 && fx <= px2) && (fy + 1 <= py1 && fy + 1 >= py2))
        {
            damage += 50;
        }
        if((fx >= px1 && fx <= px2) && (fy - 1 <= py1 && fy - 1 >= py2))
        {
            damage += 50;
        }
        return damage;
    }
}