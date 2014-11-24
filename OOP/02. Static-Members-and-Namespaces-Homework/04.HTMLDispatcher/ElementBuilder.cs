using System;
using System.Text;

internal class ElementBuilder
{
    private string elementName;
    private string attributes;
    private string elementContent;

    public ElementBuilder(string elementName)
    {
        this.ElementName = elementName;
    }

    public string ElementName
    {
        get { return this.elementName; }
        set { this.elementName = value; }
    }

    public string Attributes
    {
        get { return this.attributes; }
        set { this.attributes = value; }
    }

    public string ElementContent
    {
        get { return this.elementContent; }
        set { this.elementContent = value; }
    }

    // overload * operator
    public static string operator *(ElementBuilder element, int count)
    {
        StringBuilder result = new StringBuilder();

        for (int i = 0; i < count; i++)
        {
            result.Append(element);
        }

        return result.ToString();
    }

    // adding attribute
    public string AddAttribute(string attribute, string value)
    {
        StringBuilder attributes = new StringBuilder();
        attributes.Append(attribute);
        attributes.Append("=");
        attributes.Append("\"" + value + "\"");

        return this.Attributes = this.Attributes + " " + attributes.ToString();
    }

    // adding content
    public string AddContent(string content)
    {
        StringBuilder elementContent = new StringBuilder();
        elementContent.Append(content);
        return this.ElementContent = this.ElementContent + elementContent.ToString();
    }

    // display element
    public override string ToString()
    {
        StringBuilder result = new StringBuilder();

        result.Append("<" + this.ElementName);
        result.Append(this.Attributes);

        // check if element is self-closing tag
        if (this.ElementContent == null)
        {
            result.Append("/>");
        }
        else
        {
            result.Append(">");
            result.Append(this.ElementContent);
            result.Append("</" + this.ElementName + ">");
        }

        return result.ToString();
    }
}