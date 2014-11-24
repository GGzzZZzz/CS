using System;
using System.Text;

internal class DropoutStudent : Student
{
    private string dropoutReason;

    public DropoutStudent(string firstName, string lastName, int age, int studentNumber, float averageGrade, string dropoutReason)
        : base(firstName, lastName, age, studentNumber, averageGrade)
    {
        this.DropoutReason = dropoutReason;
    }

    public string DropoutReason
    {
        get
        {
            return this.dropoutReason;
        }

        set
        {
            if (value.Length < 10)
            {
                throw new ArgumentException("Dropout reason can not be shorter than 20 symbols!", "value");
            }

            this.dropoutReason = value;
        }
    }

    public string Reaplly()
    {
        StringBuilder studentInfo = new StringBuilder();

        studentInfo.AppendLine("First name: " + this.FirstName);
        studentInfo.AppendLine("Last name: " + this.LastName);
        studentInfo.AppendLine("Age: " + this.Age);
        studentInfo.AppendLine("Student number: " + this.StudentNumber);
        studentInfo.AppendLine("Average grade: " + this.AverageGrade.ToString());
        studentInfo.AppendLine("Dropout reason: " + this.DropoutReason);

        return studentInfo.ToString();
    }
}