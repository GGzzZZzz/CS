using System;
class ExtractURLsFromText
{
    static void Main()
    {
        //Write a program that extracts and prints all URLs from given text. URL can be in only two formats:
        //•	http://something, e.g. http://softuni.bg, http://forums.softuni.bg, http://www.nakov.com 
        //•	www.something.domain, e.g. www.nakov.com, www.softuni.bg, www.google.com

         string input = Console.ReadLine();
         string[] text = input.Split(new char[] { ' ', ',', ';', '-', '?', '!' });
         for (int i = 0;i<text.Length;i++)
         {
             if (text[i].Contains("http://") || text[i].Contains("www"))
             {
                 Console.WriteLine(text[i]);
             }
         }
    }
}