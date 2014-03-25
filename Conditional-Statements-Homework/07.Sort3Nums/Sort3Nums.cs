using System;
class Sort3Nums
{
    static void Main()
    {
        //Write a program that enters 3 real numbers and prints them sorted in descending order. Use nested if statements. Don’t use arrays and the built-in sorting functionality.

        Console.WriteLine("Enter 3 real number each on a single line");
        double one = double.Parse(Console.ReadLine());
        double two = double.Parse(Console.ReadLine());
        double three = double.Parse(Console.ReadLine());
        if(one >= two && one >= three)
        {
            if(two >= three)
            {
                Console.Write("{0} {1} {2}\n",one,two,three);
            }
            else
            {
                Console.Write("{0} {1} {2}\n",one,three,two);
            }
        }
        else if (two >= one && two >= three)
        {
            if (one >= three)
            {
                Console.Write("{0} {1} {2}\n",two,one,three);
            }
            else
            {
                Console.Write("{0} {1} {2}\n",two,three,one);
            }
        }
        else
        {
            if(one >= two)
            {
                Console.Write("{0} {1} {2}\n",three,one,two);
            }
            else
            {
                Console.Write("{0} {1} {2}\n",three,two,one);
            }
        }

    }
}
