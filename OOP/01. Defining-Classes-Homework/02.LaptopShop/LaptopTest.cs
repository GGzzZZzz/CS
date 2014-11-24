using System;

internal class LaptopTest
{
    public static void Main()
    {
        Battery batt = new Battery("8-cell", 8);
        Laptop someLaptop = new Laptop("ThinkPad", 1299.59);
        Laptop fullLaptop = new Laptop("Pavilion", 1420.99, "HP", "Intel", "8 GB", "Nvidia", "Western Digital", batt, "14.5\"");

        Console.WriteLine(someLaptop.ToString());
        Console.WriteLine(fullLaptop.ToString());
    }
}