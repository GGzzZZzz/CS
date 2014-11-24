using System;

public abstract class Person : IPerson
{
    private int id;
    private string firstName;
    private string lastName;

    public Person(int id, string firstName, string lastName)
    {
        this.Id = id;
        this.FirstName = firstName;
        this.LastName = lastName;
    }

    public int Id
    {
        get
        {
            return this.id;
        }

        set
        {
            if (value < 0)
            {
                throw new ArgumentException("ID can not be negative!", "id");
            }

            this.id = value;
        }
    }

    public string FirstName
    {
        get
        {
            return this.firstName;
        }

        set
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentNullException("firstName", "First Name can not be null or empty!");
            }

            this.firstName = value;
        }
    }

    public string LastName
    {
        get
        {
            return this.lastName;
        }

        set
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentNullException("lastName", "Last Name can not be null or empty!");
            }

            this.lastName = value;
        }
    }

    public override string ToString()
    {
        return string.Format("ID:{0}, First Name:{1}, Last Name:{2}", this.Id, this.FirstName, this.LastName);
    }
}