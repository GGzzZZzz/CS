public class Kitten : Cat
{
    private string gender = "female";

    public Kitten(string name, int age)
        : base(name, age)
    {
    }

    public new string Gender
    {
        get { return this.gender; }
    }
}