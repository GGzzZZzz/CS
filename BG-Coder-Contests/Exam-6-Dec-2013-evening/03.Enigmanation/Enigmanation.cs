using System;
class Enigmanation
{
    static void Main()
    {
        string input = "(6%5)*9+(8*3%7)*7%2*(5%3+4*1)=";
        double finalResult = 0;
        int digit = 0;
        char operation = ' ';
        bool brackets = false;
        int bracketsStart = 0;
        int bracketsEnd = 0;
        int result = 0;
        int resultIn = 0;
        for (int i = 0; i < input.Length; i++)
        {
            if(int.TryParse(input[i].ToString(),out digit))
            {
                result = digit;
                continue;
            }
            if(input[i] == '(')
            {
                brackets = true;
                bracketsStart = i + 1;
                resultIn = int.Parse(input[i + 1].ToString());
                i++;
                continue;
            }
            if(input[i] == ')')
            {
                brackets = false;
                bracketsEnd = i - 1;
                result = 
            }
        }
        
        
    }
}