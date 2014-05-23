using System;
class Illuminati
{
    static void Main()
    {
        string message = Console.ReadLine();
        int counter = 0;
        int sum = 0;
        foreach (char vowel in message)
        {
            switch (vowel)
            {
                case 'A': counter++; sum += 65; break;
                case 'a': counter++; sum += 65; break;
                case 'E': counter++; sum += 69; break;
                case 'e': counter++; sum += 69; break;
                case 'I': counter++; sum += 73; break;
                case 'i': counter++; sum += 73; break;
                case 'O': counter++; sum += 79; break;
                case 'o': counter++; sum += 79; break;
                case 'U': counter++; sum += 85; break;
                case 'u': counter++; sum += 85; break;
            }
        }
        Console.WriteLine(counter);
        Console.WriteLine(sum);
    }
}