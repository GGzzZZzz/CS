using System;
using System.Collections.Generic;
using System.Text;

public class Student
{
    private string firstName;
    private string lastName;
    private int age;
    private int facultyNumber;
    private string phone;
    private string email;
    private IList<int> marks;
    private int groupNumber;
    private string groupName;

    public Student(
        string firstName,
        string lastName,
        int age,
        int facultyNumber,
        string phone,
        string email,
        IList<int> marks,
        int groupNumber,
        string groupName)
    {
        this.FirstName = firstName;
        this.LastName = lastName;
        this.Age = age;
        this.FacultyNumber = facultyNumber;
        this.Phone = phone;
        this.Email = email;
        this.Marks = marks;
        this.GroupNumber = groupNumber;
        this.GroupName = groupName;
    }

    public string FirstName
    {
        get
        {
            return this.firstName;
        }

        private set
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentNullException(
                    "FirstName",
                    "Student's first name can not be null or empty!");
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

        private set
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentNullException(
                    "LastName",
                    "Student's last name can not be null or empty!");
            }

            this.lastName = value;
        }
    }

    public int Age
    {
        get
        {
            return this.age;
        }

        private set
        {
            if (value < 18)
            {
                throw new ArgumentOutOfRangeException(
                    "Age",
                    "Student's age can not be smaller than 18!");
            }

            this.age = value;
        }
    }

    public int FacultyNumber
    {
        get
        {
            return this.facultyNumber;
        }

        private set
        {
            if (value < 0)
            {
                throw new ArgumentNullException(
                    "FacultyNumber",
                   "Student's faculty number can not be null or empty!");
            }

            this.facultyNumber = value;
        }
    }

    public string Phone
    {
        get
        {
            return this.phone;
        }

        private set
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentNullException(
                    "Phone",
                    "Student's phone can not be null or empty!");
            }

            this.phone = value;
        }
    }

    public string Email
    {
        get
        {
            return this.email;
        }

        private set
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentNullException(
                    "Email",
                    "Student's email can not be null or empty!");
            }

            this.email = value;
        }
    }

    public IList<int> Marks
    {
        get
        {
            return this.marks;
        }

        private set
        {
            if (value == null)
            {
                this.marks = new List<int>();
            }
            else
            {
                this.marks = value;
            }
        }
    }

    public int GroupNumber
    {
        get
        {
            return this.groupNumber;
        }

        set
        {
            if (value < 0)
            {
                throw new ArgumentException(
                    "GroupNumber",
                    "Student's group number can not be negative!");
            }

            this.groupNumber = value;
        }
    }

    public string GroupName
    {
        get
        {
            return this.groupName;
        }

        set
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentNullException(
                    "GroupName",
                    "Student's group name can not be null or empty!");
            }

            this.groupName = value;
        }
    }

    public override string ToString()
    {
        StringBuilder result = new StringBuilder("{First Name:" + this.FirstName + ", Last Name:" + this.LastName + ", Age:" + this.Age + ", Faculty Number:" + this.FacultyNumber + ", Phone:" + this.Phone + ", Email:" + this.Email + ", Marks: (" + string.Join(", ", this.Marks) + ")" + ", Group Number:" + this.GroupNumber + ", Group Name:" + this.GroupName + "}");

        return result.ToString();
    }
}