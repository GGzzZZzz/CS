using System;
class ShipDamage
{
    static void Main()
    {
        //ship
        int sx1 = int.Parse(Console.ReadLine());
        int sy1 = int.Parse(Console.ReadLine());
        int sx2 = int.Parse(Console.ReadLine());
        int sy2 = int.Parse(Console.ReadLine());
        int swaper1 = 0;
        int swaper2 = 0;
        //horizon
        int horizon = int.Parse(Console.ReadLine());
        //catapults
        int cx1 = int.Parse(Console.ReadLine());
        int cy1 = int.Parse(Console.ReadLine());
        int cx2 = int.Parse(Console.ReadLine());
        int cy2 = int.Parse(Console.ReadLine());
        int cx3 = int.Parse(Console.ReadLine());
        int cy3 = int.Parse(Console.ReadLine());

        swaper1 = Math.Min(sx1, sx2);
        swaper2 = Math.Max(sx1, sx2);
        sx1 = swaper1;
        sx2 = swaper2;

        swaper1 = Math.Min(sy1, sy2);
        swaper2 = Math.Max(sy1, sy2);
        sy1 = swaper1;
        sy2 = swaper2;

        cy1 = horizon * 2 - cy1;
        cy2 = horizon * 2 - cy2;
        cy3 = horizon * 2 - cy3;

        //calculation damage
        int damage = 0;
        damage += CalculateDamage(sx1, sy1, sx2, sy2, cx1, cy1);
        damage += CalculateDamage(sx1, sy1, sx2, sy2, cx2, cy2);
        damage += CalculateDamage(sx1, sy1, sx2, sy2, cx3, cy3);

        Console.WriteLine(damage + "%");
    }

    private static int CalculateDamage(int sx1, int sy1, int sx2, int sy2, int cx1, int cy1)
    {
        int damage = 0;
        if (cx1 > sx1 && cx1 < sx2 && cy1 > sy1 && cy1 < sy2)
        {
            damage += 100;
        }
        else if ((cx1 == sx1 || cx1 == sx2) && cy1 > sy1 && cy1 < sy2)
        {
            damage += 50;
        }
        else if ((cy1 == sy1 || cy1 == sy2) && cx1 > sx1 && cx1 < sx2)
        {
            damage += 50;
        }
        else if ((cx1 == sx1 || cx1 == sx2) && (cy1 == sy1 || cy1 == sy2))
        {
            damage += 25;
        }
        return damage;
    }
}