using System;
class DancingBits
{
    static void Main()
    {
        int k = int.Parse(Console.ReadLine());
        int n = int.Parse(Console.ReadLine());
        string binary = "";
        for (int i = 0; i < n; i++)
        {
            int num = int.Parse(Console.ReadLine());
            binary += Convert.ToString(num,2);
        }
        
        int zeros = 0;
        int ones = 0;
        int dancingBits = 0;
        for (int i = 0; i < binary.Length; i++)
        {
            if(binary[i]=='1')
            {
               if(zeros == k)
               {
                   dancingBits++;
                   
               }
               zeros = 0;
               ones++;
            }
            if(binary[i] == '0')
            {
                if(ones == k)
                {
                    dancingBits++;
                    
                }
                ones = 0;
                zeros++;
            }
            if(binary.Length - 1 == i)
            {
                if(ones == k)
                {
                    dancingBits++;
                }
                if(zeros == k)
                {
                    dancingBits++;
                }
            }
        }
        Console.WriteLine(dancingBits);
    }
}