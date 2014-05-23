using System;
class Test
{
    static void Main()
    {
        string a = "8";
        string b = "8";
        string c = "8";
        string d = "A";
        string e = "8";
        string concat = a + b + c + d + e;
        EqualElements(concat); // If all elements are equal
        FourOfKind(concat);
    }

    private static void FourOfKind(string concat)
    {
        
    }
    private static void EqualElements(string concat)
    {
        if(concat[0] == concat[1] && concat[1] == concat[2] && concat[2] == concat[3] && concat[3] == concat[4])
        {
            Console.WriteLine("Impossible");
        }
        
    }
}


