using System;
class NightmareOnCodeStreet
{
    static void Main()
    {
        string input = Console.ReadLine();
        int counter = 0;
        int sum = 0;
        for (int i = 1; i < input.Length; i+=2)
	    {
            int current;
            if (int.TryParse(input[i].ToString(),out current))
            {
                counter++;
                sum += current;
            }
	    }
        Console.WriteLine("{0} {1}",counter,sum);
    }
}