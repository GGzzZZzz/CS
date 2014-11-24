﻿using System;

public abstract class Human
{
    private string firstName;
    private string lastName;

    public Human(string firstName, string lastName)
    {
        this.FirstName = firstName;
        this.LastName = lastName;
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
                throw new ArgumentNullException("firstName", "First name can not be null or empty!");
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
                throw new ArgumentNullException("lastName", "Last name can not be null or empty!");
            }

            this.lastName = value;
        }
    }

    public override string ToString()
    {
        return string.Format("First Name:{0}, Last Name:{1}, ", this.FirstName, this.LastName);
    }
}