using System;
using System.Collections.Generic;
using System.Linq;

internal class ComputerTest
{
    public static void Main()
    {
        // create components
        Component motherboard = new Component("Motherboard: Gygabyte", 250.40);
        Component processor = new Component("CPU: Intel Core i5", 120.99, "dual core");
        Component hdd = new Component("HDD: Hitachi 500 GB", 190.00);
        Component graphicsCard = new Component("GPU: GeForce", 188.25, "3D acceleration");
        Component ram = new Component("RAM: Kingston 8 GB", 89.80);

        // create PCs
        Computer awesomePC = new Computer("Machine", new List<Component>() { motherboard, processor, hdd, graphicsCard, ram });
        Computer somePC = new Computer("Beast", new List<Component>() { motherboard, processor, ram });

        // order by ascending
        List<Computer> pc = new List<Computer>() { awesomePC, somePC };
        pc = pc.OrderBy(p => p.Price).ToList();

        foreach (Computer computer in pc)
        {
            Console.WriteLine(computer.ToString());
        }

        // or
        // pc.OrderBy(p => p.Price).ToList().ForEach(p => Console.WriteLine(p.ToString()));
    }
}
