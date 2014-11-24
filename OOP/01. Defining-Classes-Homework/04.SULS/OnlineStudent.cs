using System;
using System.Text;

internal class OnlineStudent : CurrentStudent
{
    public OnlineStudent(string firstName, string lastName, int age, int studentNumber, float averageGrade, string currentCourse)
        : base(firstName, lastName, age, studentNumber, averageGrade, currentCourse)
    {
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

        return studentInfo.ToString();
    }
}