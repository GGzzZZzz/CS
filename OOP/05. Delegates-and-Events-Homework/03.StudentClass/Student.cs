using System;

public delegate void PropertyChangedEventHandler(object sender, PropertyChangedEventArgs eventArgs);

public class Student
{
    private string name;
    private int age;

    public Student(string name, int age)
    {
        this.Name = name;
        this.Age = age;
    }

    public event PropertyChangedEventHandler PropertyChanged;

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
                throw new ArgumentException("Student's name can not be null or empty!", "value");
            }

            if (value != this.Name)
            {
                this.OnPropertyChanged(this, new PropertyChangedEventArgs("Name", this.Name, value));
                this.name = value;
            }
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
            if (value < 18)
            {
                throw new ArgumentOutOfRangeException("value", "Student's age can not be smaller than 18 years!");
            }

            if (value != this.Age)
            {
                this.OnPropertyChanged(this, new PropertyChangedEventArgs("Age", this.Age, value));
                this.age = value;
            }
        }
    }

    protected void OnPropertyChanged(object sender, PropertyChangedEventArgs eventArgs)
    {
        if (this.PropertyChanged != null)
        {
            this.PropertyChanged(this, eventArgs);
        }
    }
}