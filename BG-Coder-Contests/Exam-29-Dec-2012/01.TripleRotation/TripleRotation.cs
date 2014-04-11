using System;
using System.Collections.Generic;
class TripleRotation
{
    static void Main()
    {
        string k = Console.ReadLine(); ;
        char[] digits = k.ToCharArray();
        List<char> rotate = new List<char>();
        for (int i = 0; i < digits.Length; i++)
        {
            rotate.Add(digits[i]);
        }
        for (int i = 0; i < 3; i++)
        {
            rotate.Reverse();
            rotate.Reverse(1, rotate.Count-1);
            if(rotate[0] == '0')
            {
                rotate.Remove(rotate[0]);
            }
        }
        string result = string.Join("", rotate.ToArray());
        Console.WriteLine(result);
    }
}