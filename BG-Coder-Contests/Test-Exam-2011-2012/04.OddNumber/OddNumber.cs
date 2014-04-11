using System;
using System.Collections.Generic;
class OddNumber
{
    static void Main()
    {
        uint n = uint.Parse(Console.ReadLine());
        List<long> nums = new List<long>();

        for (int i = 0; i < n; i++)
        {
            long num = long.Parse(Console.ReadLine());
            nums.Add(num);
        }
        nums.Sort();
        int j = 1;
        int counter = 1;
        long lastNum = 0;
        int lastIndex = 0;
        for (int i = 0; i < nums.Count; i++)
        {
            if(nums[i]==nums[j])
            {
                counter++;
                j++;
            }
            else
            {
                if(counter % 2 == 1)
                {
                    Console.WriteLine(nums[i]);
                }
                lastNum = nums[i];
                lastIndex = j;
                i = lastIndex;
                j = i + 1;
                counter = 1;
            }
        }
        if(counter == 1)
        {
            Console.WriteLine(nums[j-1]);
        }
        
    }
}