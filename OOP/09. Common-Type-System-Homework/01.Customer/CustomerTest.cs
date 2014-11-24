using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class CustomerTest
{
    public static void Main()
    {

        List<Payment> payments = new List<Payment>
        {
            new Payment("Office 365", 360m),
            new Payment("Windows 8 Enterprise", 520m),
            new Payment("Visual Studio 2013", 190m)
        };

        Customer nedyalko = new Customer(
            "Nedyalko",
            "Gochev",
            "Kolev",
            "781236543",
            "Dolno Nanagornishte",
            "0894551022",
            "nedko_igra4@abv.bg",
            payments,
            CustomerType.Regular);


        Customer boiko = (Customer)nedyalko.Clone();

        boiko.FirstName = "Boiko";
        Console.WriteLine(nedyalko == boiko);

        boiko.FirstName = "Nedyalko";

        boiko.Payments = new List<Payment>
        {
            new Payment("Office 365", 200m),
            new Payment("Windows 8 Enterprise", 300m),
            new Payment("Visual Studio 2013", 400m)
        };

        Console.WriteLine(nedyalko == boiko);

        Console.WriteLine(nedyalko);
        Console.WriteLine();
        Console.WriteLine(boiko);

        Console.WriteLine(nedyalko.CompareTo(new Customer("Aleko", "Bobev", "Rachev", "8909082266","087334890", "Ot Boga Zabravenovo","alex_qk@abv.bg", payments, CustomerType.Golden)));
    }
}