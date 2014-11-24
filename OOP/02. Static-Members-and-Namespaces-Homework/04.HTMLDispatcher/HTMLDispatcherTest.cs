using System;

internal class HTMLDispatcherTest
{
    public static void Main()
    {
        // create elements using static methods trough HTMLDispatcher class
        Console.WriteLine(HTMLDispatcher.CreateImage("pics/logo.png", "site logo", "resizable"));
        Console.WriteLine();

        Console.WriteLine(HTMLDispatcher.CreateURL("site.com", "Site link", "Click here"));
        Console.WriteLine();

        Console.WriteLine(HTMLDispatcher.CreateInput("radio", "group", "married"));
        Console.WriteLine();

        // create elements with ElementBuilder class instance 
        ElementBuilder div = new ElementBuilder("div");

        div.AddAttribute("class", "clearfix");
        div.AddAttribute("id", "homebox");
        div.AddContent("Text goes here.");
        div.AddContent(" More text added here.");

        Console.WriteLine(div.ToString());
        Console.WriteLine();

        Console.WriteLine(div * 2);
    }
}