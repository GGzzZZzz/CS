using System;
class MissCat2011
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int sum1 = 0;
        int sum2 = 0;
        int sum3 = 0;
        int sum4 = 0;
        int sum5 = 0;
        int sum6 = 0;
        int sum7 = 0;
        int sum8 = 0;
        int sum9 = 0;
        int sum10 = 0;
        for (int i = 0; i < n; i++)
        {
            int number = int.Parse(Console.ReadLine());
            if(number == 1)
            {
                int cat1 = number;
                sum1++;
            }
            if (number == 2)
            {
                int cat2 = number;
                sum2++;
            }
            if (number == 3)
            {
                int cat3 = number;
                sum3++;
            }
            if (number == 4)
            {
                int cat4 = number;
                sum4++;
            }
            if (number == 5)
            {
                int cat5 = number;
                sum5++;
            }
            if (number == 6)
            {
                int cat6 = number;
                sum6++;
            }
            if (number == 7)
            {
                int cat7 = number;
                sum7++;
            }
            if (number == 8)
            {
                int cat8 = number;
                sum8++;
            }
            if (number == 9)
            {
                int cat9 = number;
                sum9++;
            }
            if (number == 10)
            {
                int cat10 = number;
                sum10++;
            }
        }

        if ((sum1 > sum2) & (sum1 > sum3) & (sum1 > sum4) & (sum1 > sum5) & (sum1 > sum6) & (sum1 > sum7) & (sum1 > sum8) & (sum1 > sum9) & (sum1 > sum10))
        {
            Console.WriteLine(1);
        }
        if ((sum2 > sum3) & (sum2 > sum4) & (sum2 > sum5) & (sum2 > sum6) & (sum2 > sum7) & (sum2 > sum8) & (sum2 > sum9) & (sum2 > sum10) & (sum2 > sum1))
        {
            Console.WriteLine(2);
        }
        if ((sum3 > sum4) & (sum3 > sum5) & (sum3 > sum6) & (sum3 > sum7) & (sum3 > sum8) & (sum3 > sum9) & (sum3 > sum10) & (sum3 > sum1) & (sum1 > sum2))
        {
            Console.WriteLine(3);
        }
        if ((sum4 > sum5) & (sum4 > sum6) & (sum4 > sum7) & (sum4 > sum8) & (sum4 > sum9) & (sum4 > sum10) & (sum4 > sum1) & (sum4 > sum2) & (sum4 > sum3))
        {
            Console.WriteLine(4);
        }
        if ((sum5 > sum6) & (sum5 > sum7) & (sum5 > sum8) & (sum5 > sum9) & (sum5 > sum10) & (sum5 > sum1) & (sum5 > sum2) & (sum5 > sum3) & (sum5 > sum4))
        {
            Console.WriteLine(5);
        }
        if ((sum6 > sum7) & (sum6 > sum8) & (sum6 > sum9) & (sum6 > sum10) & (sum6 > sum1) & (sum6 > sum2) & (sum6 > sum3) & (sum6 > sum4) & (sum6 > sum5))
        {
            Console.WriteLine(6);
        }
        if ((sum7 > sum8) & (sum7 > sum9) & (sum7 > sum10) & (sum7 > sum1) & (sum7 > sum2) & (sum7 > sum3) & (sum7 > sum4) & (sum7 > sum5) & (sum7 > sum6))
        {
            Console.WriteLine(7);
        }
        if ((sum8 > sum9) & (sum8 > sum10) & (sum8 > sum1) & (sum8 > sum2) & (sum8 > sum3) & (sum8 > sum4) & (sum8 > sum5) & (sum8 > sum6) & (sum8 > sum7))
        {
            Console.WriteLine(8);
        }
        if ((sum9 > sum10) & (sum9 > sum1) & (sum9 > sum2) & (sum9 > sum3) & (sum9 > sum4) & (sum9> sum5) & (sum9 > sum6) & (sum9 > sum7) & (sum9 > sum8))
        {
            Console.WriteLine(9);
        }
        if ((sum10> sum1) & (sum10> sum2) & (sum10> sum3) & (sum10> sum4) & (sum10> sum5) & (sum10> sum6) & (sum10> sum7) & (sum10> sum8) & (sum10> sum9))
        {
            Console.WriteLine(10);
        }
    }
}