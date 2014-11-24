using System;

internal class GalacticGPSTest
{
    public static void Main()
    {
        Location home = new Location(18.037986, 28.870097, Planet.Earth);
        Location dreamHome = new Location(69.435325323, 92.34353532, Planet.Mars);

        Console.WriteLine(home);
        Console.WriteLine();
        Console.WriteLine(dreamHome);
    }
} 