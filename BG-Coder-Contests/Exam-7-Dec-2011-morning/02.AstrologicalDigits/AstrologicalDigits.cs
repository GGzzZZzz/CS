using System;
class AstrologicalDigits
{
    static void Main()
    {
        string n = Console.ReadLine();
        ulong sum = 10;
        /* if (n.StartsWith("-"))
         {
             n = n.Remove(0, 1);
         }*/
        while (sum > 9)
        {
            sum = 0;
            for (int i = 0; i < n.Length; i++)
            {
                switch (n[i])
                {
                    case '1': sum = sum + 1; break;
                    case '2': sum = sum + 2; break;
                    case '3': sum = sum + 3; break;
                    case '4': sum = sum + 4; break;
                    case '5': sum = sum + 5; break;
                    case '6': sum = sum + 6; break;
                    case '7': sum = sum + 7; break;
                    case '8': sum = sum + 8; break;
                    case '9': sum = sum + 9; break;
                }
            }
            n = sum.ToString();
        }
        Console.WriteLine(sum);
    }
}