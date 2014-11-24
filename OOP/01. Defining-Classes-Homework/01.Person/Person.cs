/* Define a class Person that has name, age and email. The name and age are mandatory. The email is optional. Define properties that accept non-empty name and age in the range [1...100]. In case of invalid argument, throw an exception. Define a property for the email that accepts either null or non-empty string containing '@'. Define two constructors. The first constructor should take name, age and email. The second constructor should take name and age only and call the first constructor. Implement the ToString() method to enable printing persons at the console.*/

using System;

internal class Person
{
    // fields
    private string name;
    private int age;
    private string email;

    // constructors
    public Person(string name, int age, string email)
    {
        this.Name = name;
        this.Age = age;
        this.Email = email;
    }

    public Person(string name, int age)
        : this(name, age, null)
    {
    }

    // properties
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
                throw new ArgumentNullException("value", "Name can not be null or empty value!");
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
            if (value < 1 || value > 100)
            {
                throw new ArgumentOutOfRangeException("value", "Age must be in range [1...100]!");
            }

            this.age = value;
        }
    }

    public string Email
    {
        get
        {
            return this.email;
        }

        set
        {
            if (value != null && !value.Contains("@"))
            {
                throw new ArgumentException("Email must be null or contains '@'!");
            }

            this.email = value;
        }
    }

    // display info method
    public override string ToString()
    {
        if (this.Email == null)
        {
            return string.Format("Name:{0} \nAge:{1}", this.Name, this.Age);
        }

        return string.Format("Name:{0} \nAge:{1} \nEmail:{2}", this.Name, this.Age, this.Email);
    }
}