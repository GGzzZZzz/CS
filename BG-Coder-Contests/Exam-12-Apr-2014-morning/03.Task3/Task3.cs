using System;
using System.Collections.Generic;


class Task3
{
    static void Main()
    {
        string input = Console.ReadLine();
        //input = input.TrimStart(' ');
        string[] arr = input.Split(new char[] { ' ', }, StringSplitOptions.RemoveEmptyEntries);
        long sum = 0;
        List<long> values = new List<long>();
        for (int i = 0; i < arr.Length - 1; i += 2)
        {
            sum = long.Parse(arr[i]) + long.Parse(arr[i + 1]);
            values.Add(sum);
        }

        if (values.Count == 1)
        {
            Console.WriteLine("Yes, value={0}", values[0]);
        }
        else
        {
            bool equal = false;
            for (int i = 0; i < 1; i++)
            {
                int j = 1;
                while (true)
                {
                    if (values[i] == values[j])
                    {
                        equal = true;
                    }
                    else
                    {
                        equal = false;
                    }
                    j++;
                    if (j == values.Count)
                    {
                        break;
                    }
                }
            }
            if (equal == true)
            {
                Console.WriteLine("Yes, value={0}", values[0]);
            }
            else
            {
                long maxDiff = 0;
                long max = values[0];
                for (int i = 1; i < values.Count; i++)
                {
                    max = Math.Max(max, values[i]);
                }
                long min = values[0];
                for (int i = 1; i < values.Count; i++)
                {
                    min = Math.Min(min, values[i]);
                }
                maxDiff = max - min;
                Console.WriteLine("No, maxdiff={0}", maxDiff);
            }
        }
    }
}
                    

      


