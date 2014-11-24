using System;

public abstract class Animal :  ISound
{
    private string name;
    private int age;
    private string gender;

    public Animal(string name, int age)
    {
        this.Name = name;
        this.Age = age;
    }
    public Animal(string name, int age, string gender)
    {
        this.Name = name;
        this.Age = age;
        this.Gender = gender;
    }

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
                throw new ArgumentNullException("Name can not be null or empty!");
            }

            this.name = value;
        }
    }

    public int Age
    {
        get
        {
            return this.age;
        }

        set
        {
            if (value < 0)
            {
                throw new ArgumentException("Age can not be negative!");
            }

            this.age = value;
        }
    }

    public string Gender
    {
        get
        {
            return this.gender;
        }

        set
        {
            if (value.ToLower() != "male" && value.ToLower() != "female")
            {
                throw new ArgumentException("Gender should be male or female!");
            }

            this.gender = value;
        }
    }

    public abstract void ProduceSound();
}