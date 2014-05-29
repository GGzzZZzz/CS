using System;
class TheHorror
{
    static void Main()
    {
        string input = Console.ReadLine();
        int digit;
        int counter = 0;
        int sum = 0;
        for (int i = 0; i < input.Length; i+=2)
        {
            if(int.TryParse(input[i].ToString(),out digit))
            {
                counter++;
                sum += input[i] - '0';
            }
        }
        Console.WriteLine("{0} {1}",counter,sum );
    }
}