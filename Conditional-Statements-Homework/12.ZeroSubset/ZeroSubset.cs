using System;

class ZeroSubset
{
    static void Main()
    {
        //We are given 5 integer numbers. Write a program that finds all subsets of these numbers whose sum is 0. Assume that repeating the same subset several times is not a problem.

        int[] nums = new int[5];
        for (int i = 0; i < nums.Length; i++)
        {
            nums[i] = int.Parse(Console.ReadLine());
        }
        for (int i = 0; i < nums.Length - 2; i++)
        {
            for (int j = i + 1; j < nums.Length; j++)
            {
                if (nums[i] + nums[j] == 0)
                {
                    Console.WriteLine("{0} + {1} = 0", nums[i], nums[j]);
                }

                for (int k = j + 1; k < nums.Length; k++)
                {
                    if (nums[i] + nums[j] + nums[k] == 0)
                    {
                        Console.WriteLine("{0} + {1} + {2} = 0", nums[i], nums[j], nums[k]);
                    }
                    for (int p = k + 1; p < nums.Length; p++)
                    {
                        if (nums[i] + nums[j] + nums[k] + nums[p] == 0)
                        {
                            Console.WriteLine("{0} + {1} + {2} + {3} = 0", nums[i], nums[j], nums[k], nums[p]);
                        }
                    }
                }
            }
        }
    }
}
	