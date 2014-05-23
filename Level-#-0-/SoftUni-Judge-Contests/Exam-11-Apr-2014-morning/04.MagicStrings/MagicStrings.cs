using System;
class MagicStrings
{
    static void Main()
    {
        int diff = int.Parse(Console.ReadLine());
        char[] letters = { 'k', 'n', 'p', 's' };
        bool match = false;
        for (int first = 0; first < letters.Length; first++)
        {
            for (int second = 0; second < letters.Length; second++)
            {
                for (int third = 0; third < letters.Length; third++)
                {
                    for (int fourth = 0; fourth < letters.Length; fourth++)
                    {
                        string leftString = "" + letters[first] + letters[second] + letters[third] + letters[fourth];
                        int leftWeight = CalculateWeight(leftString);
                        for (int fifth = 0; fifth < letters.Length; fifth++)
                        {
                            for (int sixth = 0; sixth < letters.Length; sixth++)
                            {
                                for (int seventh = 0; seventh < letters.Length; seventh++)
                                {
                                    for (int eight = 0; eight < letters.Length; eight++)
                                    {
                                        string rightString = "" + letters[fifth] + letters[sixth] + letters[seventh] + letters[eight];
                                        int rightWeight = CalculateWeight(rightString);

                                        if (Math.Abs(leftWeight - rightWeight) == diff)
                                        {
                                            match = true;
                                            Console.WriteLine(leftString + rightString);
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
        if (!match)
        {
            Console.WriteLine("No");
        }
    }

    private static int CalculateWeight(string leftString)
    {
        int weight = 0;
        foreach (char letter in leftString)
        {
            switch (letter)
            {
                case 'k': weight += 1; break;
                case 'n': weight += 4; break;
                case 'p': weight += 5; break;
                case 's': weight += 3; break;
            }
        }
        return weight;
    }
}