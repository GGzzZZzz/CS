using System;
using System.Text;

internal class OnsiteStudent : CurrentStudent
{
    private int numberOfVisits;

    public OnsiteStudent(string firstName, string lastName, int age, int studentNumber, float averageGrade, string currentCourse, int numberOfVisits)
        : base(firstName, lastName, age, studentNumber, averageGrade, currentCourse)
    {
        this.NumberOfVisits = numberOfVisits;
    }

    public int NumberOfVisits
    {
        get
        {
            return this.numberOfVisits;
        }

        set
        {
            if (value < 0)
            {
                throw new ArgumentException("Number of visits can not be negative!", "value");
            }

            this.numberOfVisits = value;
        }
    }

    public override string ToString()
    {
        StringBuilder studentInfo = new StringBuilder();

        studentInfo.AppendLine("First name: " + this.FirstName);
        studentInfo.AppendLine("Last name: " + this.LastName);
        studentInfo.AppendLine("Age: " + this.Age);
        studentInfo.AppendLine("Student number: " + this.StudentNumber);
        studentInfo.AppendLine("Average grade: " + this.AverageGrade);
        studentInfo.AppendLine("Current course: " + this.CurrentCourse);
        studentInfo.AppendLine("Number of visits: " + this.NumberOfVisits);

        return studentInfo.ToString();
    }
}