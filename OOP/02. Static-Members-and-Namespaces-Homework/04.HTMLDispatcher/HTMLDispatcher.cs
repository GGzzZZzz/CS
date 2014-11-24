using System;

internal class HTMLDispatcher
{
    public static string CreateImage(string imageSource, string alt, string title)
    {
        ElementBuilder image = new ElementBuilder("img");

        image.AddAttribute("src", imageSource);
        image.AddAttribute("alt", alt);
        image.AddAttribute("title", title);

        return image.ToString();
    }

    public static string CreateURL(string url, string title, string text)
    {
        ElementBuilder address = new ElementBuilder("a");

        address.AddAttribute("href", url);
        address.AddAttribute("title", title);
        address.AddContent(text);

        return address.ToString();
    }

    public static string CreateInput(string type, string name, string value)
    {
        ElementBuilder inputTag = new ElementBuilder("input");

        inputTag.AddAttribute("type", type);
        inputTag.AddAttribute("name", name);
        inputTag.AddAttribute("value", value);

        return inputTag.ToString();
    }
}