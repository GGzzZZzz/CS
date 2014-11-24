/*Define a class Laptop that holds the following information about a laptop device: model, manufacturer, processor, RAM, graphics card, HDD, screen, battery, battery life in hours and price.
•	The model and price are mandatory. All other values are optional.
•	Define two separate classes: a class Laptop holding an instance of class Battery.
•	Define several constructors that take different sets of arguments (full laptop + battery information or only part of it). Use proper variable types.
•	Add a method in the Laptop class that displays information about the given instance
o	Tip: override the ToString() method
•	Put validation in all property setters and constructors. String values cannot be empty, and numeric data cannot be negative. Throw exceptions when improper data is entered.*/

using System;
using System.Text;

internal class Laptop
{
    // fields
    private string model;
    private double price;
    private string manufacturer;
    private string cpu;
    private string ram;
    private string gpu;
    private string hdd;
    private Battery battery;
    private string screen;

    // constructors
    public Laptop(string model, double price)
    {
        this.Model = model;
        this.Price = price;
    }

    public Laptop(string model, double price, string manufacturer, string cpu, string ram, string gpu, string hdd, Battery battery, string screen)
        : this(model, price)
    {
        this.Manufacturer = manufacturer;
        this.CPU = cpu;
        this.RAM = ram;
        this.GPU = gpu;
        this.HDD = hdd;
        this.Battery = battery;
        this.Screen = screen;
    }

    // another (better) way to construct the object
    /*public Laptop(string model, double price, string manufacturer = null, string cpu = null, string ram = null, string gpu = null, string hdd = null, Battery battery = null, string screen = null)
    {
        this.Model = model;
        this.Price = price;
        this.Manufacturer = manufacturer;
        this.CPU = cpu;
        this.RAM = ram;
        this.GPU = gpu;
        this.HDD = hdd;
        this.Battery = battery;
        this.Screen = screen;
    }*/

    // properties
    public string Model
    {
        get
        {
            return this.model;
        }

        set
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentNullException("value", "Model can not be empty or null!");
            }

            this.model = value;
        }
    }

    public string Manufacturer
    {
        get
        {
            return this.manufacturer;
        }

        set
        {
            if (value == string.Empty)
            {
                throw new ArgumentException("Manufacturer can not be empty!", "value");
            }

            this.manufacturer = value;
        }
    }

    public string CPU
    {
        get
        {
            return this.cpu;
        }

        set
        {
            if (value == string.Empty)
            {
                throw new ArgumentException("CPU can not be empty!", "value");
            }

            this.cpu = value;
        }
    }

    public string RAM
    {
        get
        {
            return this.ram;
        }

        set
        {
            if (value == string.Empty)
            {
                throw new ArgumentException("RAM can not be empty!", "value");
            }

            this.ram = value;
        }
    }

    public string GPU
    {
        get
        {
            return this.gpu;
        }

        set
        {
            if (value == string.Empty)
            {
                throw new ArgumentException("GPU can not be empty!", "value");
            }

            this.gpu = value;
        }
    }

    public string HDD
    {
        get
        {
            return this.hdd;
        }

        set
        {
            if (value == string.Empty)
            {
                throw new ArgumentException("HDD can not be empty!", "value");
            }

            this.hdd = value;
        }
    }

    public Battery Battery
    {
        get { return this.battery; }

        set { this.battery = value; }
    }

    public string Screen
    {
        get
        {
            return this.screen;
        }

        set
        {
            if (value == string.Empty)
            {
                throw new ArgumentException("Screen size can not be empty!", "value");
            }

            this.screen = value;
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
                throw new ArgumentException("Price can not be negative value!");
            }

            this.price = value;
        }
    }

    // display info
    public override string ToString()
    {
        StringBuilder laptopInfo = new StringBuilder();
        laptopInfo.AppendLine("Model: " + this.Model);
        if (this.Manufacturer != null)
        {
            laptopInfo.AppendLine("Manufacturer:" + this.Manufacturer);
        }

        if (this.CPU != null)
        {
            laptopInfo.AppendLine("CPU:" + this.CPU);
        }

        if (this.RAM != null)
        {
            laptopInfo.AppendLine("RAM:" + this.RAM);
        }

        if (this.GPU != null)
        {
            laptopInfo.AppendLine("GPU:" + this.GPU);
        }

        if (this.HDD != null)
        {
            laptopInfo.AppendLine("HDD:" + this.HDD);
        }

        if (this.Battery != null)
        {
            if (Battery.Type != null)
            {
                laptopInfo.AppendLine("Battery:" + Battery.Type);
            }

            if (Battery.Life != 0)
            {
                laptopInfo.AppendLine("Battery life:" + Battery.Life + " hours");
            }
        }

        if (this.Screen != null)
        {
            laptopInfo.AppendLine("Screen:" + this.Screen);
        }

        laptopInfo.AppendLine("Price:" + this.Price + " lv");

        return laptopInfo.ToString();
    }
}