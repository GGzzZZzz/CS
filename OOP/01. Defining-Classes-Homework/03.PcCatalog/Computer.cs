/*Define a class Computer that holds name, several components and price. The components (processor, graphics card, motherboard, etc.) should be objects of class Component, which holds name, details (optional) and price. 
•	Define several constructors that take different sets of arguments. Use proper variable types. Use properties to validate the data. Throw exceptions when improper data is entered.
•	Add a method in the Computer class that displays the name, each of the components' name and price and the total computer price. The total price is the sum of all components' price. Print the prices in BGN currency format.
•	Create several Computer objects, sort them by price, and print them on the console using the created display method.*/

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

internal class Computer
{
    private string name;
    private List<Component> components;

    public Computer(string name, List<Component> components)
    {
        this.Name = name;
        this.Components = components;
    }

    public string Name
    {
        get
        {
            return this.name;
        }

        set
        {
            if (value == string.Empty)
            {
                throw new ArgumentException("Name can not be empty!", "value");
            }

            this.name = value;
        }
    }

    public double Price
    {
        get
        {
            return GetPrice(this.Components);
        }
    }

    public List<Component> Components
    {
        get { return this.components; }
        set { this.components = value; }
    }

    // calculate total PC's price
    public static double GetPrice(List<Component> componentsList)
    {
        double sum = 0;
        foreach (Component comp in componentsList)
        {
            sum += comp.Price;
        }

        return sum;
    }

    // display info
    public override string ToString()
    {
        StringBuilder pcInfo = new StringBuilder();

        pcInfo.AppendFormat("Name: {0} \nTotal Price: {1}\nComponents:\n", this.Name, this.Price.ToString("C", new CultureInfo("bg-BG")));

        foreach (Component component in this.Components)
        {
            pcInfo.Append(component.Name + " ");
            if (component.Details != null)
            {
                pcInfo.Append(component.Price.ToString("C", new CultureInfo("bg-BG")) + " ");
                pcInfo.AppendLine(component.Details.ToString());
            }
            else
            {
                pcInfo.AppendLine(component.Price.ToString("C", new CultureInfo("bg-BG")));
            }
        }

        return pcInfo.ToString();
    }
}