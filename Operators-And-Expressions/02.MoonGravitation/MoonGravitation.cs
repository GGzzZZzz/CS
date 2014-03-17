using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.MoonGravitation
{
    class MoonGravitation
    {
        static void Main(string[] args)
        {
            //The gravitational field of the Moon is approximately 17% of that on the Earth. Write a program that calculates the weight of a man on the moon by a given weight on the Earth.

            Console.WriteLine("Enter your weight, plese.");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine(num * 0.17);
        }
    }
}
