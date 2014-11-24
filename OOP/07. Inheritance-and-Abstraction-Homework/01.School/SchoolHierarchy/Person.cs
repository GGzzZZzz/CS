using System;

public class Person : IDetail
{
    private string name;
    private string details;

    public Person(string name, string details = null)
    {
        this.Name = name;
        this.Details = details;
    }

    public string Name
    {
        get
        {
            return this.name;
        }

        private set
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentNullException("Name can not be null or empty!");
            }

            this.name = value;
        }
    }

    public string Details
    {
        get
        {
            return this.details;
        }

        set
        {
            if (value == string.Empty)
            {
                throw new ArgumentException("Detail can not be empty!");
            }

            this.details = value;
        }
    }

    public void SayHello()
    {
        Console.WriteLine(this + " " + this.Name + " said hello!");
    }
}