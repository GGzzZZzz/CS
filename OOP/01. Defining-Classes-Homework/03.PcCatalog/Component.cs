using System;

internal class Component
{
    private string name;
    private double price;
    private string details;

    public Component(string name, double price)
    {
        this.Name = name;
        this.Price = price;
    }

    public Component(string name, double price, string details)
        : this(name, price)
    {
        this.Details = details;
    }

    // another(better) way
    /*public Component(string name, double price, string details = null)
    {
        this.Name = name;
        this.Price = price;
        this.Details = details;
    }*/

    public string Name
    {
        get
        {
            return this.name;
        }

        set
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentNullException("value", "Name can not be empty!");
            }

            this.name = value;
        }
    }

    public double Price
    {
        get
        {
            return this.price;
        }

        set
        {
            if (value < 0)
            {
                throw new ArgumentException("Price can not be negative!", "value");
            }

            this.price = value;
        }
    }

    public string Details
    {
        get { return this.details; }
        set { this.details = value; }
    }
}