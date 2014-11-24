public class Tomcat : Cat
{
    private string gender = "male";

    public Tomcat(string name, int age)
        : base(name, age)
    {
    }

    public new string Gender
    {
        get { return this.gender; }
    }
}