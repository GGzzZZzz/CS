using System;
class DrunkenNumbers
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int mitkoBeers = 0;
        int vladkoBeers = 0;
        for (int i = 0; i < n; i++)
        {
            int num = int.Parse(Console.ReadLine());
            string number = num.ToString();
            number = number.TrimStart('0','-'); //Ignore zeros and '-' sign

            if (number.Length % 2 == 0) //If digits are even
            {
                for (int j = 0; j < number.Length/2; j++)
                {
                    mitkoBeers += int.Parse(number[j].ToString());
                }
                for (int j = number.Length / 2; j < number.Length; j++)
                {
                    vladkoBeers += int.Parse(number[j].ToString());
                }
            }
            if(number.Length % 2 != 0) //If digits are odd
            {
                for (int j = 0; j < number.Length/2 + 1; j++) //Include the middle digit
                {
                    mitkoBeers += int.Parse(number[j].ToString());
                }
                for (int j = number.Length/2; j < number.Length; j++)
                {
                    vladkoBeers += int.Parse(number[j].ToString());
                }
            }
        }
        if (mitkoBeers > vladkoBeers)
        {
            Console.Write("M " + (mitkoBeers - vladkoBeers)); 
        }
        if(vladkoBeers > mitkoBeers)
        {
            Console.Write("V " + (vladkoBeers - mitkoBeers));
        }
        if (mitkoBeers == vladkoBeers)
        {
            Console.Write("No " + (mitkoBeers + vladkoBeers));
        }
    }
}